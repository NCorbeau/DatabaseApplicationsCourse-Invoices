using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Domain.Model.Company
{
    class IssuingCompany : Company
    {
        IList<Company> Customers { get; set; }
    }
}
