namespace Invoices.Domain.Model
{
    public class Price
    {
        public Price() { }

        public Price(double net, double gross, Currency currency)
        {
            _netAmount = net;
            _grossAmount = gross;
            Currency = currency;
        }

        private double _netAmount;
        private double _grossAmount;

        public virtual int PriceId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Tax? Tax { get; set; }

        public virtual double NetAmount
        {
            get
            {
                return _netAmount;
            }
            set
            {
                _netAmount = value;
                Tax = Tax ?? Model.Tax.Zero;
                _grossAmount = TaxCalculator.NetToGross(_netAmount, Tax.Value);
            }
        }

        public virtual double GrossAmount
        {
            get
            {
                return _grossAmount;
            }
            set
            {
                _grossAmount = value;
                Tax = Tax ?? Model.Tax.Zero;
                _netAmount = TaxCalculator.GrossToNet(_grossAmount, Tax.Value);
            }
        }

        public virtual void AdjustPrices()
        {
            if (Tax != null) 
                GrossAmount = TaxCalculator.NetToGross(NetAmount, Tax.Value);
        }

        public static Price operator -(Price priceA, Price priceB)
        {
            return new Price
            {
                GrossAmount = priceA.GrossAmount - priceB.GrossAmount,
                NetAmount = priceA.NetAmount - priceB.NetAmount,
                Currency = priceA.Currency == priceB.Currency ? priceA.Currency : Currency.NotDefined,
                Tax = priceA.Tax == priceB.Tax ? priceA.Tax : Model.Tax.NotDefined
            };
        }

        public static Price operator +(Price priceA, Price priceB)
        {
            return new Price
            {
                GrossAmount = priceA.GrossAmount + priceB.GrossAmount,
                NetAmount = priceA.NetAmount + priceB.NetAmount,
                Currency = priceA.Currency == priceB.Currency ? priceA.Currency : Currency.NotDefined,
                Tax = priceA.Tax == priceB.Tax ? priceA.Tax : Model.Tax.NotDefined
            };
        }
    }
}
