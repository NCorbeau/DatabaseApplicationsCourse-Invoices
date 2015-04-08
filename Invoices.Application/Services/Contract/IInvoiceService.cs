using System.Collections.Generic;
using Invoices.Domain.Model;

namespace Invoices.Application.Services
{
    interface IInvoiceService
    {
        void IssueInvoice(Invoice invoice);

        Invoice GetInvoice(uint id);

        IList<Invoice> GetAllForCompany(Company company);
    }
}
