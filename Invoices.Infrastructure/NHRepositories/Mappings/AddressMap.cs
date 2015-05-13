using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Id(i => i.AddressId);
            Map(i => i.City);
            Map(i => i.Country);
            Map(i => i.Name);
            Map(i => i.PostCode);
            Map(i => i.Street);
        }
    }
}