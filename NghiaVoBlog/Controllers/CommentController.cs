using Microsoft.AspNetCore.Mvc;
using NghiaVoBlog.Data;
using NghiaVoBlog.Dto.Comment;
using NghiaVoBlog.Models;
using NghiaVoBlog.Repository;

namespace NghiaVoBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly CommentRepository _commentRepository;
        public CommentController(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        [HttpPost]
        public IActionResult AddComment(CreateCommentDto createCommentDto)
        {
            if (ModelState.IsValid)
            {
                var comment = new Comment()
                {
                    Content = createCommentDto.Content,
                    AuthorID = createCommentDto.AuthorID,
                    ArticleID = createCommentDto.ArticleID
                };
                var createComment = _commentRepository.InsertComment(comment);
                return Ok(createComment);

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetListComment()
        {
            var listComment = await _commentRepository.GetListComment();
            return Ok(listComment);
        }

        [HttpPut]
        public async Task<IActionResult> PutComment([FromQuery] Guid Id,PutCommentDto putCommentDto)
        {
            if (ModelState.IsValid)
            {
                var commentNew = new Comment()
                {
                    Content = putCommentDto.Content,
                    AuthorID = putCommentDto.AuthorID,
                    ArticleID = putCommentDto.ArticleID
                };
                return Ok(await _commentRepository.EditComment(Id, commentNew));

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteComment([FromQuery] Guid id)
        {
            return Ok(await _commentRepository.DeleteComment(id));
        }


    }
}