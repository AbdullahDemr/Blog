using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using TigrisTech.Entities.ComplexTypes;
using TigrisTech.Entities.Dtos.Editor.Images;
using TigrisTech.Shared.Utilities.Results.Abstract;

namespace TigrisTech.MvcUI.Helpers.Abstract
{
    public interface IImageHelper
    {
        string Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        Task<IDataResult<ImageUploadedDto>> UploadTask(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
