using FluentValidation;
using DIPSky.Admin.Models.Catalog;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Catalog
{
    public class SpecificationAttributeOptionValidator : AbstractValidator<SpecificationAttributeOptionModel>
    {
        public SpecificationAttributeOptionValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.SpecificationAttributes.Options.Fields.Name.Required"));
        }
    }
}