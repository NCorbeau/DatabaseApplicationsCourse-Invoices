using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invoices.Domain.Model.Article;

namespace Invoices.Domain.Model.Article
{
    public class Article
    {
        public uint ArticleId { get; set; }

        public Price Price { get; set; }
        
        public Amount Amount { get; set; }

        public string Name { get; set; }
    }
}
