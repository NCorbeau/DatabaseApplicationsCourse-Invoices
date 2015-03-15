using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoices.Domain.Model.Company;

namespace Invoices.Domain.Model.Company
{
    public class Company
    {
        public uint CompanyId { get; set; }

        public string Name { get; set; }

        public VatId VatId { get; set; }

        public Address Address { get; set; }

        public Contact Contact { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}
