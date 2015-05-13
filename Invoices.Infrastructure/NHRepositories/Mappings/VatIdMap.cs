using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class VatIdMap : ClassMap<VatId>
    {
        public VatIdMap()
        {
            Id(i => i.Id);
            Map(i => i.EuropeanVatId);
            Map(i => i.PolishVatId);
        }
    }
}