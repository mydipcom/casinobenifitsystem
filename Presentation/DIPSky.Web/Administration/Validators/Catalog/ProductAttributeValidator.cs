using FluentValidation;
using DIPSky.Admin.Models.Catalog;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Catalog
{
    public class ProductAttributeValidator : AbstractValidator<ProductAttributeModel>
    {
        public ProductAttributeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.ProductAttributes.Fields.Name.Required"));
        }
    }
}