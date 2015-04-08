using System;
using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class CorrectingInvoice : Invoice
    {
        public CorrectingInvoice(uint invoiceId, IList<Article> articles, Company issuer, Company buyer, DateTime issueDate, DateTime transactionDate, DateTime paymentDate, PaymentType paymentType, InvoiceSummary summary, IssuingPerson issuingPerson)
            : base(invoiceId, articles, issuer, buyer, issueDate, transactionDate, paymentDate, paymentType, summary, issuingPerson)
        {
        }

        public Invoice InvoiceToCorrect { get; set; }
    }
}