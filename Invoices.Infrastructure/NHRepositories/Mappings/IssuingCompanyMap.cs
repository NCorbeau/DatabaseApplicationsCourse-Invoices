using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class IssuingCompanyMap : ClassMap<IssuingCompany>
    {
        public IssuingCompanyMap()
        {
            Id(i => i.CompanyId);
            Map(i => i.Active).Not.LazyLoad();
            Map(i => i.Name).LazyLoad();
            References(i => i.Address).Cascade.All();
            References(i => i.BankAccount).Cascade.All();
            References(i => i.Contact).Cascade.All();
            References(i => i.VatId).Cascade.All();

            HasManyToMany(i => i.Articles);
            HasMany(i => i.Customers);
            HasMany(i => i.IssuedInvoices);
        }
    }
}