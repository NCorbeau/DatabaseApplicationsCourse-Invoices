using System;
using System.Collections;
using System.Collections.Generic;
using Invoices.Domain.Model.Article;
using Invoices.Domain.Repositories;

namespace Invoices.Application.Services
{
    class C : IEnumerator<int>
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public int Current
        {
            get { throw new NotImplementedException(); }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }

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
