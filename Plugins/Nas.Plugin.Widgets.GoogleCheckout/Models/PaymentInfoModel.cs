using GCheckout;
using GCheckout.Checkout;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Payments.GoogleCheckout.Models
{
    public class PaymentInfoModel : BaseNasModel
    {
        public string GifFileName { get; set; }

        public BackgroundType BackgroundType { get; set; }

        public string MerchantId { get; set; }

        public string MerchantKey { get; set; }

        public EnvironmentType Environment { get; set; }

        public string Currency { get; set; }

        public int CartExpirationMinutes { get; set; }

        public bool UseHttps { get; set; }

    }
}