using FluentValidation;
using Nas.Admin.Models.Topics;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Topics
{
    public class TopicValidator : AbstractValidator<TopicModel>
    {
        public TopicValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.SystemName).NotNull().WithMessage(localizationService.GetResource("Admin.ContentManagement.Topics.Fields.SystemName.Required"));
        }
    }
}