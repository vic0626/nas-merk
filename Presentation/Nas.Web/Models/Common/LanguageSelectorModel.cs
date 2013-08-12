﻿using System.Collections.Generic;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class LanguageSelectorModel : BaseNasModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public int CurrentLanguageId { get; set; }

        public bool UseImages { get; set; }
    }
}