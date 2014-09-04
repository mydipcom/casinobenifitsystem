﻿using System.Linq;
using DIPSky.Core.Domain.Directory;
using DIPSky.Core.Domain.Shipping;
using DIPSky.Tests;
using NUnit.Framework;

namespace DIPSky.Data.Tests.Shipping
{
    [TestFixture]
    public class ShippingMethodPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_shippingMethod()
        {
            var shippingMethod = new ShippingMethod
                               {
                                   Name = "Name 1",
                                   Description = "Description 1",
                                   DisplayOrder = 1
                               };

            var fromDb = SaveAndLoadEntity(shippingMethod);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.Description.ShouldEqual("Description 1");
            fromDb.DisplayOrder.ShouldEqual(1);
        }

        [Test]
        public void Can_save_and_load_shippingMethod_with_restriction()
        {
            var shippingMethod = new ShippingMethod
            {
                Name = "Name 1",
                DisplayOrder = 1
            };
            shippingMethod.RestrictedCountries.Add(GetTestCountry());

            var fromDb = SaveAndLoadEntity(shippingMethod);
            fromDb.ShouldNotBeNull();


            fromDb.RestrictedCountries.ShouldNotBeNull();
            (fromDb.RestrictedCountries.Count == 1).ShouldBeTrue();
            fromDb.RestrictedCountries.First().Name.ShouldEqual("United States");
        }

        protected Country GetTestCountry()
        {
            return new Country
                {
                    Name = "United States",
                    TwoLetterIsoCode = "US",
                    ThreeLetterIsoCode = "USA",
                };
        }
    }
}