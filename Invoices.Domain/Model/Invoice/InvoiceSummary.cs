using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class InvoiceSummary
    {
        public InvoiceSummary(IList<Price> taxSummary, double totalAmount, double amountToPay, double amountPaid, Currency currency)
        {
            TaxSummary = taxSummary;
            TotalAmount = totalAmount;
            AmountToPay = amountToPay;
            AmountPaid = amountPaid;
            Currency = currency;
        }

        public IList<Price> TaxSummary { get; private set; }
        public double TotalAmount { get; private set; }
        public double AmountToPay { get; set; }
        public double AmountPaid { get; set; }
        public Currency Currency { get; set; }
    }
}
