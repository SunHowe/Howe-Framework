using System.Collections.Generic;
using HoweFramework.Pool;

namespace HoweFramework.Variable
{
    /// <summary>
    /// 变量容器
    /// </summary>
    public sealed class VariableContainer<TKey> : IVariableContainer<TKey>
    {
        private readonly Dictionary<TKey, IVariable> _variables = new Dictionary<TKey, IVariable>();

        public void SetData<TValue>(TKey key, TValue data)
        {
            if (_variables.TryGetValue(key, out var variableBase))
            {
                if (variableBase is Variable<TValue> variable)
                {
                    variable.value = data;
                    return;
                }

                PoolService.Release(variableBase);
            }

            var newVariable = PoolService.Acquire<Variable<TValue>>();
            newVariable.value = data;
            _variables[key] = newVariable;
        }

        public TValue GetData<TValue>(TKey key, TValue defaultValue = default)
        {
            if (_variables.TryGetValue(key, out var variableBase) && variableBase is Variable<TValue> variable)
                return variable.value;

            return defaultValue;
        }

        public TValue RemoveData<TValue>(TKey key, TValue defaultValue = default)
        {
            if (_variables.TryGetValue(key, out var variableBase) && variableBase is Variable<TValue> variable)
            {
                var value = variable.value;
                _variables.Remove(key);
                PoolService.Release(variable);
                return value;
            }

            return defaultValue;
        }

        public void RemoveData(TKey key)
        {
            if (!_variables.TryGetValue(key, out var variableBase))
                return;

            _variables.Remove(key);
            PoolService.Release(variableBase);
        }

        public void RemoveAllData()
        {
            foreach (var variable in _variables.Values)
                PoolService.Release(variable);

            _variables.Clear();
        }
    }
}