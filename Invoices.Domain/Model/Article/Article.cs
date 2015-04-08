namespace Invoices.Domain.Model
{
    public class Article
    {
        public uint ArticleId { get; set; }
        public Price Price { get; set; }
        public Unit Unit { get; set; }
        public string Name { get; set; }
    }
}