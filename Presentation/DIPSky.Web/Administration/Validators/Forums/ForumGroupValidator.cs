using FluentValidation;
using DIPSky.Admin.Models.Forums;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Forums
{
    public class ForumGroupValidator : AbstractValidator<ForumGroupModel>
    {
        public ForumGroupValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.ForumGroup.Fields.Name.Required"));
        }
    }
}