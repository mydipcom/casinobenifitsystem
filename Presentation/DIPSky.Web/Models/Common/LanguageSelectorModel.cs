﻿using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Common
{
    public partial class LanguageSelectorModel : BaseDIPSkyModel
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