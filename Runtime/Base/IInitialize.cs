namespace HoweFramework.Base
{
    /// <summary>
    /// 初始化接口
    /// </summary>
    public interface IInitialize
    {
        void Initialize();
    }

    /// <summary>
    /// 带泛型参数的初始化接口
    /// </summary>
    public interface IInitialize<T>
    {
        void Initialize(T param);
    }
}