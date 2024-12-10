using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Dtos.Editor.Profils;
using TigrisTech.Services.Abstract;
using TigrisTech.Services.Utilities;
using TigrisTech.Shared.Utilities.Results.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;
using TigrisTech.Shared.Utilities.Results.Concrete;

namespace TigrisTech.Services.Concrete
{
    public class ProfilManager :ManagerBase, IProfilService
    {
        public ProfilManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<ProfilDto>> GetAsync(int profilId)
        {
            var profil = await UnitOfWork.Profils.GetAsync(p => p.Id == profilId);
            if(profil != null)
            {
                return new DataResult<ProfilDto>(ResultStatus.Success, new ProfilDto
                {
                    Profil = profil,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProfilDto>(ResultStatus.Error, "Böyle bir profil bulunamadı.", null);
        }
        public async Task<IDataResult<ProfilListDto>> GetAllAsync()
        {
            var profils = await UnitOfWork.Profils.GetAllAsync();
            if(profils != null)
            {
                return new DataResult<ProfilListDto>(ResultStatus.Success, new ProfilListDto
                {
                    Profils = profils,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProfilListDto>(ResultStatus.Error, "Herhangi bir kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<ProfilDto>> AddAsync(ProfilAddDto profilAddDto, string createByName)
        {
            var profil = Mapper.Map<Profil>(profilAddDto);
            profil.CreateByName = createByName;
            profil.ModifiedByName = createByName;
            var addedProfil = await UnitOfWork.Profils.AddSync(profil);
            await UnitOfWork.SaveAsync();
            return new DataResult<ProfilDto>(ResultStatus.Success, Messages.Profil.Add(addedProfil.FirstName), new ProfilDto
            {
                Profil = addedProfil,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Slider.Add(addedProfil.FirstName)
            });
        }

        public async Task<IDataResult<ProfilDto>> UpdateAsync(ProfilUpdateDto profilUpdateDto, string modifiedByName)
        {
            var oldProfil = await UnitOfWork.Profils.GetAsync(s => s.Id == profilUpdateDto.Id);

            var profil = Mapper.Map<ProfilUpdateDto, Profil>(profilUpdateDto, oldProfil);
            profil.ModifiedByName = modifiedByName;
            var updateProfil = await UnitOfWork.Profils.UpdateAsync(profil);
            await UnitOfWork.SaveAsync();
            return new DataResult<ProfilDto>(ResultStatus.Success, Messages.Profil.Update(updateProfil.FirstName), new ProfilDto
            {
                Profil = updateProfil,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Slider.Update(updateProfil.FirstName)
            });
        }

        public async Task<IDataResult<ProfilUpdateDto>> GetProfilUpdateDtoAsync(int profilId)
        {
            var result = await UnitOfWork.Profils.AnyAsync(s => s.Id == profilId);
            if (result)
            {
                var profil = await UnitOfWork.Profils.GetAsync(c => c.Id == profilId);
                var profilUpdateDto = Mapper.Map<ProfilUpdateDto>(profil);
                return new DataResult<ProfilUpdateDto>(ResultStatus.Success, profilUpdateDto);
            }
            else
            {
                return new DataResult<ProfilUpdateDto>(ResultStatus.Error, Messages.Slider.NotFound(isPlural: false), null);
            }
        }

        public async Task<IResult> HardDeleteAsync(int proiflId)
        {
            var profil = await UnitOfWork.Profils.GetAsync(c => c.Id == proiflId);
            if (profil != null)
            {
                await UnitOfWork.Profils.DeleteAsync(profil);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Profil.HardDelete(profil.FirstName));
            }
            return new Result(ResultStatus.Success, Messages.Profil.NotFound(isPlural: true));
        }
    }
}
