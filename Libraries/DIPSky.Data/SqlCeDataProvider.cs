﻿using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using DIPSky.Core.Data;
using DIPSky.Data.Initializers;

namespace DIPSky.Data
{
    public class SqlCeDataProvider : IDataProvider
    {
        /// <summary>
        /// Initialize connection factory
        /// </summary>
        public virtual void InitConnectionFactory()
        {
            var connectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
            Database.DefaultConnectionFactory = connectionFactory;
        }

        /// <summary>
        /// Initialize database
        /// </summary>
        public virtual void InitDatabase()
        {
            InitConnectionFactory();
            SetDatabaseInitializer();
        }

        /// <summary>
        /// Set database initializer
        /// </summary>
        public virtual void SetDatabaseInitializer()
        {
            var initializer = new CreateCeDatabaseIfNotExists<DipSkyObjectContext>();
            Database.SetInitializer(initializer);
        }

        /// <summary>
        /// A value indicating whether this data provider supports stored procedures
        /// </summary>
        public virtual bool StoredProceduredSupported
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a support database parameter object (used by stored procedures)
        /// </summary>
        /// <returns>Parameter</returns>
        public virtual DbParameter GetParameter()
        {
            return new SqlParameter();
        }
    }
}
