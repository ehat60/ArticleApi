using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace DataAccess
{
    public class InMemoryArticleRepository : IArticleRepository
    {
        private static List<Article> _store = new List<Article>();
        
        public Article Get(Guid id)
        {
            return _store.Single(s => s.Id == id);
        }

        public IEnumerable<Article> GetAll()
        {
            return _store.ToList();
        }

        public void Add(Article article)
        {
            _store.Add(article);
        }
    }
}