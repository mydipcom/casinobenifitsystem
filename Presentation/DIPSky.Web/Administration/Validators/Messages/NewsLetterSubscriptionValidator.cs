using FluentValidation;
using DIPSky.Admin.Models.Messages;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Messages
{
    public class NewsLetterSubscriptionValidator : AbstractValidator<NewsLetterSubscriptionModel>
    {
        public NewsLetterSubscriptionValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.NewsLetterSubscriptions.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
        }
    }
}