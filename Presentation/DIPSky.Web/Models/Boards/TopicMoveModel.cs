using System.Collections.Generic;
using System.Web.Mvc;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Boards
{
    public partial class TopicMoveModel : BaseDIPSkyEntityModel
    {
        public TopicMoveModel()
        {
            ForumList = new List<SelectListItem>();
        }

        public int ForumSelected { get; set; }
        public string TopicSeName { get; set; }

        public IEnumerable<SelectListItem> ForumList { get; set; }
    }
}