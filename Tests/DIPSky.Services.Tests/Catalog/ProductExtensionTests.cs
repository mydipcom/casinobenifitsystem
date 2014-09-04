using DIPSky.Core.Domain.Catalog;
using DIPSky.Services.Catalog;
using DIPSky.Tests;
using NUnit.Framework;

namespace DIPSky.Services.Tests.Catalog
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
            var product = new Product()
            {
                AllowedQuantities = "1, 5,4,10,sdf"
            };

            var result = product.ParseAllowedQuatities();
            result.Length.ShouldEqual(4);
            result[0].ShouldEqual(1);
            result[1].ShouldEqual(5);
            result[2].ShouldEqual(4);
            result[3].ShouldEqual(10);
        }
    }
}
