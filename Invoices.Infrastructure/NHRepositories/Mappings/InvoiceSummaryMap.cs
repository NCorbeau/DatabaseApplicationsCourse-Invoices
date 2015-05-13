using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class InvoiceSummaryMap : ClassMap<InvoiceSummary>
    {
        public InvoiceSummaryMap()
        {
            Id(i => i.SummaryId);
            Component(i => i.AmountPaid);
            Component(i => i.AmountToPay);
            HasMany(i => i.TaxSummary).Component(p =>
            {
                p.Map(x => x.Currency).CustomType<int>();
                p.Map(x => x.GrossAmount);
                p.Map(x => x.NetAmount);
                p.Map(x => x.Tax).CustomType<int>();
            });
            Component(i => i.TotalAmount);
        }
    }
}