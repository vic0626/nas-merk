using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Orders
{
    public partial class NeverSoldReportLineModel : BaseNasModel
    {
        public int ProductVariantId { get; set; }
        [NasResourceDisplayName("Admin.SalesReport.NeverSold.Fields.Name")]
        public string ProductVariantFullName { get; set; }
    }
}