using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Dtos.Editor.Galeries;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.Services.Abstract
{
    public interface IGaleryService
    {
        Task<IDataResult<GaleryDto>> GetAsync(int galeryId);
        Task<IDataResult<GaleryListDto>> GetAllAsync();
        Task<IDataResult<GaleryDto>> AddAsync(GaleryAddDto galeryAddDto, string createByName);
        Task<IDataResult<GaleryDto>> UpdateAsync(GaleryUpdateDto galeryUpdateDto, string modifiedByName);
        Task<IDataResult<GaleryUpdateDto>> GetGaleryUpdateDtoAsync(int galeryId);
        Task<IResult> HardDeleteAsync(int galeryId);    
    }
}
