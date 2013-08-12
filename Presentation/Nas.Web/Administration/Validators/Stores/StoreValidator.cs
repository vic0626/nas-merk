using FluentValidation;
using Nas.Admin.Models.Stores;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Stores
{
    public class StoreValidator : AbstractValidator<StoreModel>
    {
        public StoreValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.Configuration.Stores.Fields.Name.Required"));
            RuleFor(x => x.Url)
                .NotNull()
                .WithMessage(localizationService.GetResource("Admin.Configuration.Stores.Fields.Url.Required"));
        }
    }
}