using System;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 多实例类型的对象池接口
    /// </summary>
    public interface IPools : IDisposable
    {
        /// <summary>
        /// 返回一个可用实例
        /// </summary>
        T Acquire<T>() where T : class;

        /// <summary>
        /// 将实例存入对象池
        /// 返回一个可用实例
        /// </summary>
        void Release<T>(T value) where T : class;
    }
}