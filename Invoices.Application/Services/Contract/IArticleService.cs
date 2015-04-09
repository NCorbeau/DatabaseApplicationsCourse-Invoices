using Invoices.Domain.Model;

namespace Invoices.Application.Services
{
    public interface IArticleService
    {
        void AddArticle(Article article);

        void ArchiveArticle(Article article);

        Article GetArticle(int id);
    }
}
