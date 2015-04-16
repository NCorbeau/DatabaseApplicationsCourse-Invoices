using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;
using Invoices.ObjectMothers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Invoices.Domain.UnitTests
{
    [TestClass]
    public class InvoiceSummaryTests
    {
        [TestMethod]
        public void CalculateSummary_TwoArticlesSameTax_CorrectAmounts()
        {
            var articles = new List<Article>
            {
                ObjectMother.CreateCorrectArticleHighTaxPieces(),
                ObjectMother.CreateCorrectArticleHighTaxPieces()
            };
                
            var summary
                = new InvoiceSummary(articles);

            Assert.AreEqual(
                summary.TotalAmount.GrossAmount,
                articles.Sum(a => a.Price.GrossAmount));
        }
    }
}