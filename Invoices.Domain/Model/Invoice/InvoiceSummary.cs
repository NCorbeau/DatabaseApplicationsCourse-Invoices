using System;
using System.Collections.Generic;
using System.Linq;

namespace Invoices.Domain.Model
{
    public class InvoiceSummary
    {
        public InvoiceSummary() { }

        public InvoiceSummary(IList<Article> articles, double grossPaid = 0.0)
        {
            TaxSummary = CalculatePriceSummary(articles);
            
            TotalAmount = new Price(
                TaxSummary.Sum(t => t.NetAmount),
                TaxSummary.Sum(t => t.GrossAmount),
                TaxSummary.Select(
                    t => new {t.Currency}).Count() == 1
                    ? TaxSummary.First().Currency
                    : Currency.NotDefined);

            AmountPaid = new Price { GrossAmount = grossPaid };
        }

        protected virtual IList<Price> CalculatePriceSummary(IList<Article> articles)
        {
            return (from Tax tax in Enum.GetValues(typeof (Tax))
                let currentTax = tax
                let taxArticles = articles.Where(a => a.Price.Tax == currentTax).ToList()
                select new Price
                {
                    Tax = tax,
                    NetAmount = taxArticles.Sum(a => a.Price.NetAmount),
                    GrossAmount = taxArticles.Sum(a => a.Price.GrossAmount),
                    Currency = 
                        (from a in taxArticles 
                         group a by a.Price.Currency).Count() == 1 
                         ? taxArticles.First().Price.Currency 
                         : Currency.NotDefined
                }).ToList();
        }

        public virtual int SummaryId { get; set; }
        public virtual IList<Price> TaxSummary { get; protected set; }
        public virtual Price TotalAmount { get; protected set; }
        public virtual Price AmountPaid { get; set; }

        public virtual Price AmountToPay
        {
            get { return TotalAmount - AmountPaid; }
            set { }
        }
    }
}