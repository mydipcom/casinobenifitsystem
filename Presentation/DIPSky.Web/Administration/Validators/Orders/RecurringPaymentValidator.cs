using FluentValidation;
using DIPSky.Admin.Models.Orders;
using DIPSky.Services.Localization;

namespace DIPSky.Admin.Validators.Orders
{
    public class RecurringPaymentValidator : AbstractValidator<RecurringPaymentModel>
    {
        public RecurringPaymentValidator(ILocalizationService localizationService)
        {
        }
    }
}