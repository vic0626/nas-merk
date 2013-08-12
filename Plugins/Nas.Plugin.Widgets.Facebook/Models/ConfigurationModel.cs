using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.ExternalAuth.Facebook.Models
{
    public class ConfigurationModel : BaseNasModel
    {
        [NasResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientKeyIdentifier")]
        public string ClientKeyIdentifier { get; set; }
        [NasResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientSecret")]
        public string ClientSecret { get; set; }
    }
}