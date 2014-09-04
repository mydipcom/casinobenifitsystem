using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Admin.Validators.Templates;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Templates
{
    [Validator(typeof(CategoryTemplateValidator))]
    public partial class CategoryTemplateModel : BaseDIPSkyEntityModel
    {
        [DipSkyResourceDisplayName("Admin.System.Templates.Category.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.System.Templates.Category.ViewPath")]
        [AllowHtml]
        public string ViewPath { get; set; }

        [DipSkyResourceDisplayName("Admin.System.Templates.Category.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}