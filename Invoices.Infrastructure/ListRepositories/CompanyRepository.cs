using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;

namespace Invoices.Domain.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly List<Company> _companyList; 

        public CompanyRepository()
        {
            _companyList = new List<Company>();
        }

        public void Insert(Company company)
        {
            _companyList.Add(company);
        }

        public void Delete(uint id)
        {
            _companyList.Remove(_companyList.Find(c => c.CompanyId == id));
        }

        public Company Find(uint id)
        {
            return _companyList.FirstOrDefault(c => c.CompanyId == id);
        }

        public IList<Company> FindAll()
        {
            return _companyList;
        }
    }
}