using FluentValidation;
using DIPSky.Admin.Models.Orders;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Orders
{
    public class CheckoutAttributeValidator : AbstractValidator<CheckoutAttributeModel>
    {
        public CheckoutAttributeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.CheckoutAttributes.Fields.Name.Required"));
        }
    }
}