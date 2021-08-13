using HoweFramework.Pool;

namespace HoweFramework.Variable
{
    /// <summary>
    /// 泛型变量容器
    /// </summary>
    public sealed class Variable<T> : IVariable<T>
    {
        public T value { get; set; }
        
        public static implicit operator T(Variable<T> variable)
        {
            return variable.value;
        }

        public static implicit operator Variable<T>(T value)
        {
            var variable = PoolService.Acquire<Variable<T>>();
            variable.value = value;
            return variable;
        }

        public void Reset()
        {
            value = default;
        }
    }
}