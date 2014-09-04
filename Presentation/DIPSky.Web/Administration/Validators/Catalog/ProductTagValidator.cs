using FluentValidation;
using DIPSky.Admin.Models.Catalog;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Catalog
{
    public class ProductTagValidator : AbstractValidator<ProductTagModel>
    {
        public ProductTagValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.ProductTags.Fields.Name.Required"));
        }
    }
}