using System.Collections.Generic;
using Invoices.Domain.Model;

namespace Invoices.Domain.Repositories
{
    public interface IArticleRepository
    {
        void Insert(Article article);
        void Archive(int id);
        Article Find(int id);
        IList<Article> FindAll();
    }
}
