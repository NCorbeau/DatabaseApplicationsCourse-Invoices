using System;
using System.Collections.Generic;

namespace Invoices.Domain.Model.Invoice
{
    public class Invoice
    {
        public uint InvoiceId { get; set; }
        public IList<Article.Article> Articles { get; set; }
        public Company.Company Issuer { get; set; }
        public Company.Company Buyer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public InvoiceSummary Summary { get; set; }
        public IssuerPerson IssuerPerson { get; set; }
    }
}
