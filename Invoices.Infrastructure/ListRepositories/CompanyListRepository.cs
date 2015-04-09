using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;

namespace Invoices.Domain.Repositories
{
    public class CompanyListRepository : ICompanyRepository
    {
        private readonly List<Company> _companyList; 

        public CompanyListRepository()
        {
            _companyList = new List<Company>
            {
                new Company
                {
                    CompanyId = 1,
                    Name = "Testowa firma",
                    Address = new Address
                    {
                        City = "Wrocław",
                        PostCode = "43-412",
                        Country = "Poland",
                        Street = "Szczytnicka 40"
                    },
                    BankAccount = new BankAccount
                    {
                        AccountNumber = "214215321523512",
                        BankName = "Bank Testowy"
                    },
                    Contact = new Contact
                    {
                        Email = "test@test.te",
                        FaxNumber = "1443243214",
                        PhoneNumber = "432142342"
                    },
                    VatId = new VatId
                    {
                        PolishVatId = "4141234124"
                    }
                },
                new Company
                {
                    CompanyId = 2,
                    Name = "Inna firma",
                    Address = new Address
                    {
                        City = "Warszawa",
                        PostCode = "03-412",
                        Country = "Poland",
                        Street = "Wrocławska 40"
                    },
                    BankAccount = new BankAccount
                    {
                        AccountNumber = "12351252352",
                        BankName = "Bank Testowy"
                    },
                    Contact = new Contact
                    {
                        Email = "test@mail.te",
                        FaxNumber = "23515251235",
                        PhoneNumber = "63642362"
                    },
                    VatId = new VatId
                    {
                        PolishVatId = "2634623623"
                    }
                }
            };
        }

        public void Insert(Company company)
        {
            _companyList.Add(company);
        }

        public void Archive(int id)
        {
            _companyList.Remove(_companyList.Find(c => c.CompanyId == id));
        }

        public Company Find(int id)
        {
            return _companyList.FirstOrDefault(c => c.CompanyId == id);
        }

        public IList<Company> FindAll()
        {
            return _companyList;
        }
    }
}