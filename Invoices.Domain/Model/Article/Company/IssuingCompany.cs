using System.Collections.Generic;

namespace Invoices.Domain.Model
{
    public class IssuingCompany : Company
    {
        public virtual IList<Company> Customers { get; set; }
        public virtual IList<Article> Articles { get; set; }
        public virtual IList<Invoice> IssuedInvoices { get; set; } 
    }
}       