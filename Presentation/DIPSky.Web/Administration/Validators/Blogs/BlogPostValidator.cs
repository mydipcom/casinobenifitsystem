using FluentValidation;
using DIPSky.Admin.Models.Blogs;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Blogs
{
    public class BlogPostValidator : AbstractValidator<BlogPostModel>
    {
        public BlogPostValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Blog.BlogPosts.Fields.Title.Required"));

            RuleFor(x => x.Body)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Blog.BlogPosts.Fields.Body.Required"));
        }
    }
}