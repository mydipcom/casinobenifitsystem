﻿using System;
using DIPSky.Core.Domain.Catalog;
using DIPSky.Core.Domain.Orders;
using DIPSky.Services.Shipping;
using DIPSky.Tests;
using NUnit.Framework;

namespace DIPSky.Services.Tests.Shipping
{
    [TestFixture]
    public class CalculateDimensionsTests : ServiceTest
    {
        [SetUp]
        public new void SetUp()
        {
        }

        [Test]
        public void should_return_zero_with_all_zero_dimensions()
        {
            var request = new GetShippingOptionRequest();
            request.Items.Add(new ShoppingCartItem()
                                  {
                                      Quantity = 1,
                                      Product = new Product()
                                                           {
                                                               Length = 0,
                                                               Width = 0,
                                                               Height = 0
                                                           }
                                  });

            decimal length, width, height = 0;
            request.GetDimensions(out width, out length, out height);
            length.ShouldEqual(0);
            width.ShouldEqual(0);
            height.ShouldEqual(0);
        }
        
        [Test]
        public void can_calculate_with_single_item_and_qty_1()
        {
            var request = new GetShippingOptionRequest();
            request.Items.Add(new ShoppingCartItem()
                                  {
                                      Quantity = 1,
                                      Product= new Product()
                                                           {
                                                               Length = 2,
                                                               Width = 2,
                                                               Height = 2
                                                           }
                                  });

            decimal length, width, height = 0;
            request.GetDimensions(out width, out length, out height);
            length.ShouldEqual(2);
            width.ShouldEqual(2);
            height.ShouldEqual(2);
        }

        [Test]
        public void can_calculate_with_cubic_item_and_multiple_qty()
        {
            var request = new GetShippingOptionRequest();
            request.Items.Add(new ShoppingCartItem()
                                  {
                                      Quantity = 3,
                                      Product = new Product()
                                                           {
                                                               Length = 2,
                                                               Width = 2,
                                                               Height = 2
                                                           }
                                  });

            decimal length, width, height = 0;
            request.GetDimensions(out width, out length, out height);
            Math.Round(length, 2).ShouldEqual(2.88);
            Math.Round(width, 2).ShouldEqual(2.88);
            Math.Round(height, 2).ShouldEqual(2.88);
        }

        [Test]
        public void can_calculate_with_multple_items_1()
        {
            var request = new GetShippingOptionRequest();
            request.Items.Add(new ShoppingCartItem()
                                  {
                                      Quantity = 3,
                                      Product = new Product()
                                                           {
                                                               Length = 2,
                                                               Width = 2,
                                                               Height = 2
                                                           }
                                  });
            request.Items.Add(new ShoppingCartItem()
                                  {
                                      Quantity = 1,
                                      Product = new Product()
                                                           {
                                                               Length = 3,
                                                               Width = 5,
                                                               Height = 2
                                                           }
                                  });

            decimal length, width, height = 0;
            request.GetDimensions(out width, out length, out height);
            Math.Round(length, 2).ShouldEqual(3.78);
            Math.Round(width, 2).ShouldEqual(5);    //preserve max width
            Math.Round(height, 2).ShouldEqual(3.78);
        }


        [Test]
        public void can_calculate_with_multple_items_2()
        {
            //take 8 cubes of 1x1x1 which is "packed" as 2x2x2 
            var request = new GetShippingOptionRequest();
            for (int i = 0; i < 8;i++)
                request.Items.Add(new ShoppingCartItem()
                {
                    Quantity = 1,
                    Product = new Product()
                    {
                        Length = 1,
                        Width = 1,
                        Height = 1
                    }
                });

            decimal length, width, height = 0;
            request.GetDimensions(out width, out length, out height);
            Math.Round(length, 2).ShouldEqual(2);
            Math.Round(width, 2).ShouldEqual(2);
            Math.Round(height, 2).ShouldEqual(2);
        }
    }
}
