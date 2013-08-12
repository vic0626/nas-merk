using FluentValidation;
using Nas.Admin.Models.Affiliates;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Affiliates
{
    public class AffiliateValidator : AbstractValidator<AffiliateModel>
    {
        public AffiliateValidator(ILocalizationService localizationService)
        {
        }
    }
}