using FluentValidation;
using DIPSky.Admin.Models.Discounts;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Discounts
{
    public class DiscountValidator : AbstractValidator<DiscountModel>
    {
        public DiscountValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.Discounts.Fields.Name.Required"));
        }
    }
}