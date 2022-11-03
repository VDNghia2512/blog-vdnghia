using Microsoft.AspNetCore.Mvc;
using NghiaVoBlog.Data;
using NghiaVoBlog.Dto.Article;
using NghiaVoBlog.Models;
using NghiaVoBlog.Repository;

namespace NghiaVoBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleRepository _articleRepository;
        public ArticleController(ArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        [HttpPost]
        public IActionResult AddArticle(CreateArticleDto CreateArticleDto)
        {
            if (ModelState.IsValid)
            {
                var article = new Article()
                {
                    Title = CreateArticleDto.Title,
                    Content = CreateArticleDto.Content,
                    ViewCount = CreateArticleDto.ViewCount,
                    AuthorID = CreateArticleDto.AuthorID,
                    CategoryID = CreateArticleDto.CategoryID
                };
                var createArticle = _articleRepository.InsertArticle(article);
                return Ok(createArticle);

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetListArticle()
        {
            var listArticle = await _articleRepository.GetListArticle();
            return Ok(listArticle);
        }

        [HttpPut]
        public async Task<IActionResult> PutArticle([FromQuery] Guid Id,PutArticleDto putArticleDto)
        {
            if (ModelState.IsValid)
            {
                var articleNew = new Article()
                {
                    Title = putArticleDto.Title,
                    Content = putArticleDto.Content,
                    ViewCount = putArticleDto.ViewCount,
                    AuthorID = putArticleDto.AuthorID,
                    CategoryID = putArticleDto.CategoryID
                };
                return Ok(await _articleRepository.EditArticle(Id, articleNew));

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteArticle([FromQuery] Guid id)
        {
            return Ok(await _articleRepository.DeleteArticle(id));
        }


    }
}