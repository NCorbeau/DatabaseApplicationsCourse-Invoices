namespace Invoices.Domain.Model
{
    public class Price
    {
        private double _netAmount;
        private double _grossAmount;

        public Currency Currency { get; set; }
        public Tax? Tax { get; set; }

        public double NetAmount
        {
            get
            {
                return _netAmount;
            }
            set
            {
                _netAmount = value;
                Tax = Tax ?? Model.Tax.Zero;
                GrossAmount = TaxCalculator.NetToGross(_netAmount, Tax.Value);
            }
        }

        public double GrossAmount
        {
            get
            {
                return _grossAmount;
            }
            set
            {
                _grossAmount = value;
                Tax = Tax ?? Model.Tax.Zero;
                NetAmount = TaxCalculator.GrossToNet(_grossAmount, Tax.Value);
            }
        }
    }
}
