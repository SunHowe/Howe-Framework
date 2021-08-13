using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace HoweFramework.Pool
{
    public sealed class KeyPool<TKey, T> : IKeyPool<TKey, T> where T : class
    {
        private readonly Dictionary<TKey, IPool<T>> _pools = new Dictionary<TKey, IPool<T>>();

        private readonly Func<TKey, T> _factory;
        private readonly Action<TKey, T> _destroy;

        public KeyPool(Func<TKey, T> factory, Action<TKey, T> destroy = null)
        {
            Assert.IsNotNull(factory);

            _factory = factory;
            _destroy = destroy;
        }

        public void Dispose()
        {
            foreach (var pool in _pools.Values)
                pool.Dispose();

            _pools.Clear();
        }

        public T Acquire(TKey key)
        {
            return GetPool(key).Acquire();
        }

        public void Release(TKey key, T value)
        {
            GetPool(key).Release(value);
        }

        private IPool<T> GetPool(TKey key)
        {
            if (_pools.TryGetValue(key, out var pool))
                return pool;

            T Factory() => _factory.Invoke(key);

            pool = _destroy != null ? new Pool<T>(Factory, instance => _destroy.Invoke(key, instance)) : new Pool<T>(Factory);
            _pools.Add(key, pool);

            return pool;
        }
    }
}