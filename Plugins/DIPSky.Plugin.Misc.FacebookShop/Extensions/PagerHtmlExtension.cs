using System.Web.Mvc;
using DIPSky.Web.Framework.UI.Paging;

namespace DIPSky.Plugin.Misc.FacebookShop.Extensions
{
    public static class PagerHtmlExtension
    {
        //jsut a copy of \Presentation\DIPSky.Web\Extensions\PagerHtmlExtension.cs
        public static Pager Pager(this HtmlHelper helper, IPageableModel pagination)
        {
            return new Pager(pagination, helper.ViewContext);
        }
    }
}
