﻿using System;
using System.Web.Mvc;
using DIPSky.Core;
using DIPSky.Core.Data;
using DIPSky.Core.Domain.Customers;
using DIPSky.Core.Infrastructure;
using DIPSky.Services.Common;

namespace DIPSky.Web.Framework
{
    public class StoreLastVisitedPageAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!DataSettingsHelper.DatabaseIsInstalled())
                return;

            if (filterContext == null || filterContext.HttpContext == null || filterContext.HttpContext.Request == null)
                return;

            //don't apply filter to child methods
            if (filterContext.IsChildAction)
                return;

            //only GET requests
            if (!String.Equals(filterContext.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
                return;

            var customerSettings = EngineContext.Current.Resolve<CustomerSettings>();
            if (!customerSettings.StoreLastVisitedPage)
                return;

            var webHelper = EngineContext.Current.Resolve<IWebHelper>();
            var pageUrl = webHelper.GetThisPageUrl(true);
            if (!String.IsNullOrEmpty(pageUrl))
            {
                var workContext = EngineContext.Current.Resolve<IWorkContext>();
                var genericAttributeService = EngineContext.Current.Resolve<IGenericAttributeService>();

                var previousPageUrl = workContext.CurrentCustomer.GetAttribute<string>(SystemCustomerAttributeNames.LastVisitedPage);
                if (!pageUrl.Equals(previousPageUrl))
                {
                    genericAttributeService.SaveAttribute(workContext.CurrentCustomer, SystemCustomerAttributeNames.LastVisitedPage, pageUrl);
                }
            }
        }
    }
}
