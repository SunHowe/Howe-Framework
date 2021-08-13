using System;

namespace HoweFramework.Base
{
    /// <summary>
    /// 服务接口 定义了基础的生命周期 在服务实例被创建时，会调用其Initialize接口;在服务实例被销毁时，会调用其Dispose接口
    /// </summary>
    public interface IService : IInitialize, IDisposable
    {
    }
}