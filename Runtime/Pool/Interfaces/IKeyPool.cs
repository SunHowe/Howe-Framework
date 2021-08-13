using System;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 提供主键索引的对象池接口
    /// </summary>
    public interface IKeyPool<TKey, T> : IDisposable where T : class
    {
        /// <summary>
        /// 返回一个可用实例
        /// </summary>
        T Acquire(TKey key);

        /// <summary>
        /// 将实例存入对象池
        /// </summary>
        void Release(TKey key, T value);
    }
}