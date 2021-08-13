using System;
using System.Collections.Generic;

namespace HoweFramework.Pool
{
    public sealed class Pools : IPools
    {
        private readonly Dictionary<Type, Pool> _pools = new Dictionary<Type, Pool>();

        public T Acquire<T>() where T : class
        {
            return (T) GetPool<T>().Acquire();
        }

        public void Release<T>(T value) where T : class
        {
            GetPool<T>().Release(value);
        }

        private Pool GetPool<T>()
        {
            var type = typeof(T);
            if (_pools.TryGetValue(type, out var pool))
                return pool;

            pool = new Pool(type);
            _pools.Add(type, pool);
            return pool;
        }

        public void Dispose()
        {
            foreach (var pool in _pools.Values)
                pool.Dispose();

            _pools.Clear();
        }
    }
}