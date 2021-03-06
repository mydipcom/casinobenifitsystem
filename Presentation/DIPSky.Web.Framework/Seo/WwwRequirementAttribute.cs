﻿using System;
using System.Web.Mvc;
using DIPSky.Core;
using DIPSky.Core.Data;
using DIPSky.Core.Domain.Seo;
using DIPSky.Core.Infrastructure;

namespace DIPSky.Web.Framework.Seo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class WwwRequirementAttribute : FilterAttribute, IAuthorizationFilter
    {
        public virtual void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
                throw new ArgumentNullException("filterContext");

            //don't apply filter to child methods
            if (filterContext.IsChildAction)
                return;

            // only redirect for GET requests, 
            // otherwise the browser might not propagate the verb and request body correctly.
            if (!String.Equals(filterContext.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
                return;

            if (!DataSettingsHelper.DatabaseIsInstalled())
                return;
            var seoSettings = EngineContext.Current.Resolve<SeoSettings>();

            switch (seoSettings.WwwRequirement)
            {
                case WwwRequirement.WithWww:
                {
                    var webHelper = EngineContext.Current.Resolve<IWebHelper>();
                    string url = webHelper.GetThisPageUrl(true);
                    var currentConnectionSecured = webHelper.IsCurrentConnectionSecured();
                    if (currentConnectionSecured)
                    {
                        bool startsWith3W = url.StartsWith("https://www.", StringComparison.OrdinalIgnoreCase);
                        if (!startsWith3W)
                        {
                            url = url.Replace("https://", "https://www.");
                            filterContext.Result = new RedirectResult(url);
                        }
                    }
                    else
                    {
                        bool startsWith3W = url.StartsWith("http://www.", StringComparison.OrdinalIgnoreCase);
                        if (!startsWith3W)
                        {
                            url = url.Replace("http://", "http://www.");
                            filterContext.Result = new RedirectResult(url);
                        }
                    }
                }
                    break;
                case WwwRequirement.WithoutWww:
                {
                    var webHelper = EngineContext.Current.Resolve<IWebHelper>();
                    string url = webHelper.GetThisPageUrl(true);
                    var currentConnectionSecured = webHelper.IsCurrentConnectionSecured();
                    if (currentConnectionSecured)
                    {
                        bool startsWith3W = url.StartsWith("https://www.", StringComparison.OrdinalIgnoreCase);
                        if (startsWith3W)
                        {
                            url = url.Replace("https://www.", "https://");
                            filterContext.Result = new RedirectResult(url);
                        }
                    }
                    else
                    {
                        bool startsWith3W = url.StartsWith("http://www.", StringComparison.OrdinalIgnoreCase);
                        if (startsWith3W)
                        {
                            url = url.Replace("http://www.", "http://");
                            filterContext.Result = new RedirectResult(url);
                        }
                    }
                }
                    break;
                case WwwRequirement.NoMatter:
                {
                    //do nothing
                }
                break;
                default:
                    throw new DipSkyException("Not supported WwwRequirement parameter");
            }
        }
    }
}
