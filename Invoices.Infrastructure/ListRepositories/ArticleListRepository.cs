using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;

namespace Invoices.Domain.Repositories
{
    public class ArticleListRepository : IArticleRepository
    {
        private readonly List<Article> _articleList; 

        public ArticleListRepository()
        {
            _articleList = new List<Article>
            {
                new Article
                {
                    ArticleId = 1, 
                    Name = "Ziemniaki", 
                    Price = new Price
                    {
                        Currency = Currency.Pln,
                        NetAmount = 2.0,
                        Tax = Tax.Low,
                    },
                    Unit = Unit.Kilogram
                },

                new Article
                {
                    ArticleId = 2, 
                    Name = "Sweter", 
                    Price = new Price
                    {
                        Currency = Currency.Pln,
                        NetAmount = 100.0,
                        Tax = Tax.High
                    },
                    Unit = Unit.Piece
                }
            };
        }

        public void Insert(Article article)
        {
            _articleList.Add(article);
        }

        public void Archive(int id)
        {
            _articleList.Remove(_articleList.First(a => a.ArticleId == id));
        }

        public Article Find(int id)
        {
            return _articleList.FirstOrDefault(a => a.ArticleId == id);
        }

        public IList<Article> FindAll()
        {
            return _articleList;
        }
    }
}