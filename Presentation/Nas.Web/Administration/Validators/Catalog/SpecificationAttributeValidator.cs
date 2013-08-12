using FluentValidation;
using Nas.Admin.Models.Catalog;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Catalog
{
    public class SpecificationAttributeValidator : AbstractValidator<SpecificationAttributeModel>
    {
        public SpecificationAttributeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotNull().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.SpecificationAttributes.Fields.Name.Required"));
        }
    }
}