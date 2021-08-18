using System.Threading.Tasks;
using UnityEngine;

namespace HoweFramework.Asset
{
    /// <summary>
    /// 资产服务
    /// </summary>
    public interface IAssetService
    {
        /// <summary>
        /// 异步加载资产资源
        /// </summary>
        Task<T> LoadAsync<T>(string resKey);

        /// <summary>
        /// 实例化指定对象
        /// </summary>
        Task<GameObject> InstantiateAsync(string resKey);

        /// <summary>
        /// 异步加载资产资源
        /// </summary>
        T LoadSync<T>(string resKey);

        /// <summary>
        /// 实例化指定对象
        /// </summary>
        GameObject InstantiateSync(string resKey);

        /// <summary>
        /// 释放指定资源
        /// </summary>
        void Release<T>(T asset);

        /// <summary>
        /// 释放指定对象
        /// </summary>
        void Release(GameObject gameObject);
    }
}