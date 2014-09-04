using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Admin.Models.Customers;
using DIPSky.Admin.Models.Discounts;
using DIPSky.Admin.Models.Stores;
using DIPSky.Admin.Validators.Catalog;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Localization;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Catalog
{
    [Validator(typeof(ProductValidator))]
    public partial class ProductModel : BaseDIPSkyEntityModel, ILocalizedModel<ProductLocalizedModel>
    {
        public ProductModel()
        {
            Locales = new List<ProductLocalizedModel>();
            ProductPictureModels = new List<ProductPictureModel>();
            CopyProductModel = new CopyProductModel();
            AvailableProductTemplates = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            AvailableTaxCategories = new List<SelectListItem>();
            AvailableDeliveryDates = new List<SelectListItem>();
            AvailableWarehouses = new List<SelectListItem>();
            AddPictureModel = new ProductPictureModel();
            AddSpecificationAttributeModel = new AddProductSpecificationAttributeModel();
        }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ID")]
        public override int Id { get; set; }

        //picture thumbnail
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.PictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public int ProductTypeId { get; set; }
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public string ProductTypeName { get; set; }


        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AssociatedToProductName")]
        public int AssociatedToProductId { get; set; }
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AssociatedToProductName")]
        public string AssociatedToProductName { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.VisibleIndividually")]
        public bool VisibleIndividually { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ProductTemplate")]
        public int ProductTemplateId { get; set; }
        public IList<SelectListItem> AvailableProductTemplates { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ShortDescription")]
        [AllowHtml]
        public string ShortDescription { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.FullDescription")]
        [AllowHtml]
        public string FullDescription { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AdminComment")]
        [AllowHtml]
        public string AdminComment { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Vendor")]
        public int VendorId { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MetaKeywords")]
        [AllowHtml]
        public string MetaKeywords { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MetaDescription")]
        [AllowHtml]
        public string MetaDescription { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MetaTitle")]
        [AllowHtml]
        public string MetaTitle { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.SeName")]
        [AllowHtml]
        public string SeName { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AllowCustomerReviews")]
        public bool AllowCustomerReviews { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ProductTags")]
        public string ProductTags { get; set; }




        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Sku")]
        [AllowHtml]
        public string Sku { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ManufacturerPartNumber")]
        [AllowHtml]
        public string ManufacturerPartNumber { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.GTIN")]
        [AllowHtml]
        public virtual string Gtin { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.IsGiftCard")]
        public bool IsGiftCard { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.GiftCardType")]
        public int GiftCardTypeId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.RequireOtherProducts")]
        public bool RequireOtherProducts { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.RequiredProductIds")]
        public string RequiredProductIds { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AutomaticallyAddRequiredProducts")]
        public bool AutomaticallyAddRequiredProducts { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.IsDownload")]
        public bool IsDownload { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Download")]
        [UIHint("Download")]
        public int DownloadId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.UnlimitedDownloads")]
        public bool UnlimitedDownloads { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MaxNumberOfDownloads")]
        public int MaxNumberOfDownloads { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.DownloadExpirationDays")]
        public int? DownloadExpirationDays { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.DownloadActivationType")]
        public int DownloadActivationTypeId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.HasSampleDownload")]
        public bool HasSampleDownload { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.SampleDownload")]
        [UIHint("Download")]
        public int SampleDownloadId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.HasUserAgreement")]
        public bool HasUserAgreement { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.UserAgreementText")]
        [AllowHtml]
        public string UserAgreementText { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.IsRecurring")]
        public bool IsRecurring { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.RecurringCycleLength")]
        public int RecurringCycleLength { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.RecurringCyclePeriod")]
        public int RecurringCyclePeriodId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.RecurringTotalCycles")]
        public int RecurringTotalCycles { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.IsShipEnabled")]
        public bool IsShipEnabled { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.IsFreeShipping")]
        public bool IsFreeShipping { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AdditionalShippingCharge")]
        public decimal AdditionalShippingCharge { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.DeliveryDate")]
        public int DeliveryDateId { get; set; }
        public IList<SelectListItem> AvailableDeliveryDates { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Warehouse")]
        public int WarehouseId { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.IsTaxExempt")]
        public bool IsTaxExempt { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.TaxCategory")]
        public int TaxCategoryId { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ManageInventoryMethod")]
        public int ManageInventoryMethodId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.DisplayStockAvailability")]
        public bool DisplayStockAvailability { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.DisplayStockQuantity")]
        public bool DisplayStockQuantity { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MinStockQuantity")]
        public int MinStockQuantity { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.LowStockActivity")]
        public int LowStockActivityId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.NotifyAdminForQuantityBelow")]
        public int NotifyAdminForQuantityBelow { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.BackorderMode")]
        public int BackorderModeId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AllowBackInStockSubscriptions")]
        public bool AllowBackInStockSubscriptions { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.OrderMinimumQuantity")]
        public int OrderMinimumQuantity { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.OrderMaximumQuantity")]
        public int OrderMaximumQuantity { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AllowedQuantities")]
        public string AllowedQuantities { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.DisableBuyButton")]
        public bool DisableBuyButton { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.DisableWishlistButton")]
        public bool DisableWishlistButton { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AvailableForPreOrder")]
        public bool AvailableForPreOrder { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.PreOrderAvailabilityStartDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? PreOrderAvailabilityStartDateTimeUtc { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.CallForPrice")]
        public bool CallForPrice { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Price")]
        public decimal Price { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.OldPrice")]
        public decimal OldPrice { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ProductCost")]
        public decimal ProductCost { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.SpecialPrice")]
        [UIHint("DecimalNullable")]
        public decimal? SpecialPrice { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.SpecialPriceStartDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? SpecialPriceStartDateTimeUtc { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.SpecialPriceEndDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? SpecialPriceEndDateTimeUtc { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.CustomerEntersPrice")]
        public bool CustomerEntersPrice { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MinimumCustomerEnteredPrice")]
        public decimal MinimumCustomerEnteredPrice { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MaximumCustomerEnteredPrice")]
        public decimal MaximumCustomerEnteredPrice { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Weight")]
        public decimal Weight { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Length")]
        public decimal Length { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Width")]
        public decimal Width { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Height")]
        public decimal Height { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AvailableStartDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? AvailableStartDateTimeUtc { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AvailableEndDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? AvailableEndDateTimeUtc { get; set; }


        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Published")]
        public bool Published { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.CreatedOn")]
        public DateTime? CreatedOn { get; set; }
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.UpdatedOn")]
        public DateTime? UpdatedOn { get; set; }


        public string PrimaryStoreCurrencyCode { get; set; }
        public string BaseDimensionIn { get; set; }
        public string BaseWeightIn { get; set; }

        public IList<ProductLocalizedModel> Locales { get; set; }


        //ACL (customer roles)
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public int[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public int[] SelectedStoreIds { get; set; }


        //vendor
        public bool IsLoggedInAsVendor { get; set; }



        //categories
        public int NumberOfAvailableCategories { get; set; }

        //manufacturers
        public int NumberOfAvailableManufacturers { get; set; }


        //product attributes
        public int NumberOfAvailableProductAttributes { get; set; }
        


        //pictures
        public ProductPictureModel AddPictureModel { get; set; }
        public IList<ProductPictureModel> ProductPictureModels { get; set; }

        //discounts
        public List<DiscountModel> AvailableDiscounts { get; set; }
        public int[] SelectedDiscountIds { get; set; }




        //add specification attribute model
        public AddProductSpecificationAttributeModel AddSpecificationAttributeModel { get; set; }



        //copy product
        public CopyProductModel CopyProductModel { get; set; }
        
        #region Nested classes
        
        public partial class AddProductSpecificationAttributeModel : BaseDIPSkyModel
        {
            public AddProductSpecificationAttributeModel()
            {
                AvailableAttributes = new List<SelectListItem>();
                AvailableOptions = new List<SelectListItem>();
            }
            
            [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttribute")]
            public int SpecificationAttributeId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttributeOption")]
            public int SpecificationAttributeOptionId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
            public string CustomValue { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AllowFiltering")]
            public bool AllowFiltering { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.ShowOnProductPage")]
            public bool ShowOnProductPage { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }

            public IList<SelectListItem> AvailableAttributes { get; set; }
            public IList<SelectListItem> AvailableOptions { get; set; }
        }
        
        public partial class ProductPictureModel : BaseDIPSkyEntityModel
        {
            public int ProductId { get; set; }

            [UIHint("Picture")]
            [DipSkyResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.Picture")]
            public int PictureId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.Picture")]
            public string PictureUrl { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }
        
        public partial class ProductCategoryModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("Admin.Catalog.Products.Categories.Fields.Category")]
            [UIHint("ProductCategory")]
            public string Category { get; set; }

            public int ProductId { get; set; }

            public int CategoryId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.Categories.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.Categories.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class ProductManufacturerModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("Admin.Catalog.Products.Manufacturers.Fields.Manufacturer")]
            [UIHint("ProductManufacturer")]
            public string Manufacturer { get; set; }

            public int ProductId { get; set; }

            public int ManufacturerId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.Manufacturers.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.Manufacturers.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class RelatedProductModel : BaseDIPSkyEntityModel
        {
            public int ProductId2 { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.RelatedProducts.Fields.Product")]
            public string Product2Name { get; set; }
            
            [DipSkyResourceDisplayName("Admin.Catalog.Products.RelatedProducts.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }
        public partial class AddRelatedProductModel : BaseDIPSkyModel
        {
            public AddRelatedProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
            [AllowHtml]
            public string SearchProductName { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public int SearchCategoryId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public int SearchManufacturerId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public int SearchStoreId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public int SearchVendorId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int ProductId { get; set; }

            public int[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class AssociatedProductModel : BaseDIPSkyEntityModel
        {
            [DipSkyResourceDisplayName("Admin.Catalog.Products.AssociatedProducts.Fields.Product")]
            public string ProductName { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.AssociatedProducts.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }
        public partial class AddAssociatedProductModel : BaseDIPSkyModel
        {
            public AddAssociatedProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
            [AllowHtml]
            public string SearchProductName { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public int SearchCategoryId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public int SearchManufacturerId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public int SearchStoreId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public int SearchVendorId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int ProductId { get; set; }

            public int[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class CrossSellProductModel : BaseDIPSkyEntityModel
        {
            public int ProductId2 { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.CrossSells.Fields.Product")]
            public string Product2Name { get; set; }
        }
        public partial class AddCrossSellProductModel : BaseDIPSkyModel
        {
            public AddCrossSellProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
            [AllowHtml]
            public string SearchProductName { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public int SearchCategoryId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public int SearchManufacturerId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public int SearchStoreId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public int SearchVendorId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public int ProductId { get; set; }

            public int[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class TierPriceModel : BaseDIPSkyEntityModel
        {
            public int ProductId { get; set; }

            public int CustomerRoleId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.CustomerRole")]
            [UIHint("TierPriceCustomer")]
            public string CustomerRole { get; set; }


            public int StoreId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Store")]
            [UIHint("TierPriceStore")]
            public string Store { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Quantity")]
            public int Quantity { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Price")]
            //we don't name it Price because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's productVariant.Price1
            public decimal Price1 { get; set; }
        }

        public partial class ProductVariantAttributeModel : BaseDIPSkyEntityModel
        {
            public int ProductId { get; set; }

            public int ProductAttributeId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Fields.Attribute")]
            [UIHint("ProductAttribute")]
            public string ProductAttribute { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Fields.TextPrompt")]
            [AllowHtml]
            public string TextPrompt { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Fields.IsRequired")]
            public bool IsRequired { get; set; }

            public int AttributeControlTypeId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Fields.AttributeControlType")]
            [UIHint("AttributeControlType")]
            public string AttributeControlType { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Fields.DisplayOrder")]
            //we don't name it DisplayOrder because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's category.DisplayOrder
            public int DisplayOrder1 { get; set; }

            public string ViewEditUrl { get; set; }
            public string ViewEditText { get; set; }
        }
        public partial class ProductVariantAttributeValueListModel : BaseDIPSkyModel
        {
            public int ProductId { get; set; }

            public string ProductName { get; set; }

            public int ProductVariantAttributeId { get; set; }

            public string ProductVariantAttributeName { get; set; }
        }
        [Validator(typeof(ProductVariantAttributeValueModelValidator))]
        public partial class ProductVariantAttributeValueModel : BaseDIPSkyEntityModel, ILocalizedModel<ProductVariantAttributeValueLocalizedModel>
        {
            public ProductVariantAttributeValueModel()
            {
                ProductPictureModels = new List<ProductPictureModel>();
                Locales = new List<ProductVariantAttributeValueLocalizedModel>();
            }

            public int ProductVariantAttributeId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.AttributeValueType")]
            public int AttributeValueTypeId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.AttributeValueType")]
            public string AttributeValueTypeName { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.AssociatedProduct")]
            public int AssociatedProductId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.AssociatedProduct")]
            public string AssociatedProductName { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Name")]
            [AllowHtml]
            public string Name { get; set; }
            
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.ColorSquaresRgb")]
            [AllowHtml]
            public string ColorSquaresRgb { get; set; }
            public bool DisplayColorSquaresRgb { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.PriceAdjustment")]
            public decimal PriceAdjustment { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.PriceAdjustment")]
            //used only on the values list page
            public string PriceAdjustmentStr { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.WeightAdjustment")]
            public decimal WeightAdjustment { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.WeightAdjustment")]
            //used only on the values list page
            public string WeightAdjustmentStr { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Cost")]
            public decimal Cost { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Quantity")]
            public int Quantity { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.IsPreSelected")]
            public bool IsPreSelected { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Picture")]
            public int PictureId { get; set; }
            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Picture")]
            public string PictureThumbnailUrl { get; set; }

            public IList<ProductPictureModel> ProductPictureModels { get; set; }
            public IList<ProductVariantAttributeValueLocalizedModel> Locales { get; set; }

            #region Nested classes

            public partial class AssociateProductToAttributeValueModel : BaseDIPSkyModel
            {
                public AssociateProductToAttributeValueModel()
                {
                    AvailableCategories = new List<SelectListItem>();
                    AvailableManufacturers = new List<SelectListItem>();
                    AvailableStores = new List<SelectListItem>();
                    AvailableVendors = new List<SelectListItem>();
                    AvailableProductTypes = new List<SelectListItem>();
                }

                [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
                [AllowHtml]
                public string SearchProductName { get; set; }
                [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
                public int SearchCategoryId { get; set; }
                [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
                public int SearchManufacturerId { get; set; }
                [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
                public int SearchStoreId { get; set; }
                [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
                public int SearchVendorId { get; set; }
                [DipSkyResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
                public int SearchProductTypeId { get; set; }

                public IList<SelectListItem> AvailableCategories { get; set; }
                public IList<SelectListItem> AvailableManufacturers { get; set; }
                public IList<SelectListItem> AvailableStores { get; set; }
                public IList<SelectListItem> AvailableVendors { get; set; }
                public IList<SelectListItem> AvailableProductTypes { get; set; }
                
                //vendor
                public bool IsLoggedInAsVendor { get; set; }


                public int AssociatedToProductId { get; set; }
            }
            #endregion
        }
        public partial class ProductVariantAttributeValueLocalizedModel : ILocalizedModelLocal
        {
            public int LanguageId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Name")]
            [AllowHtml]
            public string Name { get; set; }
        }
        public partial class ProductVariantAttributeCombinationModel : BaseDIPSkyEntityModel
        {
            public int ProductId { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.Attributes")]
            [AllowHtml]
            public string AttributesXml { get; set; }

            [AllowHtml]
            public string Warnings { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.StockQuantity")]
            //we don't name it StockQuantity because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's productVariant.StockQuantity1
            public int StockQuantity1 { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.AllowOutOfStockOrders")]
            //we don't name it AllowOutOfStockOrders because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's productVariant.AllowOutOfStockOrders1
            public bool AllowOutOfStockOrders1 { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.Sku")]
            //we don't name it StockQuantity because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's productVariant.Sku1
            public string Sku1 { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.ManufacturerPartNumber")]
            //we don't name it StockQuantity because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's productVariant.ManufacturerPartNumber1
            public string ManufacturerPartNumber1 { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.Gtin")]
            //we don't name it StockQuantity because Telerik has a small bug 
            //"if we have one more editor with the same name on a page, it doesn't allow editing"
            //in our case it's productVariant.Gtin1
            public string Gtin1 { get; set; }

            [DipSkyResourceDisplayName("Admin.Catalog.Products.ProductVariantAttributes.AttributeCombinations.Fields.OverriddenPrice")]
            [UIHint("DecimalNullable")]
            public decimal? OverriddenPrice { get; set; }
        }

        #endregion
    }

    public partial class ProductLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.ShortDescription")]
        [AllowHtml]
        public string ShortDescription { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.FullDescription")]
        [AllowHtml]
        public string FullDescription { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MetaKeywords")]
        [AllowHtml]
        public string MetaKeywords { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MetaDescription")]
        [AllowHtml]
        public string MetaDescription { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.MetaTitle")]
        [AllowHtml]
        public string MetaTitle { get; set; }

        [DipSkyResourceDisplayName("Admin.Catalog.Products.Fields.SeName")]
        [AllowHtml]
        public string SeName { get; set; }
    }
}