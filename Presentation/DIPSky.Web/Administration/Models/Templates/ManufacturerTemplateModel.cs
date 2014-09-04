using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Admin.Validators.Templates;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Templates
{
    [Validator(typeof(ManufacturerTemplateValidator))]
    public partial class ManufacturerTemplateModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.System.Templates.Manufacturer.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.System.Templates.Manufacturer.ViewPath")]
        [AllowHtml]
        public string ViewPath { get; set; }

        [DipSkyResourceDisplayName("Admin.System.Templates.Manufacturer.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}