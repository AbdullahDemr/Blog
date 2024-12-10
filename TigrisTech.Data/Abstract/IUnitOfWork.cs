using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TigrisTech.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; }//unitofwork.Articles
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IProfilRepository Profils { get; }
        ISliderRepository Sliders { get; }
        IGaleryRepository Galerys { get; }
        IDoctorRepository References { get; }
        Task<int> SaveAsync();
    }
}
