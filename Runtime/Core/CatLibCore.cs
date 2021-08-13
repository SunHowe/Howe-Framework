using CatLib;
using HoweFramework.Base;
using CatLib.Container;

namespace HoweFramework.Core
{
    /// <summary>
    /// 基于CatLib的核心
    /// </summary>
    public class CatLibCore : ICore
    {
        public IApplication catLibApplication => _application;

        private readonly Application _application;

        public CatLibCore()
        {
            _application = Application.New(true);
            _application.OnResolving<IService>(service => { service.Initialize(); });
            _application.OnRelease<IService>(service => { service.Dispose(); });
        }

        public void Initialize()
        {
            _application.Bootstrap();
            _application.Init();
        }

        public void Dispose()
        {
            _application.Terminate();
        }
    }
}