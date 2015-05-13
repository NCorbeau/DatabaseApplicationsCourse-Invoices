using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Linq;

namespace Invoices.Infrastructure.UnitTests
{
    [TestClass]
    public class NHibernateLoadingTests
    {
        [TestMethod]
        public void LazyLoadingTest()
        {
            IList<IssuingCompany> companies;
            using (var session = NHDataProvider.OpenConnection())
            {
                companies = session.Query<IssuingCompany>().ToList();
            }

            if(companies == null) Assert.Fail();
            Assert.IsFalse(NHibernateUtil.IsInitialized(companies[0].Articles));
        }

        [TestMethod]
        public void EagerLoadingTest()
        {
            IList<IssuingCompany> companies;
            using (var session = NHDataProvider.OpenConnection())
            {
                companies = session.Query<IssuingCompany>().ToList();
            }

            if (companies == null) Assert.Fail();
            Assert.IsTrue(NHibernateUtil.IsInitialized(companies[0].Active));

        }
    }
}