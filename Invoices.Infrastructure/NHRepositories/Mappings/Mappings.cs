using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class InvoiceMap : ClassMap<Invoice>
    {
        public InvoiceMap()
        {
            Id(i => i.InvoiceId);
            Map(i => i.IssueDate);
            Map(i => i.PaymentDate);
            Map(i => i.TransactionDate);
            Map(i => i.PaymentType).CustomType<int>();
            References(i => i.Summary).Cascade.All();
            References(i => i.Issuer);
            References(i => i.Buyer);
            References(i => i.IssuingPerson);
            HasMany(i => i.Articles);
        }
    }

    public class CorrectingInvoiceMap : ClassMap<CorrectingInvoice>
    {
        public CorrectingInvoiceMap()
        {
            Id(i => i.InvoiceId);
            Map(i => i.IssueDate);
            Map(i => i.PaymentDate);
            Map(i => i.TransactionDate);
            Map(i => i.PaymentType).CustomType<int>();
            References(i => i.Summary).Cascade.All();
            References(i => i.Issuer);
            References(i => i.Buyer);
            References(i => i.IssuingPerson);
            HasMany(i => i.Articles);

            References(i => i.InvoiceToCorrect);
        }
    }

    public class InvoiceSummaryMap : ClassMap<InvoiceSummary>
    {
        public InvoiceSummaryMap()
        {
            Id(i => i.SummaryId);
            References(i => i.AmountPaid);
            References(i => i.AmountToPay);
            HasMany(i => i.TaxSummary).Cascade.All();
            References(i => i.TotalAmount);
        }
    }

    public class ArticleMap : ClassMap<Article>
    {
        public ArticleMap()
        {
            Id(i => i.ArticleId);
            Map(i => i.Active);
            Map(i => i.Name);
            Map(i => i.Unit).CustomType<int>();
            References(i => i.Price).Cascade.All();
        }
    }

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

    public class BankAccountMap : ClassMap<BankAccount>
    {
        public BankAccountMap()
        {
            Id(i => i.AccountId);
            Map(i => i.AccountNumber);
            Map(i => i.BankName);
        }
    }

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

    public class VatIdMap : ClassMap<VatId>
    {
        public VatIdMap()
        {
            Id(i => i.Id);
            Map(i => i.EuropeanVatId);
            Map(i => i.PolishVatId);
        }
    }

    public class IssuingCompanyMap : ClassMap<IssuingCompany>
    {
        public IssuingCompanyMap()
        {
            Id(i => i.CompanyId);
            Map(i => i.Active);
            Map(i => i.Name);
            References(i => i.Address);
            References(i => i.BankAccount);
            References(i => i.Contact);
            References(i => i.VatId);

            HasMany(i => i.Articles);
            HasMany(i => i.Customers);
            HasMany(i => i.IssuedInvoices);
        }
    }

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

    public class IssuingPersonMap : ClassMap<IssuingPerson>
    {
        public IssuingPersonMap()
        {
            Id(i => i.IssuerId);
            Map(i => i.Name);
            Map(i => i.Role).CustomType<int>();
        }
    }

    public class PriceMap : ClassMap<Price>
    {
        public PriceMap()
        {
            Id(i => i.PriceId);
            Map(i => i.Currency).CustomType<int>();
            Map(i => i.GrossAmount);
            Map(i => i.NetAmount);
            Map(i => i.Tax).CustomType<int>();
        }
    }
}
