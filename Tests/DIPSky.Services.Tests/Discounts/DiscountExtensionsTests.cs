using DIPSky.Core.Domain.Discounts;
using DIPSky.Services.Discounts;
using DIPSky.Tests;
using NUnit.Framework;

namespace DIPSky.Services.Tests.Discounts
{
    [TestFixture]
    public class DiscountExtensionsTests : ServiceTest
    {
        [Test]
        public void Can_calculate_discount_amount_percentage()
        {
            var discount = new Discount()
            {
                UsePercentage = true,
                DiscountPercentage = 30
            };

            discount.GetDiscountAmount(100).ShouldEqual(30);

            discount.DiscountPercentage = 60;
            discount.GetDiscountAmount(200).ShouldEqual(120);
        }
        [Test]
        public void Can_calculate_discount_amount_fixed()
        {
            var discount = new Discount()
            {
                UsePercentage = false,
                DiscountAmount = 10
            };

            discount.GetDiscountAmount(100).ShouldEqual(10);

            discount.DiscountAmount = 20;
            discount.GetDiscountAmount(200).ShouldEqual(20);
        }
    }
}
