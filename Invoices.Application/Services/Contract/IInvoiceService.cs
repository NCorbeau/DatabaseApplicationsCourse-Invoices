using System.Collections.Generic;
using Invoices.Domain.Model;

namespace Invoices.Application.Services
{
    public interface IInvoiceService
    {
        void AddInvoice(Invoice invoice);

        Invoice GetInvoice(int id);

        IList<Invoice> GetAllForCompany(Company company);
    }
}
