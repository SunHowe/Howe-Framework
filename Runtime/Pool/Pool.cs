using System;
using System.Collections.Generic;

namespace HoweFramework.Pool
{
    public sealed class Pool<T> : IPool<T> where T : class
    {
        private readonly Queue<T> _pool = new Queue<T>();

        private readonly Func<T> _factory;
        private readonly Action<T> _destroy;

        private readonly bool _isReset;
        private readonly bool _isDisposable;

        public Pool(Func<T> factory = null, Action<T> destroy = null)
        {
            _factory = factory ?? Activator.CreateInstance<T>;
            _destroy = destroy ?? DestroyInstance;

            var type = typeof(T);
            _isReset = typeof(IReset).IsAssignableFrom(type);
            _isDisposable = typeof(IDisposable).IsAssignableFrom(type);
        }

        public void Dispose()
        {
            while (_pool.Count > 0)
                _destroy.Invoke(_pool.Dequeue());
        }

        public T Pop()
        {
            return _pool.Count > 0 ? _pool.Dequeue() : _factory.Invoke();
        }

        public void Push(T value)
        {
            if (_isReset)
                ((IReset) value).Reset();
            
            _pool.Enqueue(value);
        }

        private void DestroyInstance(T instance)
        {
            if (!_isDisposable)
                return;

            ((IDisposable) instance).Dispose();
        }
    }
}