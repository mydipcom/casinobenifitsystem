using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Blogs
{
    public partial class BlogPostTagModel : BaseDIPSkyModel
    {
        public string Name { get; set; }

        public int BlogPostCount { get; set; }
    }
}