using FluentValidation;
using Nas.Admin.Models.Orders;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Orders
{
    public class RecurringPaymentValidator : AbstractValidator<RecurringPaymentModel>
    {
        public RecurringPaymentValidator(ILocalizationService localizationService)
        {
        }
    }
}