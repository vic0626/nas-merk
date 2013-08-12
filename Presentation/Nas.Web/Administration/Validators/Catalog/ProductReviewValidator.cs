using FluentValidation;
using Nas.Admin.Models.Catalog;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Catalog
{
    public class ProductReviewValidator : AbstractValidator<ProductReviewModel>
    {
        public ProductReviewValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.ProductReviews.Fields.Title.Required"));
            RuleFor(x => x.ReviewText).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.ProductReviews.Fields.ReviewText.Required"));
        }}
}