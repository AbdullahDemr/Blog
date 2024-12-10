using System.Collections.Generic;
using System.Threading.Tasks;
using TigrisTech.Entities.Dtos.Blog;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        //Silinmemiş tüm kategorileri bana getir.
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();
        //hem silinmemiş hemde aktiv olan
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync();
        //Silinmiş tüm değerler listele
        Task<IDataResult<CategoryListDto>> GetAllByDeletedAsync();
        //Dto Veri Transfer Objesi
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto, string createByName);
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName);
        //silme işlemini geri al
        Task<IDataResult<CategoryDto>> UndoDeleteAsync(int categoryId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int categoryId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
