using System.Collections.Generic;
using Invoices.Domain.Model;

namespace Invoices.Domain.Repositories
{
    public interface ICompanyRepository
    {
        void Insert(Company company);
        void Archive(int id);
        Company Find(int id);
        IList<Company> FindAll();
    }
}
