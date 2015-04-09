using System;
using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class Invoice
    {
        public Invoice() { }

        public Invoice(int invoiceId, IList<Article> articles, Company issuer, Company buyer, DateTime transactionDate, DateTime paymentDate, PaymentType paymentType, IssuingPerson issuingPerson)
        {
            InvoiceId = invoiceId;
            Articles = articles;
            Issuer = issuer;
            Buyer = buyer;
            TransactionDate = transactionDate;
            PaymentDate = paymentDate;
            PaymentType = paymentType;
            IssuingPerson = issuingPerson;

            Summary = new InvoiceSummary(articles);
            IssueDate = DateTime.Now;
        }

        public virtual int InvoiceId { get; protected set; }
        public virtual IList<Article> Articles { get; protected set; }
        public virtual Company Issuer { get; protected set; }
        public virtual Company Buyer { get; protected set; }
        public virtual DateTime IssueDate { get; protected set; }
        public virtual DateTime TransactionDate { get; protected set; }
        public virtual DateTime PaymentDate { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual InvoiceSummary Summary { get; protected set; }
        public virtual IssuingPerson IssuingPerson { get; protected set; }
    }
}
