using System;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.News
{
    public partial class NewsCommentModel : BaseDIPSkyEntityModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAvatarUrl { get; set; }

        public string CommentTitle { get; set; }

        public string CommentText { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool AllowViewingProfiles { get; set; }
    }
}