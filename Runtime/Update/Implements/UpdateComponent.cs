using System;
using HoweFramework.Base;
using UnityEngine;

namespace HoweFramework.Update.Implements
{
    [AddComponentMenu("")]
    internal class UpdateComponent : MonoBehaviour
    {
        private IUpdate _context;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void SetContext(IUpdate context)
        {
            _context = context;
        }

        private void Update()
        {
            if (_context == null)
                return;
            
            _context.Update(Time.deltaTime);
        }
    }
}