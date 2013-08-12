using System.Collections.Generic;
using System.Web.Mvc;

namespace Nas.Web.Framework.Mvc
{
    /// <summary>
    /// Base NasCommerce model
    /// </summary>
    public partial class BaseNasModel
    {
        public BaseNasModel()
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
    /// Base NasCommerce entity model
    /// </summary>
    public partial class BaseNasEntityModel : BaseNasModel
    {
        public virtual int Id { get; set; }
    }
}
