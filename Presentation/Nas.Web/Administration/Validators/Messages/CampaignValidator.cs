using FluentValidation;
using Nas.Admin.Models.Messages;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Messages
{
    public class CampaignValidator : AbstractValidator<CampaignModel>
    {
        public CampaignValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.Promotions.Campaigns.Fields.Name.Required"));

            RuleFor(x => x.Subject)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.Promotions.Campaigns.Fields.Subject.Required"));

            RuleFor(x => x.Body)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.Promotions.Campaigns.Fields.Body.Required"));
        }
    }
}