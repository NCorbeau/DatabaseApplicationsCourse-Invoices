namespace Invoices.Domain.Model
{
    public class Address
    {
        public virtual int AddressId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string Country { get; set; }
    }
}