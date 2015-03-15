using Invoices.Domain.Model.Company;
using Invoices.Domain.Model.Invoice;
using System.Collections.Generic;

namespace Invoices.Domain.Repositories
{
    public interface IInvoiceRepository
    {
        void Insert(Invoice invoice);

        IList<Invoice> FindAllForCompany(Company company);

        Invoice Find(uint id);
    }
}
