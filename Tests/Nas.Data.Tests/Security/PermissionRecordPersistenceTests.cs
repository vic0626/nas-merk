﻿using System.Linq;
using Nas.Core.Domain.Customers;
using Nas.Core.Domain.Security;
using Nas.Tests;
using NUnit.Framework;

namespace Nas.Data.Tests.Security
{
    [TestFixture]
    public class PermissionRecordPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_permissionRecord()
        {
            var permissionRecord = GetTestPermissionRecord();

            var fromDb = SaveAndLoadEntity(permissionRecord);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.SystemName.ShouldEqual("SystemName 2");
            fromDb.Category.ShouldEqual("Category 4");
        }

        [Test]
        public void Can_save_and_load_permissionRecord_with_customerRoles()
        {
            var permissionRecord = GetTestPermissionRecord();
            permissionRecord.CustomerRoles.Add
                (
                    new CustomerRole()
                    {
                        Name = "Administrators",
                        SystemName = "Administrators"
                    }
                );


            var fromDb = SaveAndLoadEntity(permissionRecord);
            fromDb.ShouldNotBeNull();

            fromDb.CustomerRoles.ShouldNotBeNull();
            (fromDb.CustomerRoles.Count == 1).ShouldBeTrue();
            fromDb.CustomerRoles.First().Name.ShouldEqual("Administrators");
        }

        protected PermissionRecord GetTestPermissionRecord()
        {
            return new PermissionRecord
            {
                Name = "Name 1",
                SystemName = "SystemName 2",
                Category = "Category 4",
            };
        }
    }
}
