using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Messages
{
    public partial class NewsLetterSubscriptionListModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.Customers.Customers.List.SearchEmail")]
        public string SearchEmail { get; set; }
    }
}