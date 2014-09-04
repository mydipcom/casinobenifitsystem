using FluentValidation;
using DIPSky.Admin.Models.Catalog;
using DIPSky.Core.Domain.Catalog;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Catalog
{
    public class ProductVariantAttributeValueModelValidator : AbstractValidator<ProductModel.ProductVariantAttributeValueModel>
    {
        public ProductVariantAttributeValueModelValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Name.Required"));

            RuleFor(x => x.Quantity)
                .GreaterThanOrEqualTo(1)
                .WithMessage(localizationService.GetResource("Admin.Catalog.Products.ProductVariantAttributes.Attributes.Values.Fields.Quantity.GreaterThanOrEqualTo1"))
                .When(x => x.AttributeValueTypeId == (int)AttributeValueType.AssociatedToProduct);
        }
    }
}