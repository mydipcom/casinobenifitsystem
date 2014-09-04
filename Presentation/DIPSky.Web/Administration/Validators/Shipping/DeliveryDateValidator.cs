using FluentValidation;
using DIPSky.Admin.Models.Shipping;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Shipping
{
    public class DeliveryDateValidator : AbstractValidator<DeliveryDateModel>
    {
        public DeliveryDateValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.DeliveryDates.Fields.Name.Required"));
        }
    }
}