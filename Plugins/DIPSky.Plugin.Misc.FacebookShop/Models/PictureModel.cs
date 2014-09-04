﻿using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Misc.FacebookShop.Models
{
    public partial class PictureModel : BaseDIPSkyModel
    {
        public string ImageUrl { get; set; }

        public string FullSizeImageUrl { get; set; }

        public string Title { get; set; }

        public string AlternateText { get; set; }
    }
}