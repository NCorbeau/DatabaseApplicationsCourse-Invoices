using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class IssuingPersonMap : ClassMap<IssuingPerson>
    {
        public IssuingPersonMap()
        {
            Id(i => i.IssuerId);
            Map(i => i.Name);
            Map(i => i.Role).CustomType<int>();
        }
    }
}