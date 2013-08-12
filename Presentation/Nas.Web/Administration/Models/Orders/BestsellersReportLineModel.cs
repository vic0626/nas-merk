using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Orders
{
    public partial class BestsellersReportLineModel : BaseNasModel
    {
        public int ProductVariantId { get; set; }
        [NasResourceDisplayName("Admin.SalesReport.Bestsellers.Fields.Name")]
        public string ProductVariantFullName { get; set; }

        [NasResourceDisplayName("Admin.SalesReport.Bestsellers.Fields.TotalAmount")]
        public string TotalAmount { get; set; }

        [NasResourceDisplayName("Admin.SalesReport.Bestsellers.Fields.TotalQuantity")]
        public decimal TotalQuantity { get; set; }
    }
}