using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class PriceMap : ComponentMap<Price>
    {
        public PriceMap()
        {
            Map(i => i.Currency).CustomType<int>();
            Map(i => i.GrossAmount);
            Map(i => i.NetAmount);
            Map(i => i.Tax).CustomType<int>();
        }
    }
}
