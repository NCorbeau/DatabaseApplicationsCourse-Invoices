using System.Collections.Generic;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;

namespace Invoices.Application.Services
{
    class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public void IssueInvoice(Invoice invoice)
        {
            _invoiceRepository.Insert(invoice);
        }

        public Invoice GetInvoice(uint id)
        {
            return _invoiceRepository.Find(id);
        }

        public IList<Invoice> GetAllForCompany(Company company)
        {
            return _invoiceRepository.FindAllForCompany(company);
        }
    }
}
