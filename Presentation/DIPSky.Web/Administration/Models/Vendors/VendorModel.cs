using System.Collections.Generic;
using FluentValidation.Attributes;
using DIPSky.Admin.Validators.Vendors;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Vendors
{
    [Validator(typeof(VendorValidator))]
    public partial class VendorModel : BaseDIPSkyEntityModel
    {
        public VendorModel()
        {
            AssociatedCustomerEmails = new List<string>();
        }

        [DipSkyResourceDisplayName("Admin.Vendors.Fields.Name")]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.Vendors.Fields.Email")]
        public string Email { get; set; }

        [DipSkyResourceDisplayName("Admin.Vendors.Fields.Description")]
        public string Description { get; set; }

        [DipSkyResourceDisplayName("Admin.Vendors.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [DipSkyResourceDisplayName("Admin.Vendors.Fields.Active")]
        public bool Active { get; set; }

        [DipSkyResourceDisplayName("Admin.Vendors.Fields.AssociatedCustomerEmails")]
        public IList<string> AssociatedCustomerEmails { get; set; }
    }
}