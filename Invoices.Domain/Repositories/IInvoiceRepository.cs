using System.Collections.Generic;
using Invoices.Domain.Model;

namespace Invoices.Domain.Repositories
{
    public interface IInvoiceRepository
    {
        void Insert(Invoice invoice);
        IList<Invoice> FindAllForCompany(Company company);
        Invoice Find(uint id);
    }
}
