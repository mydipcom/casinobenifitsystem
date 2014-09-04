using System.Collections.Generic;
using System.Web.Mvc;

namespace DIPSky.Web.Framework.Mvc
{
    /// <summary>
    /// Base DIPSky model
    /// </summary>
    public partial class BaseDIPSkyModel
    {
        public BaseDIPSkyModel()
        {
            this.CustomProperties = new Dictionary<string, object>();
        }
        public virtual void BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
        }

        /// <summary>
        /// Use this property to store any custom value for your models. 
        /// </summary>
        public Dictionary<string, object> CustomProperties { get; set; }
    }

    /// <summary>
    /// Base DIPSky entity model
    /// </summary>
    public partial class BaseDIPSkyEntityModel : BaseDIPSkyModel
    {
        public virtual int Id { get; set; }
    }
}
