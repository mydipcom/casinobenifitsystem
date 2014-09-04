using DIPSky.Core.Domain.Customers;
using DIPSky.Core.Domain.Security;
using DIPSky.Tests;
using NUnit.Framework;

namespace DIPSky.Data.Tests.Security
{
    [TestFixture]
    public class AclRecordPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_urlRecord()
        {
            var aclRecord = new AclRecord
            {
                EntityId = 1,
                EntityName = "EntityName 1",
                CustomerRole = GetTestCustomerRole(),
            };

            var fromDb = SaveAndLoadEntity(aclRecord);
            fromDb.ShouldNotBeNull();
            fromDb.EntityId.ShouldEqual(1);
            fromDb.EntityName.ShouldEqual("EntityName 1");
            fromDb.CustomerRole.ShouldNotBeNull();
        }

        protected CustomerRole GetTestCustomerRole()
        {
            return new CustomerRole
            {
                Name = "Administrators",
                FreeShipping = true,
                TaxExempt = true,
                Active = true,
                IsSystemRole = true,
                SystemName = "Administrators"
            };
        }
    }
}
