using System;
using System.Data.Entity;
using Nas.Tests;
using NUnit.Framework;

namespace Nas.Data.Tests
{
    [TestFixture]
    public class SchemaTests
    {
        [Test]
        public void Can_generate_schema()
        {
            Database.SetInitializer<NasObjectContext>(null);
            var ctx = new NasObjectContext("Test");
            string result = ctx.CreateDatabaseScript();
            result.ShouldNotBeNull();
            Console.Write(result);
        }
    }
}
