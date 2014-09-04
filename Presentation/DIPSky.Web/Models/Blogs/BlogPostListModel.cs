using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Blogs
{
    public partial class BlogPostListModel : BaseDIPSkyModel
    {
        public BlogPostListModel()
        {
            PagingFilteringContext = new BlogPagingFilteringModel();
            BlogPosts = new List<BlogPostModel>();
        }

        public int WorkingLanguageId { get; set; }
        public BlogPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<BlogPostModel> BlogPosts { get; set; }
    }
}