using FluentValidation;
using Nas.Admin.Models.Tax;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Tax
{
    public class TaxCategoryValidator : AbstractValidator<TaxCategoryModel>
    {
        public TaxCategoryValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotNull().WithMessage(localizationService.GetResource("Admin.Configuration.Tax.Categories.Fields.Name.Required"));
        }
    }
}