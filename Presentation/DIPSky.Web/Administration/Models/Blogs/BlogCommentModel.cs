using System;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Blogs
{
    public partial class BlogCommentModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.BlogPost")]
        public int BlogPostId { get; set; }
        [DipSkyResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.BlogPost")]
        [AllowHtml]
        public string BlogPostTitle { get; set; }

        [DipSkyResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Customer")]
        public int CustomerId { get; set; }
        [DipSkyResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Customer")]
        public string CustomerInfo { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Comment")]
        public string Comment { get; set; }

        [DipSkyResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

    }
}