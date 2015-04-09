namespace Invoices.Domain.Model
{
    public class Article
    {
        public Article()
        {
            Active = true;
        }

        public virtual int ArticleId { get; set; }
        public virtual Price Price { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual string Name { get; set; }
        public virtual bool Active { get; set; }
    }
}