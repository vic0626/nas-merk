using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Orders
{
    public partial class OrderIncompleteReportLineModel : BaseNasModel
    {
        [NasResourceDisplayName("Admin.SalesReport.Incomplete.Item")]
        public string Item { get; set; }

        [NasResourceDisplayName("Admin.SalesReport.Incomplete.Total")]
        public string Total { get; set; }

        [NasResourceDisplayName("Admin.SalesReport.Incomplete.Count")]
        public int Count { get; set; }
    }
}
