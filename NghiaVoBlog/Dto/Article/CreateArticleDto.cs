using System.ComponentModel.DataAnnotations;

namespace NghiaVoBlog.Dto.Article
{
    public class CreateArticleDto
    {
        [Required(ErrorMessage = "Title khong the bo trong")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Content khong the bo trong")]
        public String Content { get; set; }
        public String ViewCount { get; set; }
        [Required(ErrorMessage = "AuthorID khong the bo trong")]
        public Guid AuthorID { get; set; }
        [Required(ErrorMessage = "CategoryID khong the bo trong")]
        public Guid CategoryID { get; set; }
    }
}