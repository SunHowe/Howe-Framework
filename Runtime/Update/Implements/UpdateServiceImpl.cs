using HoweFramework.Base;
using HoweFramework.Update.Interfaces;
using UnityEngine;

namespace HoweFramework.Update.Implements
{
    /// <summary>
    /// 更新服务实现
    /// </summary>
    public class UpdateServiceImpl : IUpdateService, IUpdate, IService
    {
        private UpdateComponent _updateComponent;
        
        public void Initialize()
        {
            _updateComponent = new GameObject("Update Service").AddComponent<UpdateComponent>();
            
        }

        public void Dispose()
        {
        }

        public void Register(IUpdate update)
        {
        }

        public void Unregister(IUpdate update)
        {
        }

        public void Update(float dt)
        {
        }
    }
}