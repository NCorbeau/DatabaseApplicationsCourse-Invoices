namespace Invoices.Domain.Model
{
    public class Article
    {
        public uint ArticleId { get; set; }
        public Price Price { get; set; }
        public double Amount { get; set; }
        public string Name { get; set; }
    }
}