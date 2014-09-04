using System.Web.Routing;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Customer
{
    public partial class ExternalAuthenticationMethodModel : BaseDIPSkyModel
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
    }
}