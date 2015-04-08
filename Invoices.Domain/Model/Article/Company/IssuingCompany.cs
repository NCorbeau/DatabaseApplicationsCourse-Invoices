using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class IssuingCompany : Company
    {
        IList<Company> Customers { get; set; }
        IList<Article> Articles { get; set; }
        IList<Invoice> IssuedInvoices { get; set; } 
    }
}       