using System.Collections.Generic;
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

        private readonly List<IUpdate> _updates = new List<IUpdate>();
        private readonly List<IUpdate> _buffer = new List<IUpdate>();
        
        public void Initialize()
        {
            _updateComponent = new GameObject("Update Service").AddComponent<UpdateComponent>();
            _updateComponent.SetContext(this);
        }

        public void Dispose()
        {
            Object.Destroy(_updateComponent);
        }

        public void Register(IUpdate update)
        {
            _updates.Add(update);
        }

        public void Unregister(IUpdate update)
        {
            _updates.Remove(update);
        }

        public void Update(float dt)
        {
            _buffer.Clear();
            _buffer.AddRange(_updates);
            
            foreach (var update in _buffer)
                update.Update(dt);
        }
    }
}