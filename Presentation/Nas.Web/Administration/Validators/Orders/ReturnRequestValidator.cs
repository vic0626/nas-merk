using FluentValidation;
using Nas.Admin.Models.Orders;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Orders
{
    public class ReturnRequestValidator : AbstractValidator<ReturnRequestModel>
    {
        public ReturnRequestValidator(ILocalizationService localizationService)
        {
        }
    }
}