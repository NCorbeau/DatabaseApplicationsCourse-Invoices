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
