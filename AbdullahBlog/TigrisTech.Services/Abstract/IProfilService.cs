using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Dtos.Editor.Profils;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.Services.Abstract
{
    public interface IProfilService
    {
        Task<IDataResult<ProfilDto>> GetAsync(int profilId);
        Task<IDataResult<ProfilListDto>> GetAllAsync();

        Task<IDataResult<ProfilDto>> AddAsync(ProfilAddDto profilAddDto, string createByName);
        Task<IDataResult<ProfilDto>> UpdateAsync(ProfilUpdateDto profilUpdateDto, string modifiedByName);
        Task<IDataResult<ProfilUpdateDto>> GetProfilUpdateDtoAsync(int profilId);
        Task<IResult> HardDeleteAsync(int proiflId);
    }
}
