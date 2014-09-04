using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Feed.Froogle.Models
{
    public class FeedFroogleModel
    {
        public FeedFroogleModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableCurrencies = new List<SelectListItem>();
            AvailableGoogleCategories = new List<SelectListItem>();
            GeneratedFiles = new List<GeneratedFileModel>();
        }

        [DipSkyResourceDisplayName("Plugins.Feed.Froogle.ProductPictureSize")]
        public int ProductPictureSize { get; set; }

        [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Store")]
        public int StoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Currency")]
        public int CurrencyId { get; set; }
        public IList<SelectListItem> AvailableCurrencies { get; set; }

        [DipSkyResourceDisplayName("Plugins.Feed.Froogle.DefaultGoogleCategory")]
        public string DefaultGoogleCategory { get; set; }
        public IList<SelectListItem> AvailableGoogleCategories { get; set; }

        public string GenerateFeedResult { get; set; }

        [DipSkyResourceDisplayName("Plugins.Feed.Froogle.StaticFilePath")]
        public IList<GeneratedFileModel> GeneratedFiles { get; set; }
        
        public class GeneratedFileModel : BaseDIPSkyModel
        {
            public string StoreName { get; set; }
            public string FileUrl { get; set; }
        }

        public class GoogleProductModel : BaseDIPSkyModel
        {
            //this attribute is required to disable editing
            [ScaffoldColumn(false)]
            public int ProductId { get; set; }

            //this attribute is required to disable editing
            [ReadOnly(true)]
            [ScaffoldColumn(false)]
            [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Products.ProductName")]
            public string ProductName { get; set; }

            [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Products.GoogleCategory")]
            public string GoogleCategory { get; set; }

            [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Products.Gender")]
            public string Gender { get; set; }

            [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Products.AgeGroup")]
            public string AgeGroup { get; set; }

            [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Products.Color")]
            public string Color { get; set; }

            [DipSkyResourceDisplayName("Plugins.Feed.Froogle.Products.Size")]
            public string GoogleSize { get; set; }
        }
    }
}