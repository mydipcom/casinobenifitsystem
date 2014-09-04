using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using DIPSky.Core.Domain.Customers;
using DIPSky.Services.Localization;
using DIPSky.Web.Models.Customer;
using FluentValidation;

namespace DIPSky.Web.Validators.Customer
{
    public class LoginValidator : AbstractValidator<LoginModel>
    {
        public LoginValidator(ILocalizationService localizationService, CustomerSettings customerSettings)
        {
            if (customerSettings.UsernamesEnabled)
            {
                RuleFor(x => x.Username)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Account.Fields.Username.Required"));
              /*  RuleFor(x => x.Username)
                    .Matches(@"\d{8}", RegexOptions.IgnoreCase)
                    .WithMessage(localizationService.GetResource("Common.WrongUsername"));*/
            }
            else
            {
                RuleFor(x => x.Email)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Account.Fields.Email.Required"));
                RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            }

        }
    }
}