using System.Collections.Generic;
using DIPSky.Web.Models.Common;

namespace DIPSky.Web.Models.Profile
{
    public partial class ProfilePostsModel
    {
        public IList<PostsModel> Posts { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}