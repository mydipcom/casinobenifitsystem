using FluentValidation;
using DIPSky.Admin.Models.Vendors;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Vendors
{
    public class VendorValidator : AbstractValidator<VendorModel>
    {
        public VendorValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Name.Required"));

            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
        }
    }
}