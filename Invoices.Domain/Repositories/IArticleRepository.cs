using System.Collections.Generic;
using Invoices.Domain.Model;

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
