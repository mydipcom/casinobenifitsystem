using AutoMapper;
using DIPSky.Admin.Infrastructure;
using NUnit.Framework;

namespace DIPSky.Web.MVC.Tests.Admin.Infrastructure
{
    [TestFixture]
    public class AutoMapperConfigurationTest
    {
        [Test]
        public void Configuration_is_valid()
        {
            var autoMapperStartupTask = new AutoMapperStartupTask();
            autoMapperStartupTask.Execute();
            Mapper.AssertConfigurationIsValid();
        }
    }
}
