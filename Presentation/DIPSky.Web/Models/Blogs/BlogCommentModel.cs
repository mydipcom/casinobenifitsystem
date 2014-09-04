﻿using System;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Blogs
{
    public partial class BlogCommentModel : BaseDIPSkyEntityModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAvatarUrl { get; set; }

        public string CommentText { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool AllowViewingProfiles { get; set; }
    }
}