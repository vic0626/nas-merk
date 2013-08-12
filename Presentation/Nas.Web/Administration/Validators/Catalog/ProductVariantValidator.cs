using FluentValidation;
using Nas.Admin.Models.Catalog;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Catalog
{
    public class ProductVariantValidator : AbstractValidator<ProductVariantModel>
    {
        public ProductVariantValidator(ILocalizationService localizationService)
        {
        }
    }
}