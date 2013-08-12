﻿using Nas.Core.Domain.Catalog;
using Nas.Tests;
using NUnit.Framework;

namespace Nas.Data.Tests.Catalog
{
    [TestFixture]
    public class ProductAttributePersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_productAttribute()
        {
            var pa = new ProductAttribute
            {
                Name = "Name 1",
                Description = "Description 1",
            };

            var fromDb = SaveAndLoadEntity(pa);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.Description.ShouldEqual("Description 1");
        }
    }
}