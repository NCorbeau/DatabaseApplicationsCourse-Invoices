namespace Invoices.Domain.Model
{
    public class Company
    {
        public Company()
        {
            Active = true;
        }

        public virtual int CompanyId { get; set; }
        public virtual string Name { get; set; }
        public virtual VatId VatId { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual BankAccount BankAccount { get; set; }
        public virtual bool Active { get; set; }
    }
}