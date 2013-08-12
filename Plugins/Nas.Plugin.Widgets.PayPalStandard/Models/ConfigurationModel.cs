using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Payments.PayPalStandard.Models
{
    public class ConfigurationModel : BaseNasModel
    {
        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.BusinessEmail")]
        public string BusinessEmail { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.PDTToken")]
        public string PdtToken { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.PDTValidateOrderTotal")]
        public bool PdtValidateOrderTotal { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.PassProductNamesAndTotals")]
        public bool PassProductNamesAndTotals { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.EnableIpn")]
        public bool EnableIpn { get; set; }

        [NasResourceDisplayName("Plugins.Payments.PayPalStandard.Fields.IpnUrl")]
        public string IpnUrl { get; set; }
    }
}