using System;
using System.Collections.Generic;

namespace Core
{
    public interface IArticleRepository
    {
        Article Get(Guid id);
        IEnumerable<Article> GetAll();
        void Add(Article article);
    }
}