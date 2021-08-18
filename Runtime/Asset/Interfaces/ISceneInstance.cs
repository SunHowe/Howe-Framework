using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace HoweFramework.Asset
{
    public interface ISceneInstance
    {
        Scene scene { get; }

        /// <summary>
        /// 异步激活场景
        /// </summary>
        Task ActivateAsync();

        /// <summary>
        /// 同步激活场景
        /// </summary>
        void Activate();
    }
}