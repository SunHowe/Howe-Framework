using HoweFramework.Base;

namespace HoweFramework.Update.Interfaces
{
    /// <summary>
    /// 帧更新服务
    /// </summary>
    public interface IUpdateService
    {
        void Register(IUpdate update);

        void Unregister(IUpdate update);
    }
}