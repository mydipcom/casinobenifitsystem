using System.Web.Mvc;
using FluentValidation.Attributes;
using DIPSky.Admin.Models.Common;
using DIPSky.Admin.Validators.Shipping;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Shipping
{
    [Validator(typeof(WarehouseValidator))]
    public partial class WarehouseModel : BaseDIPSkyEntityModel
    {
        public WarehouseModel()
        {
            this.Address = new AddressModel();
        }
        [DipSkyResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Address")]
        public AddressModel Address { get; set; }
    }
}