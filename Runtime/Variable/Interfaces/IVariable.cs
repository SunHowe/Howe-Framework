using HoweFramework.Pool;

namespace HoweFramework.Variable
{
    /// <summary>
    /// 泛型变量容器接口
    /// </summary>
    public interface IVariable<T> : IVariable
    {
        /// <summary>
        /// 存储的原始变量值
        /// </summary>
        T value { get; set; }
    }

    public interface IVariable : IReset
    {
    }
}