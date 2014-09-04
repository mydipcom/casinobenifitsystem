using FluentValidation;
using DIPSky.Admin.Models.Orders;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Orders
{
    public class CheckoutAttributeValueValidator : AbstractValidator<CheckoutAttributeValueModel>
    {
        public CheckoutAttributeValueValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.CheckoutAttributes.Values.Fields.Name.Required"));
        }
    }
}