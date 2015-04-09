using Invoices.Domain.Model;

namespace Invoices.Application.Services
{
    public interface ICompanyService
    {
        void AddCompany(Company company);

        void ArchiveCompany(Company company);

        Company GetCompany(int id);
    }
} 
