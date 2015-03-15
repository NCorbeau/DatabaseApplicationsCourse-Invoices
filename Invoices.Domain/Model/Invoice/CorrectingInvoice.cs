using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Domain.Model.Invoice
{
    public class CorrectingInvoice : Invoice
    {
        public Invoice InvoiceToCorrect { get; set; }
    }
}
