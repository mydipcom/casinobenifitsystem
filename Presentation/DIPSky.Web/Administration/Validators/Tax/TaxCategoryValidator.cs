using FluentValidation;
using DIPSky.Admin.Models.Tax;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Tax
{
    public class TaxCategoryValidator : AbstractValidator<TaxCategoryModel>
    {
        public TaxCategoryValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Tax.Categories.Fields.Name.Required"));
        }
    }
}