using System.Collections.Generic;

namespace Invoices.Domain.Model.Company
{
    public class IssuingCompany : Company
    {
        IList<Company> Customers { get; set; }
    }
}