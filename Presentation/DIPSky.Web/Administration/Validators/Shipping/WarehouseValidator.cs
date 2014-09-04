using FluentValidation;
using DIPSky.Admin.Models.Shipping;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Shipping
{
    public class WarehouseValidator : AbstractValidator<WarehouseModel>
    {
        public WarehouseValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Warehouses.Fields.Name.Required"));
        }
    }
}