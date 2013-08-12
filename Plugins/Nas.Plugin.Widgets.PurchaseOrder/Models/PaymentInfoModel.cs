using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Payments.PurchaseOrder.Models
{
    public class PaymentInfoModel : BaseNasModel
    {
        [NasResourceDisplayName("Plugins.Payment.PurchaseOrder.PurchaseOrderNumber")]
        [AllowHtml]
        public string PurchaseOrderNumber { get; set; }
    }
}