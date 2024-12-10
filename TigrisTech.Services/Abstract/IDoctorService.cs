using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Dtos.Editor.Galeries;
using TigrisTech.Entities.Dtos.Editor.References;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.Services.Abstract
{
    public interface IDoctorService
    {
        Task<IDataResult<TeamDto>> GetAsync(int refenceId);
        Task<IDataResult<TeamListDto>> GetAllAsync();
        Task<IDataResult<TeamDto>> AddAsync(TeamAddDto refenceAddDto, string createByName);
        Task<IDataResult<TeamDto>> UpdateAsync(TeamUpdateDto refenceUpdateDto, string modifiedByName);
        Task<IDataResult<TeamUpdateDto>> GetGaleryUpdateDtoAsync(int refenceId);
        Task<IResult> HardDeleteAsync(int refenceId);
    }
}
