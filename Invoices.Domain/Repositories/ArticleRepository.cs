using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model.Article;

namespace Invoices.Domain.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly List<Article> _articleList; 

        public ArticleRepository()
        {
            _articleList = new List<Article>();
        }

        public void Insert(Article article)
        {
            _articleList.Add(article);
        }

        public void Delete(uint id)
        {
            _articleList.Remove(_articleList.First(a => a.ArticleId == id));
        }

        public Article Find(uint id)
        {
            return _articleList.FirstOrDefault(a => a.ArticleId == id);
        }

        public IList<Article> FindAll()
        {
            return _articleList;
        }
    }
}