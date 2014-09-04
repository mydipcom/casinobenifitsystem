using System;
using System.Data.Entity;
using DIPSky.Tests;
using NUnit.Framework;

namespace DIPSky.Data.Tests
{
    [TestFixture]
    public class SchemaTests
    {
        [Test]
        public void Can_generate_schema()
        {
            Database.SetInitializer<DipSkyObjectContext>(null);
            var ctx = new DipSkyObjectContext("Test");
            string result = ctx.CreateDatabaseScript();
            result.ShouldNotBeNull();
            Console.Write(result);
        }
    }
}
