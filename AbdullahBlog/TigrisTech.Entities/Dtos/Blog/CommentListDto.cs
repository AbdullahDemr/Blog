using System.Collections.Generic;
using TigrisTech.Entities.Concrete.Blog;

namespace TigrisTech.Entities.Dtos.Blog
{
    public class CommentListDto
    {
        public IList<Comment> Comments { get; set; }
    }
}
