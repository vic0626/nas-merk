using Nas.Core.Domain.Catalog;
using Nas.Services.Catalog;
using Nas.Tests;
using NUnit.Framework;

namespace Nas.Services.Tests.Catalog
{
    [TestFixture]
    public class ProductExtensionTests : ServiceTest
    {
        [SetUp]
        public new void SetUp()
        {

        }

        [Test]
        public void Can_parse_allowed_quantities()
        {
            var pv = new ProductVariant()
            {
                AllowedQuantities = "1, 5,4,10,sdf"
            };

            var result = pv.ParseAllowedQuatities();
            result.Length.ShouldEqual(4);
            result[0].ShouldEqual(1);
            result[1].ShouldEqual(5);
            result[2].ShouldEqual(4);
            result[3].ShouldEqual(10);
        }
    }
}
