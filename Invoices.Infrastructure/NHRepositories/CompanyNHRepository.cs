using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;
using Invoices.Infrastructure;

namespace Invoices.Domain.Repositories
{
    public class CompanyNHRepository : ICompanyRepository
    {
        public void Insert(Company company)
        {
            NHDataProvider.Insert(company);
        }

        public void Archive(int id)
        {
            var company = Find(id);
            company.Active = false;
            NHDataProvider.Update(company);
        }

        public Company Find(int id)
        {
            return NHDataProvider.Read<Company>().FirstOrDefault(c => c.CompanyId == id);
        }

        public IList<Company> FindAll()
        {
            return NHDataProvider.Read<Company>().ToList();
        }
    }
}