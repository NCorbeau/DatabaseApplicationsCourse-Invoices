using System;
using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class Invoice
    {
        public Invoice(uint invoiceId, IList<Article> articles, Company issuer, Company buyer, DateTime issueDate, DateTime transactionDate, DateTime paymentDate, PaymentType paymentType, InvoiceSummary summary, IssuingPerson issuingPerson)
        {
            InvoiceId = invoiceId;
            Articles = articles;
            Issuer = issuer;
            Buyer = buyer;
            IssueDate = issueDate;
            TransactionDate = transactionDate;
            PaymentDate = paymentDate;
            PaymentType = paymentType;
            Summary = summary;
            IssuingPerson = issuingPerson;
        }

        public uint InvoiceId { get; private set; }
        public IList<Article> Articles { get; private set; }
        public Company Issuer { get; private set; }
        public Company Buyer { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public DateTime PaymentDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public InvoiceSummary Summary { get; private set; }
        public IssuingPerson IssuingPerson { get; private set; }
    }
}
