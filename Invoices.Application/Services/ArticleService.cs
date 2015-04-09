using System;
using System.Collections.Generic;
using System.Linq;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;

namespace Invoices.Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void AddArticle(Article article)
        {
            article.Price.AdjustPrices();
            if(_articleRepository.Find(article.ArticleId) == null)
                _articleRepository.Insert(article);
        }

        public void ArchiveArticle(Article article)
        {
            if (_articleRepository.Find(article.ArticleId) == null)
                throw new ArgumentException("Article does not exist");
            _articleRepository.Archive(article.ArticleId);
        }

        public Article GetArticle(int id)
        {
            return _articleRepository.Find(id);
        }
    }
}
