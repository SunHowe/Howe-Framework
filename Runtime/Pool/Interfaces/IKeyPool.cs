using System;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 提供主键索引的对象池接口
    /// </summary>
    public interface IKeyPool<TKey> : IDisposable
    {
        /// <summary>
        /// 返回一个指定类型的可用实例 允许传入工厂方法，当实例不存在时从工厂创建实例(不传入工厂方法则使用默认的反射构造)
        /// </summary>
        T Pop<T>(TKey key, Func<TKey, T> factory = null) where T : class;

        /// <summary>
        /// 将实例存入对象池
        /// </summary>
        void Push<T>(TKey key, T value) where T : class;
    }
}