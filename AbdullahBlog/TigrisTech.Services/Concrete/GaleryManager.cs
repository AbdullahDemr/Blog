using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Dtos.Editor.Galeries;
using TigrisTech.Services.Abstract;
using TigrisTech.Services.Utilities;
using TigrisTech.Shared.Utilities.Results.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;
using TigrisTech.Shared.Utilities.Results.Concrete;

namespace TigrisTech.Services.Concrete
{
    public class GaleryManager :ManagerBase, IGaleryService
    {
        public GaleryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IDataResult<GaleryDto>> GetAsync(int galeryId)
        {
            var galery = await UnitOfWork.Galerys.GetAsync(g => g.Id == galeryId);
            if(galery != null)
            {
                return new DataResult<GaleryDto>(ResultStatus.Success, new GaleryDto
                {
                    Galery = galery,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<GaleryDto>(ResultStatus.Error, "Böyle bir galeri bulunamadı.", null);
        }
        public async Task<IDataResult<GaleryListDto>> GetAllAsync()
        {
            var galerys = await UnitOfWork.Galerys.GetAllAsync();
            if( galerys != null)
            {
                return new DataResult<GaleryListDto>(ResultStatus.Success, new GaleryListDto
                {
                    Galeries = galerys,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<GaleryListDto>(ResultStatus.Error, "Herhangi bir galeri bulunamdı.", null);
        }
        public async Task<IDataResult<GaleryDto>> AddAsync(GaleryAddDto galeryAddDto, string createByName)
        {
            var galery = Mapper.Map<Galery>(galeryAddDto);
            galery.CreateByName = createByName;
            galery.ModifiedByName = createByName;
            var addedGalery = await UnitOfWork.Galerys.AddSync(galery);
            await UnitOfWork.SaveAsync();
            return new DataResult<GaleryDto>(ResultStatus.Success, Messages.Galery.Add(addedGalery.Title), new GaleryDto
            {
                Galery = addedGalery,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Galery.Add(addedGalery.Title)
            });
        }

        public async Task<IDataResult<GaleryUpdateDto>> GetGaleryUpdateDtoAsync(int galeryId)
        {
            var result = await UnitOfWork.Galerys.AnyAsync(g => g.Id == galeryId);
            if (result)
            {
                var galery = await UnitOfWork.Galerys.GetAsync(g => g.Id == galeryId);
                var galeryUpdateDto = Mapper.Map<GaleryUpdateDto>(galery);
                return new DataResult<GaleryUpdateDto>(ResultStatus.Success, galeryUpdateDto);
            }
            else
            {
                return new DataResult<GaleryUpdateDto>(ResultStatus.Error, Messages.Galery.NotFound(isPlural:false),null);
            }
        }

        public async Task<IDataResult<GaleryDto>> UpdateAsync(GaleryUpdateDto galeryUpdateDto, string modifiedByName)
        {
            var oldGalery = await UnitOfWork.Galerys.GetAsync(g=>g.Id == galeryUpdateDto.Id);

            var galery = Mapper.Map<GaleryUpdateDto, Galery>(galeryUpdateDto, oldGalery);
            galery.ModifiedByName = modifiedByName;
            var updateGalery = await UnitOfWork.Galerys.UpdateAsync(galery);
            await UnitOfWork.SaveAsync();
            return new DataResult<GaleryDto>(ResultStatus.Success, Messages.Galery.Update(updateGalery.Title), new GaleryDto
            {
                Galery = updateGalery,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Galery.Update(updateGalery.Title)
            });
        }

        public async Task<IResult> HardDeleteAsync(int galeryId)
        {
            var galery = await UnitOfWork.Galerys.GetAsync(g => g.Id == galeryId);
            if(galery != null)
            {
                await UnitOfWork.Galerys.DeleteAsync(galery);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Galery.HardDelete(galery.Title));
            }
            return new Result(ResultStatus.Success, Messages.Galery.NotFound(isPlural: true));
        }
    }
}
