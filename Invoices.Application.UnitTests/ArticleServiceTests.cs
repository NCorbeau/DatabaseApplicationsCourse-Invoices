using Invoices.Application.Services;
using Invoices.Domain.Model;
using Invoices.Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Invoices.Application.UnitTests
{
    [TestClass]
    public class ArticleServiceTests
    {
        [TestMethod]
        public void GetArticle_Exsiting_Article()
        {
            var articleRepository = new Mock<IArticleRepository>();
            var articleService = new ArticleService(articleRepository.Object);
            articleRepository.Setup(r => r.Find(It.IsAny<int>())).Returns(new Mock<Article>().Object);

            var article = articleService.GetArticle(1);

            Assert.IsInstanceOfType(article, typeof(Article));
        }
    }
}