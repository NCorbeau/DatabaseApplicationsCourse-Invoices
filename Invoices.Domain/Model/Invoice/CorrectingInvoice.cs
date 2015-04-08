namespace Invoices.Domain.Model
{
    public class CorrectingInvoice : Invoice
    {
        public Invoice InvoiceToCorrect { get; set; }
    }
}