using FluentValidation;
using DIPSky.Admin.Models.Customers;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Customers
{
    public class CustomerRoleValidator : AbstractValidator<CustomerRoleModel>
    {
        public CustomerRoleValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Customers.CustomerRoles.Fields.Name.Required"));
        }
    }
}