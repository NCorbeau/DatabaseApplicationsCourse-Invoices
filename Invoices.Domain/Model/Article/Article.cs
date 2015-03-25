namespace Invoices.Domain.Model.Article
{
    public class Article
    {
        public uint ArticleId { get; set; }
        public Price Price { get; set; }
        public Amount Amount { get; set; }
        public string Name { get; set; }
    }
}