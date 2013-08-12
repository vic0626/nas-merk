using FluentValidation;
using Nas.Admin.Models.Catalog;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Catalog
{
    public class CategoryValidator : AbstractValidator<CategoryModel>
    {
        public CategoryValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotNull().WithMessage(localizationService.GetResource("Admin.Catalog.Categories.Fields.Name.Required"));
        }
    }
}