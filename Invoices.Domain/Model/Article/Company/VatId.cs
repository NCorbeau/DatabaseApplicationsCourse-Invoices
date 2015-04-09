namespace Invoices.Domain.Model
{
    public class VatId
    {
        public virtual int Id { get; set; }
        public virtual string EuropeanVatId { get; set; }
        public virtual string PolishVatId { get; set; }
    }
}