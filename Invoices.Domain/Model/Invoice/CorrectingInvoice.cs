namespace Invoices.Domain.Model.Invoice
{
    public class CorrectingInvoice : Invoice
    {
        public Invoice InvoiceToCorrect { get; set; }
    }
}