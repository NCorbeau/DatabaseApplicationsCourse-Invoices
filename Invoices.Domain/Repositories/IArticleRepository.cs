using Invoices.Domain.Model.Article;
using Invoices.Domain.Model.Invoice;
using System.Collections.Generic;

namespace Invoices.Domain.Repositories
{
    public interface IArticleRepository
    {
        void Insert(Article article);

        void Delete(uint id);

        Article Find(uint id);

        IList<Article> FindAll();
    }
}
