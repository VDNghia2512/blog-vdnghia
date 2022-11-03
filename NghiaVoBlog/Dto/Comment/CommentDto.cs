using System.ComponentModel.DataAnnotations;

namespace NghiaVoBlog.Dto.Comment
{
    public class CommentDto
    {
        public Guid ID{ get; set;}
        public String Content { get; set; }
        public Guid AuthorID  { get; set; }
        public Guid ArticleID  { get; set; }
    }
}