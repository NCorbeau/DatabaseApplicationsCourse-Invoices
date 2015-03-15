using Invoices.Domain.Model.Company;
using System.Collections.Generic;

namespace Invoices.Domain.Repositories
{
    public interface ICompanyRepository
    {
        void Insert(Company company);

        void Delete(uint id);

        Company Find(uint id);

        IList<Company> FindAll();
    }
}
