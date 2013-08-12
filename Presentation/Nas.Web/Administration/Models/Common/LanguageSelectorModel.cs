using System.Collections.Generic;
using Nas.Admin.Models.Localization;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Common
{
    public partial class LanguageSelectorModel : BaseNasModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public LanguageModel CurrentLanguage { get; set; }
    }
}