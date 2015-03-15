using Invoices.Domain.Model.Article;
using Invoices.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Application.Services
{
    class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void AddArticle(Article article)
        {
            _articleRepository.Insert(article);
        }

        public void DeleteArticle(Article article)
        {
            _articleRepository.Delete(article.ArticleId);
        }

        public Article GetArticle(uint id)
        {
            return _articleRepository.Find(id);
        }
    }
}
