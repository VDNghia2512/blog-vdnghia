using NghiaVoBlog.Data;
using NghiaVoBlog.Dto.Article;
using NghiaVoBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace NghiaVoBlog.Repository
{
    public class ArticleRepository
    {
        private readonly AppDBContext _context;
        public ArticleRepository(AppDBContext context)
        {
            _context = context;
        }
        public ArticleDto InsertArticle(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
            var result = new ArticleDto()
            {
                Title = article.Title,
                Content = article.Content,
                ViewCount = article.ViewCount,
                AuthorID = article.AuthorID,
                CategoryID = article.CategoryID
            };
            return result;
        }
        public async Task<List<ArticleDto>> GetListArticle()
        {
            try
            {
                var result = await _context.Articles.AsNoTracking().Select(article => new ArticleDto()
                {
                    Title = article.Title,
                    Content = article.Content,
                    ViewCount = article.ViewCount,
                    ID = article.ID,
                    AuthorID = article.AuthorID,
                    CategoryID = article.CategoryID
                }).ToListAsync();
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteArticle(Guid Id)
        {
            var article = await _context.Articles.FirstOrDefaultAsync(article => article.ID == Id);

            if (article == null)
            {
                return false;
            };

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return true;

        }


        public async Task<ArticleDto> EditArticle(Guid Id, Article articleNew)
        {

            var articleExist = await _context.Articles.FirstOrDefaultAsync(article => article.ID == Id);

            if (articleExist == null)
            {
                return null;
            };
            
            articleExist.Title = articleNew.Title;
            articleExist.Content = articleNew.Content;
            articleExist.ViewCount = articleNew.ViewCount;
            articleExist.AuthorID = articleNew.AuthorID;
            articleExist.CategoryID = articleNew.CategoryID;
            await _context.SaveChangesAsync();

            return new ArticleDto()
            {
                ID = articleExist.ID,
                Title = articleExist.Title,
                Content = articleExist.Content,
                ViewCount = articleExist.ViewCount,
                AuthorID = articleExist.AuthorID,
                CategoryID = articleExist.CategoryID,
            };
        }
    }
}