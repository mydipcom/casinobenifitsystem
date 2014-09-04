using FluentValidation;
using DIPSky.Admin.Models.Catalog;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Catalog
{
    public class ProductValidator : AbstractValidator<ProductModel>
    {
        public ProductValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Products.Fields.Name.Required"));
        }
    }
}