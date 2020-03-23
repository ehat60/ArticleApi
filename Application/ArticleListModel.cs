using System;

namespace Application
{
    public class ArticleListModel
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public string Heading { get; set; }
    }
}