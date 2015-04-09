using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoices.Application.Services;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;
using Invoices.ObjectMothers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Invoices.Application.UnitTests
{
    [TestClass]
    public class InvoiceServiceTests
    {
        [TestMethod]
        public void IssueInvoice_CorrectInvoice_InsertCalled()
        {
            var invoiceRepository = new Mock<IInvoiceRepository>();
            var companyService = new Mock<ICompanyService>();

            var invoiceService = new InvoiceService(invoiceRepository.Object, companyService.Object);

            var invoice = ObjectMother.CreateInvoice();
            invoiceService.IssueInvoice(
                invoice.Articles,
                invoice.Issuer as IssuingCompany, 
                invoice.Buyer,
                invoice.TransactionDate,
                invoice.PaymentDate,
                invoice.PaymentType,
                invoice.IssuingPerson);

            invoiceRepository.Verify(r => r.Insert(It.IsAny<Invoice>()), Times.Once());
        }
    }
}
