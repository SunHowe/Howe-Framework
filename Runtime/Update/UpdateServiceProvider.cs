using CatLib;
using CatLib.Container;
using HoweFramework.Update.Implements;
using HoweFramework.Update.Interfaces;

namespace HoweFramework.Update
{
    /// <summary>
    /// 更新服务提供者
    /// </summary>
    public class UpdateServiceProvider : ServiceProvider
    {
        public override void Register()
        {
            App.Singleton<IUpdateService, UpdateServiceImpl>();
        }
    }
}