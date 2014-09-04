using System.Collections.Generic;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Topics
{
    public partial class TopicListModel : BaseDIPSkyModel
    {
        public TopicListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [DipSkyResourceDisplayName("Admin.ContentManagement.Topics.List.SearchStore")]
        public int SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}