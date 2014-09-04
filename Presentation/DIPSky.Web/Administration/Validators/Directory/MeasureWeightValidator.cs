using FluentValidation;
using DIPSky.Admin.Models.Directory;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Directory
{
    public class MeasureWeightValidator : AbstractValidator<MeasureWeightModel>
    {
        public MeasureWeightValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Weights.Fields.Name.Required"));
            RuleFor(x => x.SystemKeyword).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Weights.Fields.SystemKeyword.Required"));
        }
    }
}