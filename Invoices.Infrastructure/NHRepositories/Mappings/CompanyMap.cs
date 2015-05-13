using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Id(i => i.CompanyId);
            Map(i => i.Active);
            Map(i => i.Name);
            References(i => i.Address).Cascade.All();
            References(i => i.BankAccount).Cascade.All();
            References(i => i.Contact).Cascade.All();
            References(i => i.VatId).Cascade.All();
        }
    }
}