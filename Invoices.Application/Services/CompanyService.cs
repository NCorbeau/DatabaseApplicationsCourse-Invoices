using Invoices.Domain.Model.Company;
using Invoices.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
