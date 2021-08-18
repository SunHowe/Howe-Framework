using CatLib;
using HoweFramework.Base;
using HoweFramework.Pool;
using HoweFramework.Update;

namespace HoweFramework
{
    /// <summary>
    /// 引擎核心引导程序
    /// </summary>
    public class HCoreBoostrap : IBootstrap
    {
        public void Bootstrap()
        {
            App.OnResolving<IService>(service => { service.Initialize(); });
            App.OnRelease<IService>(service => { service.Dispose(); });
            App.Register(new PoolServiceProvider());
            App.Register(new UpdateServiceProvider());
        }
    }
}