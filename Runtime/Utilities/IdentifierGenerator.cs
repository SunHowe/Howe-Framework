using System;
using HoweFramework.Pool;

namespace HoweFramework.Utilities
{
    /// <summary>
    /// 唯一id生成器
    /// </summary>
    public sealed class IdentifierGenerator : IReset
    {
        private int _id;

        public IdentifierGenerator(int idBegin = 1)
        {
            _id = idBegin - 1;
        }

        public int Spawn()
        {
            return ++_id;
        }

        public void Dispose()
        {
            _id = 0;
        }

        public void Reset()
        {
            _id = 0;
        }
    }
}