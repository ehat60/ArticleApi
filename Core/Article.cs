using System;

namespace Core
{
    public class Article
    {
        public Article(string author, string heading, string content)
        {
            Author = author;
            Heading = heading;
            Content = content;
            
            Created = DateTime.Now;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
    }
}