using System;
using System.Collections.Generic;
using Application;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        /// <summary>
        /// Lists all articles 
        /// </summary>
        [HttpGet("/articles")]
        public IEnumerable<ArticleListModel> GetAll()
        {
            return _articleService.GetAll();
        }

        /// <summary>
        /// Gets article details
        /// </summary>
        /// <param name="id">Article id</param>
        [HttpGet("/articles/{id}")]
        public ArticleDetailModel Get([FromRoute] Guid id)
        {
            return _articleService.Get(id);
        }

        /// <summary>
        /// Creates a new article
        /// </summary>
        [HttpPost("/articles")]
        public ArticleDetailModel CreateArticle([FromBody] ArticleCreateModel article)
        {
            return _articleService.AddArticle(article);
        }
    }
}