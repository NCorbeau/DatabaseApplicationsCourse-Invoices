﻿using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;

namespace Invoices.Domain.Repositories
{
    public class InvoiceListRepository : IInvoiceRepository
    {
        private readonly List<Invoice> _invoiceList;

        public InvoiceListRepository()
        {
            _invoiceList = new List<Invoice>();
        }

        public void Insert(Invoice invoice)
        {
            _invoiceList.Add(invoice);
        }

        public IList<Invoice> FindAllForCompany(Company company)
        {
            return _invoiceList.Where(i => i.Issuer == company).ToList();
        }

        public Invoice Find(int id)
        {
            return _invoiceList.FirstOrDefault(i => i.InvoiceId == id);
        }

        public int GetNextId()
        {
            return _invoiceList.OrderBy(i => i.InvoiceId).Last().InvoiceId + 1;
        }
    }
}