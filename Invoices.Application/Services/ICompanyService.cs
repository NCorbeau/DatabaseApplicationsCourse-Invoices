using Invoices.Domain.Model.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Application.Services
{
    interface ICompanyService
    {
        void AddCompany(Company company);

        void DeleteCompany(Company company);

        Company GetCompany(uint id);
    }
} 
