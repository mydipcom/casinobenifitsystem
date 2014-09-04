using FluentValidation;
using DIPSky.Admin.Models.Polls;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Polls
{
    public class PollAnswerValidator : AbstractValidator<PollAnswerModel>
    {
        public PollAnswerValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Answers.Fields.Name.Required"));
        }
    }
}