﻿using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DIPSky.Core;
using NUnit.Framework;

namespace DIPSky.Data.Tests
{
    [TestFixture]
    public abstract class PersistenceTest
    {
        protected DipSkyObjectContext context;

        [SetUp]
        public void SetUp()
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
            context = new DipSkyObjectContext(GetTestDbName());
            context.Database.Delete();
            context.Database.Create();
        }

        protected string GetTestDbName()
        {
            string testDbName = "Data Source=" + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)) + @"\\DIPSky.Data.Tests.Db.sdf;Persist Security Info=False";
            return testDbName;
        }        
        
        /// <summary>
        /// Persistance test helper
        /// </summary>
        /// <typeparam name="T">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="disposeContext">A value indicating whether to dispose context</param>
        protected T SaveAndLoadEntity<T>(T entity, bool disposeContext = true) where T : BaseEntity
        {

            context.Set<T>().Add(entity);
            context.SaveChanges();

            object id = entity.Id;

            if (disposeContext)
            {
                context.Dispose();
                context = new DipSkyObjectContext(GetTestDbName());
            }

            var fromDb = context.Set<T>().Find(id);
            return fromDb;
        }
    }
}