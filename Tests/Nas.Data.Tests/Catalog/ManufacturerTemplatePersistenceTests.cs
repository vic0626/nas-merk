﻿using Nas.Core.Domain.Catalog;
using Nas.Tests;
using NUnit.Framework;

namespace Nas.Data.Tests.Catalog
{
    [TestFixture]
    public class ManufacturerTemplatePersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_manufacturerTemplate()
        {
            var manufacturerTemplate = new ManufacturerTemplate()
            {
                Name = "Name 1",
                ViewPath = "ViewPath 1",
                DisplayOrder = 1,
            };

            var fromDb = SaveAndLoadEntity(manufacturerTemplate);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.ViewPath.ShouldEqual("ViewPath 1");
            fromDb.DisplayOrder.ShouldEqual(1);
        }
    }
}
