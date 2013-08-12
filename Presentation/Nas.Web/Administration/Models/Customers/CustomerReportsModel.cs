using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Customers
{
    public partial class CustomerReportsModel : BaseNasModel
    {
        public BestCustomersReportModel BestCustomersByOrderTotal { get; set; }
        public BestCustomersReportModel BestCustomersByNumberOfOrders { get; set; }
    }
}