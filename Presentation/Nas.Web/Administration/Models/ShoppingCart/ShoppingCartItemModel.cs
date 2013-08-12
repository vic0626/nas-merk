using System;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartItemModel : BaseNasEntityModel
    {
        [NasResourceDisplayName("Admin.CurrentCarts.Store")]
        public string Store { get; set; }
        [NasResourceDisplayName("Admin.CurrentCarts.Product")]
        public int ProductVariantId { get; set; }
        [NasResourceDisplayName("Admin.CurrentCarts.Product")]
        public string FullProductName { get; set; }

        [NasResourceDisplayName("Admin.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }
        [NasResourceDisplayName("Admin.CurrentCarts.Quantity")]
        public int Quantity { get; set; }
        [NasResourceDisplayName("Admin.CurrentCarts.Total")]
        public string Total { get; set; }
        [NasResourceDisplayName("Admin.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }
    }
}