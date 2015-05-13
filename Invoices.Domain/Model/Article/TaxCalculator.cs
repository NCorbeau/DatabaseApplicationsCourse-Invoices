namespace Invoices.Domain.Model
{
    public static class TaxCalculator
    {
        public static double NetToGross(double netAmount, Tax tax)
        {
            return netAmount * (1 + (int)tax / 100.0);
        }

        public static double GrossToNet(double grossAmount, Tax tax)
        {
            return grossAmount / (1 + (int)tax / 100.0);
        }
    }
}