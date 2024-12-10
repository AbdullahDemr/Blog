using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Entities.Dtos.Blog;


namespace TigrisTech.MvcUI.Models
{
    public class ArticleDetailRightSideBarViewModel
    {
        public string Header { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public User User { get; set; }
    }
}
