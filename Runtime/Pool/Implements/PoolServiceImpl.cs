using HoweFramework.Base;

namespace HoweFramework.Pool
{
    internal class PoolServiceImpl : IPoolService, IService
    {
        private IPools _pools;

        public T Acquire<T>() where T : class
        {
            return _pools.Acquire<T>();
        }

        public void Release<T>(T value) where T : class
        {
            _pools.Release(value);
        }

        public void Initialize()
        {
            _pools = new Pools();
        }

        public void Dispose()
        {
            _pools.Dispose();
            _pools = null;
        }
    }
}