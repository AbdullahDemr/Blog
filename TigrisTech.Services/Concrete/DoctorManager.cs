using AutoMapper;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Data.Concrete;
using TigrisTech.Entities.Dtos.Editor.Galeries;
using TigrisTech.Entities.Dtos.Editor.References;
using TigrisTech.Services.Abstract;
using TigrisTech.Shared.Utilities.Results.Abstract;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;
using TigrisTech.Shared.Utilities.Results.Concrete;

namespace TigrisTech.Services.Concrete
{
    public class DoctorManager :ManagerBase, IDoctorService
    {
        public DoctorManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public Task<IDataResult<TeamDto>> AddAsync(TeamAddDto refenceAddDto, string createByName)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IDataResult<TeamListDto>> GetAllAsync()
        {
            var references = await UnitOfWork.References.GetAllAsync();
            if (references != null)
            {
                return new DataResult<TeamListDto>(ResultStatus.Success, new TeamListDto
                {
                    Doctors = references,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<TeamListDto>(ResultStatus.Error, "Herhangi bir referans bulunamdı.", new TeamListDto
            {
                Doctors = null,
                ResultStatus = ResultStatus.Error
            });
        }

        public Task<IDataResult<TeamDto>> GetAsync(int refenceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IDataResult<TeamUpdateDto>> GetGaleryUpdateDtoAsync(int refenceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResult> HardDeleteAsync(int refenceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IDataResult<TeamDto>> UpdateAsync(TeamUpdateDto refenceUpdateDto, string modifiedByName)
        {
            throw new System.NotImplementedException();
        }
    }
}
