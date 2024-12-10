

using TigrisTech.Entities.Dtos.Blog;

namespace TigrisTech.MvcUI.Models
{
    public class CommentAddAjaxViewModel
    {
        public CommentAddDto CommentAddDto { get; set; }
        public CommentDto CommentDto { get; set; }
        public string CommentAddPartial { get; set; }
    }
}
