using System;
using CatLib;
using HoweFramework.Base;

namespace HoweFramework.Core
{
    /// <summary>
    /// 框架核心接口
    /// </summary>
    public interface ICore : IInitialize, IDisposable
    {
        IApplication catLibApplication { get; }
    }
}