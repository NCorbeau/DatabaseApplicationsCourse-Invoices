using Invoices.Application.Services;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Invoices.Application.UnitTests
{
    [TestClass]
    public class CompanyServiceTests
    {
        [TestMethod]
        public void Archive_NotExistingCompany_Throws()
        {
            var companyRepository = new Mock<ICompanyRepository>();
            var companyService = new CompanyService(companyRepository.Object);
            companyRepository.Setup(r => r.Find(It.IsAny<int>())).Returns((Company)null);

            try
            {
                companyService.ArchiveCompany(new Company {CompanyId = 1});
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }
    }
}