using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Payments.PayPalDirect.Models
{
    public class ConfigurationModel : BaseNasModel
    {
        [NasResourceDisplayName("Plugins.Payments.PayPalDirect.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }

        public int TransactModeId { get; set; }
        [NasResourceDisplayName("Plugins.Payments.PayPalDirect.Fields.TransactMode")]
        public SelectList TransactModeValues { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalDirect.Fields.ApiAccountName")]
        public string ApiAccountName { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalDirect.Fields.ApiAccountPassword")]
        public string ApiAccountPassword { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalDirect.Fields.Signature")]
        public string Signature { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalDirect.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalDirect.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
    }
}