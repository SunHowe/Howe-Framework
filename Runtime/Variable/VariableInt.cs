namespace HoweFramework.Variable
{
    /// <summary>
    /// 整型变量容器 提供与int的各类运算符重载接口
    /// </summary>
    public class VariableInt : Variable<int>
    {
        public static implicit operator int(VariableInt variable)
        {
            return variable.value;
        }
        
        public static int operator +(VariableInt a, int b)
        {
            return a.value + b;
        }

        public static int operator +(VariableInt a, VariableInt b)
        {
            return a.value + b.value;
        }
    }
}