using FluentValidation;
using Nas.Admin.Models.Discounts;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Discounts
{
    public class DiscountValidator : AbstractValidator<DiscountModel>
    {
        public DiscountValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.Promotions.Discounts.Fields.Name.Required"));
        }
    }
}