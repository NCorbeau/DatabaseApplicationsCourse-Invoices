using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoices.Domain.Model.Company
{
    public class Address
    {
        public string Name { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }
    }
}
