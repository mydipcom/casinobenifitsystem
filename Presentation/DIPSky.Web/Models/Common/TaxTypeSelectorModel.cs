using DIPSky.Core.Domain.Tax;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Common
{
    public partial class TaxTypeSelectorModel : BaseDIPSkyModel
    {
        public bool Enabled { get; set; }

        public TaxDisplayType CurrentTaxType { get; set; }
    }
}