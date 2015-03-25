using System.Collections.Generic;

namespace Invoices.Domain.Model.Invoice
{
    public class InvoiceSummary
    {
        public IList<Price> TaxSummary { get; set; }
        public double TotalValue { get; set; }
        public double ValueToPay { get; set; }
        public double ValuePaid { get; set; }
        public Currency Currency { get; set; }
    }
}
