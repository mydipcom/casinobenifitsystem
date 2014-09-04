using System;
using System.Collections.Generic;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Orders
{
    public partial class ShipmentModel : BaseDIPSkyEntityModel
    {
        public ShipmentModel()
        {
            this.Items = new List<ShipmentItemModel>();
        }
        [DipSkyResourceDisplayName("Admin.Orders.Shipments.ID")]
        public override int Id { get; set; }
        [DipSkyResourceDisplayName("Admin.Orders.Shipments.OrderID")]
        public int OrderId { get; set; }
        [DipSkyResourceDisplayName("Admin.Orders.Shipments.TotalWeight")]
        public string TotalWeight { get; set; }
        [DipSkyResourceDisplayName("Admin.Orders.Shipments.TrackingNumber")]
        public string TrackingNumber { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.Shipments.ShippedDate")]
        public string ShippedDate { get; set; }
        public bool CanShip { get; set; }
        public DateTime? ShippedDateUtc { get; set; }

        [DipSkyResourceDisplayName("Admin.Orders.Shipments.DeliveryDate")]
        public string DeliveryDate { get; set; }
        public bool CanDeliver { get; set; }
        public DateTime? DeliveryDateUtc { get; set; }

        public List<ShipmentItemModel> Items { get; set; }

        #region Nested classes

        public partial class ShipmentItemModel : BaseDIPSkyEntityModel
        {
            public int OrderItemId { get; set; }
            public int ProductId { get; set; }
            [DipSkyResourceDisplayName("Admin.Orders.Shipments.Products.ProductName")]
            public string ProductName { get; set; }
            public string Sku { get; set; }
            public string AttributeInfo { get; set; }

            //weight of one item (product)
            [DipSkyResourceDisplayName("Admin.Orders.Shipments.Products.ItemWeight")]
            public string ItemWeight { get; set; }
            [DipSkyResourceDisplayName("Admin.Orders.Shipments.Products.ItemDimensions")]
            public string ItemDimensions { get; set; }

            public int QuantityToAdd { get; set; }
            public int QuantityOrdered { get; set; }
            [DipSkyResourceDisplayName("Admin.Orders.Shipments.Products.QtyShipped")]
            public int QuantityInThisShipment { get; set; }
            public int QuantityInAllShipments { get; set; }
        }
        #endregion
    }
}