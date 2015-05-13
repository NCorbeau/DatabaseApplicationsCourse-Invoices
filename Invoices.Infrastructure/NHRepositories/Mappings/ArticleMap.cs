using FluentNHibernate.Mapping;
using Invoices.Domain.Model;

namespace Invoices.Infrastructure.NHRepositories.Mappings
{
    public class ArticleMap : ClassMap<Article>
    {
        public ArticleMap()
        {
            Id(i => i.ArticleId);
            Map(i => i.Active);
            Map(i => i.Name).LazyLoad();
            Map(i => i.Unit).CustomType<int>();
            Component(i => i.Price);
        }
    }
}