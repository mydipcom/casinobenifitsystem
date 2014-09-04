using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Customers
{
    public partial class CustomerReportsModel : BaseDIPSkyModel
    {
        public BestCustomersReportModel BestCustomersByOrderTotal { get; set; }
        public BestCustomersReportModel BestCustomersByNumberOfOrders { get; set; }
    }
}