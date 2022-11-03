using System.ComponentModel.DataAnnotations;

namespace NghiaVoBlog.Dto.Comment
{
    public class CreateCommentDto
    {
        [Required(ErrorMessage = "Content khong the bo trong")]
        public String Content { get; set; }
        [Required(ErrorMessage = "AuthorID khong the bo trong")]
        public Guid AuthorID  { get; set; }
        [Required(ErrorMessage = "ArticleID khong the bo trong")]
        public Guid ArticleID  { get; set; }
    }
}