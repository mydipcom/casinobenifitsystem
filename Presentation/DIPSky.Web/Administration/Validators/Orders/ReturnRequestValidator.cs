using FluentValidation;
using DIPSky.Admin.Models.Orders;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Orders
{
    public class ReturnRequestValidator : AbstractValidator<ReturnRequestModel>
    {
        public ReturnRequestValidator(ILocalizationService localizationService)
        {
        }
    }
}