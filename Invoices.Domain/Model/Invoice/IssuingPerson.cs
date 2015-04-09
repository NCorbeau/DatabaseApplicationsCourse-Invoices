namespace Invoices.Domain.Model
{
    public class IssuingPerson
    {
        public virtual Role Role { get; set; }
        public virtual string IssuerId { get; set; }
        public virtual string Name { get; set; }
    }
}
