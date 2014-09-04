using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Catalog
{
    public partial class ProductSpecificationAttributeModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttribute")]
        [AllowHtml]
        public string SpecificationAttributeName { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttributeOption")]
        [AllowHtml]
        public string SpecificationAttributeOptionName { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
        [AllowHtml]
        public string CustomValue { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AllowFiltering")]
        public bool AllowFiltering { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.ShowOnProductPage")]
        public bool ShowOnProductPage { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}