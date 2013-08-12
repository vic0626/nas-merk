using FluentValidation;
using Nas.Admin.Models.Polls;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Polls
{
    public class PollValidator : AbstractValidator<PollModel>
    {
        public PollValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Fields.Name.Required"));
        }
    }
}