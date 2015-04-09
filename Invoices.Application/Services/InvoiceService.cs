using System;
using System.Collections.Generic;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;

namespace Invoices.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly ICompanyService _companyService;

        public InvoiceService(IInvoiceRepository invoiceRepository, ICompanyService companyService)
        {
            _invoiceRepository = invoiceRepository;
            _companyService = companyService;
        }

        public string IssueInvoice(IList<Article> articles, IssuingCompany issuer, Company buyer,
            DateTime transactionDate, DateTime paymentDate, PaymentType paymentType, IssuingPerson issuingPerson)
        {
            if(!issuer.Active)
                throw new ArgumentException("Company is not active");

            var invoice = new Invoice(
                _invoiceRepository.GetNextId(),
                articles,
                issuer,
                buyer,
                transactionDate,
                paymentDate,
                paymentType,
                issuingPerson);

            AddInvoice(invoice);

            return invoice.ToString();
        }

        public void AddInvoice(Invoice invoice)
        {
            if(GetInvoice(invoice.InvoiceId) != null)
                throw new ArgumentException("Invoice with given Id exists already");

            _invoiceRepository.Insert(invoice);
        }

        public Invoice GetInvoice(int id)
        {
            return _invoiceRepository.Find(id);
        }

        public IList<Invoice> GetAllForCompany(Company company)
        {
            if(_companyService.GetCompany(company.CompanyId) == null)
                throw new ArgumentException("Company does not exist");

            return _invoiceRepository.FindAllForCompany(company);
        }
    }
}
