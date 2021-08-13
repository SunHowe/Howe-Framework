namespace HoweFramework.Variable
{
    /// <summary>
    /// 变量储存容器
    /// </summary>
    public interface IVariableContainer<TKey>
    {
        /// <summary>
        /// 将指定数据存到容器中
        /// </summary>
        void SetData<TValue>(TKey key, TValue data);

        /// <summary>
        /// 从容器中获取指定数据 若该容器内不存在指定键值或对应的数据与传入类型不符合 则返回<see cref="defaultValue"/>
        /// </summary>
        TValue GetData<TValue>(TKey key, TValue defaultValue = default);

        /// <summary>
        /// 从容器中移除指定数据，并返回该数据 若该容器内不存在指定键值或对应的数据与传入类型不符合 则返回<see cref="defaultValue"/>
        /// </summary>
        TValue RemoveData<TValue>(TKey key, TValue defaultValue = default);

        /// <summary>
        /// 从容器中移除指定数据(不对值类型进行校验)
        /// </summary>
        void RemoveData(TKey key);

        /// <summary>
        /// 移除该容器内的所有数据
        /// </summary>
        void RemoveAllData();
    }
}