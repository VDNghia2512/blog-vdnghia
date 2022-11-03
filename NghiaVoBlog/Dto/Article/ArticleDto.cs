using System.ComponentModel.DataAnnotations;

namespace NghiaVoBlog.Dto.Article
{
    public class ArticleDto
    {
        public Guid ID{ get; set;}
        public String Title { get; set; }
        public String Content { get; set; }
        public String ViewCount { get; set; }
        public Guid AuthorID { get; set; }
        public Guid CategoryID { get; set; }
    }
}