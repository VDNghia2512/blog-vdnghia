using NghiaVoBlog.Data;
using NghiaVoBlog.Dto.Comment;
using NghiaVoBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace NghiaVoBlog.Repository
{
    public class CommentRepository
    {
        private readonly AppDBContext _context;
        public CommentRepository(AppDBContext context)
        {
            _context = context;
        }
        public CommentDto InsertComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
            var result = new CommentDto()
            {
                ID = comment.ID,
                Content = comment.Content,
                AuthorID = comment.AuthorID,
                ArticleID = comment.ArticleID
            };
            return result;
        }
        public async Task<List<CommentDto>> GetListComment()
        {
            try
            {
                var result = await _context.Comments.AsNoTracking().Select(comment => new CommentDto()
                {
                    Content = comment.Content,
                    ID = comment.ID,
                    AuthorID = comment.AuthorID,
                    ArticleID = comment.ArticleID
                }).ToListAsync();
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteComment(Guid Id)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(comment => comment.ID == Id);

            if (comment == null)
            {
                return false;
            };

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return true;

        }


        public async Task<CommentDto> EditComment(Guid Id, Comment commentNew)
        {

            var commentExist = await _context.Comments.FirstOrDefaultAsync(comment => comment.ID == Id);

            if (commentExist == null)
            {
                return null;
            };
            
            commentExist.Content = commentNew.Content;
            commentExist.AuthorID = commentNew.AuthorID;
            commentExist.ArticleID = commentNew.ArticleID;
            await _context.SaveChangesAsync();

            return new CommentDto()
            {
                ID = commentExist.ID,
                Content = commentExist.Content,
                AuthorID = commentExist.AuthorID,
                ArticleID = commentExist.ArticleID,
            };
        }
    }
}