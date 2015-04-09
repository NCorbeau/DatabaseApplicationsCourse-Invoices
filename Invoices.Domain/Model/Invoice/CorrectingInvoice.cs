using System;
using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class CorrectingInvoice : Invoice
    {
        public CorrectingInvoice() { }

        public virtual Invoice InvoiceToCorrect { get; set; }

        public CorrectingInvoice(int invoiceId, IList<Article> articles, Company issuer, Company buyer, DateTime transactionDate, DateTime paymentDate, PaymentType paymentType, IssuingPerson issuingPerson) 
            : base(invoiceId, articles, issuer, buyer, transactionDate, paymentDate, paymentType, issuingPerson)
        {
        }
    }
}