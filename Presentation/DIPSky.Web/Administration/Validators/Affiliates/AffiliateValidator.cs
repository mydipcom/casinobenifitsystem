using FluentValidation;
using DIPSky.Admin.Models.Affiliates;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Affiliates
{
    public class AffiliateValidator : AbstractValidator<AffiliateModel>
    {
        public AffiliateValidator(ILocalizationService localizationService)
        {
        }
    }
}