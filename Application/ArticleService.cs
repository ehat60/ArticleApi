using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace Application
{
    public class ArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public ArticleDetailModel AddArticle(ArticleCreateModel articleModel)
        {
            var article = new Article(articleModel.Author, articleModel.Heading, articleModel.Content);
            _articleRepository.Add(article);
            return ToPublicModel(article);
        }

        public IEnumerable<ArticleListModel> GetAll()
        {
            return _articleRepository.GetAll()
                .Select(a => new ArticleListModel
                {
                    Author = a.Author,
                    Heading = a.Heading,
                    Id = a.Id,
                    Year = a.Created.Year
                });
        }
        
        private static ArticleDetailModel ToPublicModel(Article article)
        {
            return new ArticleDetailModel
            {
                Author = article.Author,
                Content = article.Content,
                Heading = article.Heading,
                Id = article.Id,
                Year = article.Created.Year
            };
        }

        public ArticleDetailModel Get(Guid id)
        {
            return ToPublicModel(_articleRepository.Get(id));
        }
    }
}