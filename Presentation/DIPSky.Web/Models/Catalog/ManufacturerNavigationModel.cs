using System.Collections.Generic;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Web.Models.Catalog
{
    public partial class ManufacturerNavigationModel : BaseDIPSkyModel
    {
        public ManufacturerNavigationModel()
        {
            this.Manufacturers = new List<ManufacturerBriefInfoModel>();
        }

        public IList<ManufacturerBriefInfoModel> Manufacturers { get; set; }

        public int TotalManufacturers { get; set; }
    }

    public partial class ManufacturerBriefInfoModel : BaseDIPSkyEntityModel
    {
        public string Name { get; set; }

        public string SeName { get; set; }
        
        public bool IsActive { get; set; }
    }
}