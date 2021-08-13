using System;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 对象池接口
    /// </summary>
    public interface IPool : IDisposable
    {
        /// <summary>
        /// 返回一个指定类型的可用实例 允许传入工厂方法，当实例不存在时从工厂创建实例(不传入工厂方法则使用默认的反射构造)
        /// </summary>
        T Pop<T>(Func<T> factory = null) where T : class;

        /// <summary>
        /// 将实例存入对象池
        /// </summary>
        void Push<T>(T value) where T : class;
    }
}