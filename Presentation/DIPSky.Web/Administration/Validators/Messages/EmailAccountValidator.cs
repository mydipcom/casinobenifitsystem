using FluentValidation;
using DIPSky.Admin.Models.Messages;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Messages
{
    public class EmailAccountValidator : AbstractValidator<EmailAccountModel>
    {
        public EmailAccountValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
            
            RuleFor(x => x.DisplayName).NotEmpty();
        }
    }
}