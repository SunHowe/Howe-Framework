using CatLib;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 对象池服务提供者
    /// </summary>
    public class PoolServiceProvider : IServiceProvider
    {
        public void Init()
        {
        }

        public void Register()
        {
            App.Singleton<IPoolService, PoolServiceImpl>();
        }
    }
}