using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;

namespace Invoices.Infrastructure.NHRepositories
{
    public class InvoiceNHRepository : IInvoiceRepository
    {
        public void Insert(Invoice invoice)
        {
            NHDataProvider.Insert(invoice);
        }

        public IList<Invoice> FindAllForCompany(Company company)
        {
            return NHDataProvider.Read<Invoice>().Where(c => c.Issuer == company).ToList();
        }

        public Invoice Find(int id)
        {
            return NHDataProvider.Read<Invoice>().FirstOrDefault(c => c.InvoiceId == id);
        }

        public int GetNextId()
        {
            return NHDataProvider.Read<Invoice>().OrderBy(i => i.InvoiceId).Last().InvoiceId + 1;
        }
    }
}