using CatLib;
using HoweFramework.Base;
using HoweFramework.Update.Interfaces;

namespace HoweFramework.Update
{
    /// <summary>
    /// 更新服务门面
    /// </summary>
    public class UpdateService : Facade<IUpdateService>
    {
        /// <summary>
        /// 注册逐帧更新
        /// </summary>
        public static void Register(IUpdate update)
        {
            That.Register(update);
        }

        /// <summary>
        /// 取消注册逐帧更新
        /// </summary>
        public static void Unregister(IUpdate update)
        {
            That.Unregister(update);
        }
    }
}