using FluentValidation;
using Nas.Admin.Models.Shipping;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Shipping
{
    public class ShippingMethodValidator : AbstractValidator<ShippingMethodModel>
    {
        public ShippingMethodValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotNull().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Methods.Fields.Name.Required"));
        }
    }
}