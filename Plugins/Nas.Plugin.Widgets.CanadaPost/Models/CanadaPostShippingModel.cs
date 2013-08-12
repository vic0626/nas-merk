using Nas.Web.Framework;

namespace Nas.Plugin.Shipping.CanadaPost.Models
{
    public class CanadaPostShippingModel
    {
        [NasResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.Url")]
        public string Url { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.Port")]
        public int Port { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.CustomerId")]
        public string CustomerId { get; set; }
    }
}