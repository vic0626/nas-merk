﻿using System.Collections.Generic;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Orders
{
    public partial class ShipmentModel : BaseNasEntityModel
    {
        public ShipmentModel()
        {
            this.Products = new List<ShipmentOrderProductVariantModel>();
        }
        [NasResourceDisplayName("Admin.Orders.Shipments.ID")]
        public override int Id { get; set; }
        [NasResourceDisplayName("Admin.Orders.Shipments.OrderID")]
        public int OrderId { get; set; }
        [NasResourceDisplayName("Admin.Orders.Shipments.TotalWeight")]
        public string TotalWeight { get; set; }
        [NasResourceDisplayName("Admin.Orders.Shipments.TrackingNumber")]
        public string TrackingNumber { get; set; }
        [NasResourceDisplayName("Admin.Orders.Shipments.ShippedDate")]
        public string ShippedDate { get; set; }
        public bool CanShip { get; set; }
        [NasResourceDisplayName("Admin.Orders.Shipments.DeliveryDate")]
        public string DeliveryDate { get; set; }
        public bool CanDeliver { get; set; }

        public List<ShipmentOrderProductVariantModel> Products { get; set; }

        public bool DisplayPdfPackagingSlip { get; set; }

        #region Nested classes

        public partial class ShipmentOrderProductVariantModel : BaseNasEntityModel
        {
            public int OrderProductVariantId { get; set; }
            public int ProductVariantId { get; set; }
            public string FullProductName { get; set; }
            public string Sku { get; set; }
            public string AttributeInfo { get; set; }
            
            //weight of one item (product variant)
            public string ItemWeight { get; set; }
            public string ItemDimensions { get; set; }

            public int QuantityToAdd { get; set; }
            public int QuantityOrdered { get; set; }
            public int QuantityInThisShipment { get; set; }
            public int QuantityInAllShipments { get; set; }
        }
        #endregion
    }
}