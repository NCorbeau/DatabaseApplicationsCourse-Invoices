namespace Invoices.Domain.Model
{
    public class BankAccount
    {
        public virtual int AccountId { get; set; }
        public virtual string BankName { get; set; }
        public virtual string AccountNumber { get; set; }
    }
}