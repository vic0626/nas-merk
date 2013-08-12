using FluentValidation;
using Nas.Admin.Models.Catalog;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Catalog
{
    public class ProductAttributeValidator : AbstractValidator<ProductAttributeModel>
    {
        public ProductAttributeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotNull().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.ProductAttributes.Fields.Name.Required"));
        }
    }
}