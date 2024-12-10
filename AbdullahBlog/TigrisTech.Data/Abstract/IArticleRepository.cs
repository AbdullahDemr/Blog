using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Shared.Data.Abstract;

namespace TigrisTech.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
    }
}
