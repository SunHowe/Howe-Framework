using HoweFramework.Base;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 全局对象池服务
    /// </summary>
    public interface IPoolService
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