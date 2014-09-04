using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Blogs
{
    public partial class BlogPostYearModel : BaseDIPSkyModel
    {
        public BlogPostYearModel()
        {
            Months = new List<BlogPostMonthModel>();
        }
        public int Year { get; set; }
        public IList<BlogPostMonthModel> Months { get; set; }
    }
    public partial class BlogPostMonthModel : BaseDIPSkyModel
    {
        public int Month { get; set; }

        public int BlogPostCount { get; set; }
    }
}