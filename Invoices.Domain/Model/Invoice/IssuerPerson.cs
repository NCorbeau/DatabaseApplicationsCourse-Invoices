using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoices.Domain.Model.Invoice
{
    public class IssuerPerson
    {
        public Role Role { get; set; }
        public string IssuerId { get; set; }
        public string Name { get; set; }
    }
}
