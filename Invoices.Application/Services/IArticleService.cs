using Invoices.Domain.Model.Article;

namespace Invoices.Application.Services
{
    interface IArticleService
    {
        void AddArticle(Article article);

        void DeleteArticle(Article article);

        Article GetArticle(uint id);
    }
}
