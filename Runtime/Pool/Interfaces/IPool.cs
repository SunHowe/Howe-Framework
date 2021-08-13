using System;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 对象池接口
    /// </summary>
    public interface IPool<T> : IDisposable where T : class
    {
        /// <summary>
        /// 返回一个可用实例
        /// </summary>
        T Pop();

        /// <summary>
        /// 将实例存入对象池
        /// </summary>
        void Push(T value);
    }
}