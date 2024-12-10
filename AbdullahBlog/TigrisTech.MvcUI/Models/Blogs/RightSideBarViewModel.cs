using System.Collections.Generic;
using TigrisTech.Entities.Concrete.Blog;

namespace TigrisTech.MvcUI.Models
{
    public class RightSideBarViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
