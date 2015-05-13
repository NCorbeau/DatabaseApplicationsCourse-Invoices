using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class BankAccountMap : ClassMap<BankAccount>
    {
        public BankAccountMap()
        {
            Id(i => i.AccountId);
            Map(i => i.AccountNumber);
            Map(i => i.BankName);
        }
    }
}