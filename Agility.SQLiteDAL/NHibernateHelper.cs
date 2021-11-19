using System;
using System.Collections.Generic;
using System.Text;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;
using System.Linq;

using Agility.DomainModel;
using Agility.SQLiteDAL.Mapping;
using System.IO;
using NHibernate.Cfg;
using System.Configuration;

namespace Agility.SQLiteDAL
{
    public class NHibernateHelper
    {

        private static ISessionFactory _sessionFactory;
        private static bool _testing = false;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if(_sessionFactory == null)
                {
                    return InitializeSessionFactory();
                }
                else
                {
                    return _sessionFactory;
                }
            }
        }

        public static void SetToTesting()
        {
            _testing = true;
        }

        public static void ClearSessionFactory()
        {
            _sessionFactory = null;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            if(!_testing)
                return "Data Source=.\\AgilityDB.db;Version=3;";
            else
                return "Data Source=.\\TestingDB.db;Version=3;";
        }

        private static ISessionFactory InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.InMemory().ConnectionString(LoadConnectionString()))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserMap>())
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
            return _sessionFactory;
        }

        private static void BuildSchema(NHibernate.Cfg.Configuration config)
        {
            if(!_testing)
            {
                if (!File.Exists("AgilityDB.db"))
                    new SchemaExport(config).Create(true, true);
            }
            else
            {
                new SchemaExport(config).Create(true, true);
            }

        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
