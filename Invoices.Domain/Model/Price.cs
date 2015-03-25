namespace Invoices.Domain.Model
{
    public class Price
    {
        public Currency Currency { get; set; }
        public Tax Tax { get; set; }
        public double NetValue { get; set; }
        public double GrossValue { get; set; }
    }
}
