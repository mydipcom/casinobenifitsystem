using System.Web.Routing;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Cms
{
    public partial class RenderWidgetModel : BaseDIPSkyModel
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
    }
}