using System;
using Nas.Core.Domain.Common;
using Nas.Core.Domain.Customers;
using Nas.Core.Domain.Directory;
using Nas.Core.Domain.Orders;
using Nas.Core.Domain.Shipping;
using Nas.Tests;
using NUnit.Framework;

namespace Nas.Data.Tests.Shipping
{
    [TestFixture]
    public class ShipmentOrderProductVariantPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_shipmentOrderProductVariant()
        {
            var sopv = new ShipmentOrderProductVariant()
            {
                Shipment = GetTestShipment(),
                OrderProductVariantId = 2,
                Quantity = 3, 
            };

            var fromDb = SaveAndLoadEntity(sopv);
            fromDb.ShouldNotBeNull();
            fromDb.Shipment.ShouldNotBeNull();
            fromDb.OrderProductVariantId.ShouldEqual(2);
            fromDb.Quantity.ShouldEqual(3);
        }

        protected Shipment GetTestShipment()
        {
            return new Shipment
            {
                Order = GetTestOrder(),
                TrackingNumber = "TrackingNumber 1",
                ShippedDateUtc = new DateTime(2010, 01, 01),
                DeliveryDateUtc = new DateTime(2010, 01, 02),
                CreatedOnUtc = new DateTime(2010, 01, 03),
            };
        }

        protected Customer GetTestCustomer()
        {
            return new Customer
            {
                CustomerGuid = Guid.NewGuid(),
                AdminComment = "some comment here",
                Active = true,
                Deleted = false,
                CreatedOnUtc = new DateTime(2010, 01, 01),
                LastActivityDateUtc = new DateTime(2010, 01, 02)
            };
        }

        protected Order GetTestOrder()
        {
            return new Order()
            {
                OrderGuid = Guid.NewGuid(),
                Customer = GetTestCustomer(),
                BillingAddress = new Address()
                {
                    Country = new Country()
                    {
                        Name = "United States",
                        TwoLetterIsoCode = "US",
                        ThreeLetterIsoCode = "USA",
                    },
                    CreatedOnUtc = new DateTime(2010, 01, 01),
                },
                Deleted = true,
                CreatedOnUtc = new DateTime(2010, 01, 01)
            };
        }
    }
}