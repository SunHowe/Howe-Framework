using CatLib;

namespace HoweFramework.Pool
{
    /// <summary>
    /// 对象池服务
    /// </summary>
    public class PoolService : Facade<IPoolService>
    {
        /// <summary>
        /// 返回一个可用实例
        /// </summary>
        public static T Acquire<T>() where T : class
        {
            return That.Acquire<T>();
        }

        /// <summary>
        /// 将实例存入对象池
        /// 返回一个可用实例
        /// </summary>
        public static void Release<T>(T value) where T : class
        {
            That.Release(value);
        }
    }
}