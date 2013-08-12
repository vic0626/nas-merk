using System;
using Nas.Core.Domain.Common;
using Nas.Core.Domain.Directory;
using Nas.Core.Domain.Vendors;
using Nas.Tests;
using NUnit.Framework;

namespace Nas.Data.Tests.Vendors
{
    [TestFixture]
    public class VendorPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_vendor()
        {
            var vendor = new Vendor
            {
                Name = "Name 1",
                Email = "Email 1",
                Description = "Description 1",
                AdminComment = "AdminComment 1",
                Active = true,
                Deleted = true,
            };

            var fromDb = SaveAndLoadEntity(vendor);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.Email.ShouldEqual("Email 1");
            fromDb.Description.ShouldEqual("Description 1");
            fromDb.AdminComment.ShouldEqual("AdminComment 1");
            fromDb.Active.ShouldEqual(true);
            fromDb.Deleted.ShouldEqual(true);
        }
    }
}
