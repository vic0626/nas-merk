﻿using FluentValidation;
using Nas.Admin.Models.Plugins;
using Nas.Services.Localization;

namespace Nas.Admin.Validators.Plugins
{
    public class PluginValidator : AbstractValidator<PluginModel>
    {
        public PluginValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.FriendlyName).NotNull().WithMessage(localizationService.GetResource("Admin.Configuration.Plugins.Fields.FriendlyName.Required"));
        }
    }
}