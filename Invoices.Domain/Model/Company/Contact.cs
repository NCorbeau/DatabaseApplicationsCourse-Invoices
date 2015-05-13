namespace Invoices.Domain.Model
{
    public class Contact
    {
        public virtual int ContactId { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string FaxNumber { get; set; }
    }
}