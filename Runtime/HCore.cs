using HoweFramework.Core;

namespace HoweFramework
{
    /// <summary>
    /// 框架核心门面
    /// </summary>
    public static class HCore
    {
        private static ICore _core;
        public static ICore That => _core ??= new CatLibCore();
    }
}