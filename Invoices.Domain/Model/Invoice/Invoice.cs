using System;
using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class Invoice
    {
        public uint InvoiceId { get; set; }
        public IList<Article> Articles { get; set; }
        public Company Issuer { get; set; }
        public Company Buyer { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public InvoiceSummary Summary { get; set; }
        public IssuingPerson IssuingPerson { get; set; }
    }
}
