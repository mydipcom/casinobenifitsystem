using FluentValidation;
using DIPSky.Admin.Models.Polls;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Polls
{
    public class PollValidator : AbstractValidator<PollModel>
    {
        public PollValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Fields.Name.Required"));
        }
    }
}