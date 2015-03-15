using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.Domain.Model.Invoice;
using Invoices.Domain.Model.Article;
using Invoices.Domain.Model.Company;

namespace Invoices.Application.Services
{
    interface IInvoiceService
    {
        void IssueInvoice(Invoice invoice);

        Invoice GetInvoice(uint id);

        IList<Invoice> GetAllForCompany(Company company);
    }
}
