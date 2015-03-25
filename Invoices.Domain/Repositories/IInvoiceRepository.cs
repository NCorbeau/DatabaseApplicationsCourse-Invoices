using System.Collections.Generic;
using Invoices.Domain.Model.Company;
using Invoices.Domain.Model.Invoice;

namespace Invoices.Domain.Repositories
{
    public interface IInvoiceRepository
    {
        void Insert(Invoice invoice);

        IList<Invoice> FindAllForCompany(Company company);

        Invoice Find(uint id);
    }
}
