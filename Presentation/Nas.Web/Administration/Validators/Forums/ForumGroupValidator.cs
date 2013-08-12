using FluentValidation;
using Nas.Admin.Models.Forums;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Forums
{
    public class ForumGroupValidator : AbstractValidator<ForumGroupModel>
    {
        public ForumGroupValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotNull().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.ForumGroup.Fields.Name.Required"));
        }
    }
}