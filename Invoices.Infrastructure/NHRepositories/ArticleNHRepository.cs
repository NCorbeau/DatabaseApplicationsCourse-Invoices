using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;
using Invoices.Infrastructure;

namespace Invoices.Domain.Repositories
{
    public class ArticleNHRepository : IArticleRepository
    {
        public void Insert(Article article)
        {
            NHDataProvider.Insert(article);
        }

        public void Archive(int id)
        {
            var toArchive = Find(id);
            toArchive.Active = false;
            NHDataProvider.Update(toArchive);
        }

        public Article Find(int id)
        {
            return NHDataProvider.Read<Article>().FirstOrDefault(a => a.ArticleId == id);
        }

        public IList<Article> FindAll()
        {
            return NHDataProvider.Read<Article>().ToList();
        }
    }
}