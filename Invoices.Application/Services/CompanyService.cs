using System;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;

namespace Invoices.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void AddCompany(Company company)
        {
            if (GetCompany(company.CompanyId) != null)
                throw new ArgumentException("Company exists already");

            _companyRepository.Insert(company);
        }

        public void ArchiveCompany(Company company)
        {
            if(GetCompany(company.CompanyId) == null)
                throw new ArgumentException("Company does not exist");

            _companyRepository.Archive(company.CompanyId);
        }

        public Company GetCompany(int id)
        {
            return _companyRepository.Find(id);
        }
    }
}
