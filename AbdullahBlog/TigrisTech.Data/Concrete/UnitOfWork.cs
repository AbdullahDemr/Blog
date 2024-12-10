using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Data.Concrete.EntityFramework.Contexts;
using TigrisTech.Data.Concrete.EntityFramework.Repositories;
using TigrisTech.Data.Concrete.Repositories;

namespace TigrisTech.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TigrisContext _tigrisContext;
        private ArticleRepository _articleRepository;
        private CategoryRepository _categoryRepository;
        private CommentRepository _commentRepository;
        private ProfilRepository _profilRepository;
        private SliderRepository _sliderRepository;
        private GaleryRepository _galeryRepository;
        private DoctorRepository _refenceRepository;


        public UnitOfWork(TigrisContext tigrisContext)
        {
            _tigrisContext = tigrisContext;
        }
        public IArticleRepository Articles => _articleRepository ??= new ArticleRepository(_tigrisContext);

        public ICategoryRepository Categories => _categoryRepository ??= new CategoryRepository(_tigrisContext);

        public ICommentRepository Comments => _commentRepository ??= new CommentRepository(_tigrisContext);
        public IProfilRepository Profils => _profilRepository ??= new ProfilRepository(_tigrisContext);

        public ISliderRepository Sliders => _sliderRepository ??= new SliderRepository(_tigrisContext);

        public IGaleryRepository Galerys => _galeryRepository ??= new GaleryRepository(_tigrisContext);

        public IDoctorRepository References => _refenceRepository ??= new DoctorRepository(_tigrisContext);

        public async Task<int> SaveAsync()
        {
            return await _tigrisContext.SaveChangesAsync();
        }
        public async ValueTask DisposeAsync()
        {
            await _tigrisContext.DisposeAsync();
        }
    }
}
