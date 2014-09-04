using System;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.News
{
    public partial class NewsCommentModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.NewsItem")]
        public int NewsItemId { get; set; }
        [DipSkyResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.NewsItem")]
        [AllowHtml]
        public string NewsItemTitle { get; set; }

        [DipSkyResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.Customer")]
        public int CustomerId { get; set; }
        [DipSkyResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.Customer")]
        public string CustomerInfo { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CommentTitle")]
        public string CommentTitle { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CommentText")]
        public string CommentText { get; set; }

        [DipSkyResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

    }
}