using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Payments.PurchaseOrder.Models
{
    public class ConfigurationModel : BaseNasModel
    {
        [NasResourceDisplayName("Plugins.Payment.PurchaseOrder.AdditionalFee")]
        public decimal AdditionalFee { get; set; }

        [NasResourceDisplayName("Plugins.Payment.PurchaseOrder.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
    }
}