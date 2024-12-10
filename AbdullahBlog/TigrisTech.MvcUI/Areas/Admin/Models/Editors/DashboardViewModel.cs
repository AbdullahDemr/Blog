using TigrisTech.Entities.Dtos.Blog;

namespace TigrisTech.MvcUI.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public int CategoriesCount { get; set; }
        public int ArticlesCount { get; set; }
        public int CommentCount { get; set; }
        public int UserCount { get; set; }
        public ArticleListDto Articles { get; set; }
    }
}
