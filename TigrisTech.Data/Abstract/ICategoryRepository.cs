using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Shared.Data.Abstract;

namespace TigrisTech.Data.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        Task<Category> GetByIdAsync(int categoryId);
    }
}
