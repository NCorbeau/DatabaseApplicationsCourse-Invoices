using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class CorrectingInvoiceMap : ClassMap<CorrectingInvoice>
    {
        public CorrectingInvoiceMap()
        {
            Id(i => i.InvoiceId);
            Map(i => i.IssueDate);
            Map(i => i.PaymentDate).LazyLoad();
            Map(i => i.TransactionDate).LazyLoad();
            Map(i => i.PaymentType).CustomType<int>().LazyLoad();
            References(i => i.Summary).Cascade.All().Not.LazyLoad();
            References(i => i.Issuer);
            References(i => i.Buyer).Not.LazyLoad();
            References(i => i.IssuingPerson).LazyLoad();
            HasManyToMany(i => i.Articles);

            References(i => i.InvoiceToCorrect).Not.LazyLoad();
        }
    }
}