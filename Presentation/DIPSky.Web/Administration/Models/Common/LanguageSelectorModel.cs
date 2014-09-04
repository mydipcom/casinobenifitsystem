using System.Collections.Generic;
using DIPSky.Admin.Models.Localization;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Common
{
    public partial class LanguageSelectorModel : BaseDIPSkyModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public LanguageModel CurrentLanguage { get; set; }
    }
}