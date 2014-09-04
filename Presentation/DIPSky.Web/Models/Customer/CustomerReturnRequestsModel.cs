using System;
using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Customer
{
    public partial class CustomerReturnRequestsModel : BaseDIPSkyModel
    {
        public CustomerReturnRequestsModel()
        {
            Items = new List<ReturnRequestModel>();
        }

        public IList<ReturnRequestModel> Items { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }

        #region Nested classes
        public partial class ReturnRequestModel : BaseDIPSkyEntityModel
        {
            public string ReturnRequestStatus { get; set; }
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductSeName { get; set; }
            public int Quantity { get; set; }

            public string ReturnReason { get; set; }
            public string ReturnAction { get; set; }
            public string Comments { get; set; }

            public DateTime CreatedOn { get; set; }
        }
        #endregion
    }
}