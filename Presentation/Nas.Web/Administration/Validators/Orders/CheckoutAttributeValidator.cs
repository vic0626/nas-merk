using FluentValidation;
using Nas.Admin.Models.Orders;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Orders
{
    public class CheckoutAttributeValidator : AbstractValidator<CheckoutAttributeModel>
    {
        public CheckoutAttributeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotNull().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.CheckoutAttributes.Fields.Name.Required"));
        }
    }
}