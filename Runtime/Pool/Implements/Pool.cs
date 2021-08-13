using System;
using System.Collections.Generic;

namespace HoweFramework.Pool
{
    internal sealed class Pool : IDisposable
    {
        private readonly Queue<object> _pool = new Queue<object>();

        private readonly Func<object> _factory;
        private readonly Action<object> _destroy;

        private readonly Type _type;
        private readonly bool _isReset;
        private readonly bool _isDisposable;

        public Pool(Type type, Func<object> factory = null, Action<object> destroy = null)
        {
            _factory = factory ?? CreateInstance;
            _destroy = destroy ?? DestroyInstance;

            _type = type;
            _isReset = typeof(IReset).IsAssignableFrom(type);
            _isDisposable = typeof(IDisposable).IsAssignableFrom(type);
        }

        public void Dispose()
        {
            while (_pool.Count > 0)
                _destroy.Invoke(_pool.Dequeue());
        }

        public object Acquire()
        {
            return _pool.Count > 0 ? _pool.Dequeue() : _factory.Invoke();
        }

        public void Release(object value)
        {
            if (value == null)
                return;

            if (_isReset)
                ((IReset) value).Reset();

            _pool.Enqueue(value);
        }

        private void DestroyInstance(object instance)
        {
            if (!_isDisposable)
                return;

            ((IDisposable) instance).Dispose();
        }

        private object CreateInstance()
        {
            return Activator.CreateInstance(_type);
        }
    }


    public sealed class Pool<T> : IPool<T> where T : class
    {
        private readonly Pool _pool;

        public Pool(Func<T> factory = null, Action<T> destroy = null)
        {
            var type = typeof(T);

            Func<object> func = null;
            if (factory != null)
                func = factory.Invoke;

            Action<object> action = null;
            if (destroy != null)
                action = o => destroy.Invoke((T) o);

            _pool = new Pool(type, func, action);
        }

        public void Dispose()
        {
            _pool.Dispose();
        }

        public T Acquire()
        {
            return (T) _pool.Acquire();
        }

        public void Release(T value)
        {
            _pool.Release(value);
        }
    }
}