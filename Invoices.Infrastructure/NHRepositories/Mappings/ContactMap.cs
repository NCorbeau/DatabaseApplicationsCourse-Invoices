using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Id(i => i.ContactId);
            Map(i => i.Email);
            Map(i => i.FaxNumber);
            Map(i => i.PhoneNumber);
        }
    }
}