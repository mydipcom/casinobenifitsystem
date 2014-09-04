using FluentValidation;
using DIPSky.Admin.Models.Shipping;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Shipping
{
    public class ShippingMethodValidator : AbstractValidator<ShippingMethodModel>
    {
        public ShippingMethodValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Methods.Fields.Name.Required"));
        }
    }
}