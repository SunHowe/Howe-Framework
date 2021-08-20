using System.Threading.Tasks;

namespace HoweFramework.UI.Interfaces
{
    /// <summary>
    /// UI服务接口
    /// </summary>
    public interface IUIService
    {
        /// <summary>
        /// 异步打开UI窗口
        /// </summary>
        Task OpenUIAsync(string uiKey, object userData = null);

        /// <summary>
        /// 同步打开UI窗口
        /// </summary>
        void OpenUI(string uiKey, object userData = null);

        /// <summary>
        /// 关闭UI窗口
        /// </summary>
        void CloseUI(string uiKey);

        /// <summary>
        /// 判断指定UI窗口是否处于显示状态
        /// </summary>
        bool HasUI(string uiKey);
    }
}