using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DIPSky.Core.Domain.Catalog;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Catalog
{
    public partial class AddProductVariantAttributeCombinationModel : BaseDIPSkyModel
    {
        public AddProductVariantAttributeCombinationModel()
        {
            ProductVariantAttributes = new List<ProductVariantAttributeModel>();
            Warnings = new List<string>();
        }
        
        [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.AllowOutOfStockOrders")]
        public bool AllowOutOfStockOrders { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.Sku")]
        public string Sku { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.ManufacturerPartNumber")]
        public string ManufacturerPartNumber { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.Gtin")]
        public string Gtin { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.OverriddenPrice")]
        [UIHint("DecimalNullable")]
        public decimal? OverriddenPrice { get; set; }

        public IList<ProductVariantAttributeModel> ProductVariantAttributes { get; set; }

        public IList<string> Warnings { get; set; }

        public int ProductId { get; set; }

        #region Nested classes

        public partial class ProductVariantAttributeModel : BaseDIPSkyEntityModel
        {
            public ProductVariantAttributeModel()
            {
                Values = new List<ProductVariantAttributeValueModel>();
            }

            public int ProductAttributeId { get; set; }

            public string Name { get; set; }

            public string TextPrompt { get; set; }

            public bool IsRequired { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<ProductVariantAttributeValueModel> Values { get; set; }
        }

        public partial class ProductVariantAttributeValueModel : BaseDIPSkyEntityModel
        {
            public string Name { get; set; }

            public bool IsPreSelected { get; set; }
        }
        #endregion
    }
}