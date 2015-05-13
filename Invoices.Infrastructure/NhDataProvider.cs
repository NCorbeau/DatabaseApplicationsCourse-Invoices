using System.Linq;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Invoices.Infrastructure.NHRepositories.Mappings;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;

namespace Invoices.Infrastructure
{
    public static class NHDataProvider
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    Initialize();
                return _sessionFactory;
            }
        }
        
        public static void Initialize()
        {
            _sessionFactory =
                Fluently.Configure()
                  .Database(
                    MsSqlConfiguration.MsSql2012.ShowSql().ConnectionString(c => c.FromConnectionStringWithKey("InvoicesDb"))
                  )
                  .Mappings(m =>
                    m.FluentMappings.AddFromAssemblyOf<InvoiceMap>())
                  .ExposeConfiguration(c => new SchemaExport(c).Execute(true, false, false))
                  .BuildSessionFactory();
        }


        public static void Insert<T>(params T[] objectsToAdd)
        {
            using (var session = OpenConnection())
            using (var transaction = session.BeginTransaction())
            {
                foreach (var o in objectsToAdd)
                {
                    session.Save(o);
                }

                transaction.Commit();
            }
        }

        public static IQueryable<T> Read<T>()
        {
            using (var session = OpenConnection())
            {
                return session.Query<T>();
            }
        }

        public static void Update<T>(params T[] updated)
        {
            using (var session = OpenConnection())
            using (var transaction = session.BeginTransaction())
            {
                foreach (var u in updated)
                {
                    session.SaveOrUpdate(u);
                }

                transaction.Commit();
            }
        }

        public static void Delete<T>(params T[] toDelete)
        {
            using (var session = OpenConnection())
            using (var transaction = session.BeginTransaction())
            {
                foreach (var d in toDelete)
                {
                    session.Delete(d);
                }

                transaction.Commit();
            }
        }

        public static ISession OpenConnection()
        {
            return SessionFactory.OpenSession();
        }
    }
}
