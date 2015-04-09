using System;
using System.Collections.Generic;
using Invoices.Domain.Model;

namespace Invoices.ObjectMothers
{
    public static class ObjectMother
    {
        public static Invoice CreateInvoice()
        {
            return new Invoice(
                1,
                new List<Article>
                {
                    CreateCorrectArticleHighTaxPieces(),
                    CreateCorrectArticleLowTaxKilograms()
                },
                CreateActiveIssuerCompany(),
                CreateDeactivatedCompany(),
                DateTime.Now,
                DateTime.Now.AddMonths(1),
                PaymentType.Card, 
                new IssuingPerson());
        }

        private static IssuingCompany CreateActiveIssuerCompany()
        {
            return new IssuingCompany
            {
                CompanyId = 3,
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
            };
        }

        public static Article CreateCorrectArticleLowTaxKilograms()
        {
            return new Article
            {
                ArticleId = 1,
                Name = "Ziemniaki",
                Price = new Price
                {
                    Currency = Currency.Pln,
                    NetAmount = 2.0,
                    Tax = Tax.Low,
                },
                Unit = Unit.Kilogram
            };
        }

        public static Article CreateCorrectArticleHighTaxPieces()
        {
            return new Article
            {
                ArticleId = 2,
                Name = "Sweter",
                Price = new Price
                {
                    Currency = Currency.Pln,
                    NetAmount = 100.0,
                    Tax = Tax.High
                },
                Unit = Unit.Piece
            };
        }

        public static Company CreateActiveCompany()
        {
            return new Company
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
            };
        }

        public static Company CreateDeactivatedCompany()
        {
            return new Company
            {
                Active = false,
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
            };
        }
    }
}