using System.Collections.Generic;
using Invoices.Domain.Model;

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
