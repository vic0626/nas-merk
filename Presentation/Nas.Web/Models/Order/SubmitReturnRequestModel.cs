using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Order
{
    public partial class SubmitReturnRequestModel : BaseNasModel
    {
        public SubmitReturnRequestModel()
        {
            Items = new List<OrderProductVariantModel>();
            AvailableReturnReasons = new List<SelectListItem>();
            AvailableReturnActions= new List<SelectListItem>();
        }

        public int OrderId { get; set; }
        
        public IList<OrderProductVariantModel> Items { get; set; }
        
        [AllowHtml]
        [NasResourceDisplayName("ReturnRequests.ReturnReason")]
        public string ReturnReason { get; set; }
        public IList<SelectListItem> AvailableReturnReasons { get; set; }

        [AllowHtml]
        [NasResourceDisplayName("ReturnRequests.ReturnAction")]
        public string ReturnAction { get; set; }
        public IList<SelectListItem> AvailableReturnActions { get; set; }

        [AllowHtml]
        [NasResourceDisplayName("ReturnRequests.Comments")]
        public string Comments { get; set; }

        public string Result { get; set; }
        
        #region Nested classes

        public partial class OrderProductVariantModel : BaseNasEntityModel
        {
            public int ProductId { get; set; }

            public string ProductName { get; set; }

            public string ProductSeName { get; set; }

            public string AttributeInfo { get; set; }

            public string UnitPrice { get; set; }

            public int Quantity { get; set; }
        }

        #endregion
    }

}