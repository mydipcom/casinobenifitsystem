﻿using DIPSky.Core.Configuration;
using DIPSky.Core.Infrastructure;
using DIPSky.Core.Infrastructure.DependencyManagement;
using NUnit.Framework;

namespace DIPSky.Core.Tests.Infrastructure.DependencyManagement
{
    [TestFixture]
    public class AutoFacContainerSanityTests : ContainerSanityTests
    {
        protected override IEngine CreateEngine()
        {
            var engine = new DipSkyEngine();

            return engine;
        }
    }
    
    /// <summary>
    /// Class that allows you to unit test any IEngine implementations
    /// </summary>
    public abstract class ContainerSanityTests
    {
        ContainerManager container;

        [SetUp]
        public void SetUp()
        {
            container = CreateEngine().ContainerManager;
        }

        protected abstract IEngine CreateEngine();

        [Test]
        public void CanRetrieve_ImportantServices()
        {
            Assert.That(container.Resolve<DipSkyConfig>(), Is.Not.Null);
            Assert.That(container.Resolve<IEngine>(), Is.Not.Null);
        }
        
        [Test]
        public void AddComponentLifeStyle_DoesNotReturnSameServiceTwiceWhenSingleton()
        {
            container.AddComponent<object>("testing");

            var class1 = container.Resolve<object>();
            var class2 = container.Resolve<object>();

            Assert.That(class1, Is.SameAs(class2));
        }

        [Test]
        public void AddComponentLifeStyle_DoesNotReturnSameServiceTwiceWhenTransient()
        {
            container.AddComponent<object>("testing", ComponentLifeStyle.Transient);

            var class1 = container.Resolve<object>();
            var class2 = container.Resolve<object>();

            Assert.That(class1, Is.Not.SameAs(class2));
        }
    }
}
