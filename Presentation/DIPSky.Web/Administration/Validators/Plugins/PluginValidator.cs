using FluentValidation;
using DIPSky.Admin.Models.Plugins;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Plugins
{
    public class PluginValidator : AbstractValidator<PluginModel>
    {
        public PluginValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.FriendlyName).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Plugins.Fields.FriendlyName.Required"));
        }
    }
}