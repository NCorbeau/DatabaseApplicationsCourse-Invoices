using Invoices.Domain.Model.Company;

namespace Invoices.Application.Services
{
    interface ICompanyService
    {
        void AddCompany(Company company);

        void DeleteCompany(Company company);

        Company GetCompany(uint id);
    }
} 
