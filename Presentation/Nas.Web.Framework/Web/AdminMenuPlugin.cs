using Nas.Core.Plugins;
using Telerik.Web.Mvc.UI;

namespace Nas.Web.Framework.Web
{
    public interface IAdminMenuPlugin : IPlugin
    {
        void BuildMenuItem(MenuItemBuilder menuItemBuilder);
    }
}
