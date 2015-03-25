using Invoices.Domain.Model.Company;
using Invoices.Domain.Repositories;

namespace Invoices.Application.Services
{
    class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void AddCompany(Company company)
        {
            _companyRepository.Insert(company);
        }

        public void DeleteCompany(Company company)
        {
            _companyRepository.Delete(company.CompanyId);
        }

        public Company GetCompany(uint id)
        {
            return _companyRepository.Find(id);
        }
    }
}
