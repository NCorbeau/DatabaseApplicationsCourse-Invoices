using Invoices.Domain.Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Application.Services
{
    interface IArticleService
    {
        void AddArticle(Article article);

        void DeleteArticle(Article article);

        Article GetArticle(uint id);
    }
}
