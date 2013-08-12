using FluentValidation;
using Nas.Admin.Models.Polls;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Polls
{
    public class PollAnswerValidator : AbstractValidator<PollAnswerModel>
    {
        public PollAnswerValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Answers.Fields.Name.Required"));
        }
    }
}