﻿using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Admin.Infrastructure
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "NetAdvImage",
                "content/editors/tinymce/plugins/netadvimage/{action}",
                new { controller = "NetAdvImage", area = "Admin" }
            );
        }

        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
