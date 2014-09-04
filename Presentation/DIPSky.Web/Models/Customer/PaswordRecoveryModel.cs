using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;
using DIPSky.Web.Validators.Customer;

namespace DIPSky.Web.Models.Customer
{
    [Validator(typeof(PasswordRecoveryValidator))]
    public partial class PasswordRecoveryModel : BaseDIPSkyModel
    {
        [AllowHtml]
        [DipSkyResourceDisplayName("Account.PasswordRecovery.Email")]
        public string Email { get; set; }

        public string Result { get; set; }
    }
}