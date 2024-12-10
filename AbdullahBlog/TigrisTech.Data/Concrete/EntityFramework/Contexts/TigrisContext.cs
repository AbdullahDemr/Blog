using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Concrete.EntityFramework.Mappings.Blog;
using TigrisTech.Data.Concrete.EntityFramework.Mappings.Editor;
using TigrisTech.Data.Concrete.EntityFramework.Mappings.Users;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Concrete.UserTable;

namespace TigrisTech.Data.Concrete.EntityFramework.Contexts
{
    public class TigrisContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public TigrisContext(DbContextOptions<TigrisContext> options):base(options)
        {

        }
        public DbSet<Galery> Galeries { get; set; }
        public DbSet<Profil> Profils { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {           
            //User
            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserClaimMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new UserTokenMap());
            builder.ApplyConfiguration(new LogoMap());

            //Editor
            builder.ApplyConfiguration(new GaleryMap());
            builder.ApplyConfiguration(new ProfilMap());
            builder.ApplyConfiguration(new SliderMap());

            //Blog
            builder.ApplyConfiguration(new ArticleMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new CommentMap());

            //Yeni Tablolar
            builder.ApplyConfiguration(new DoctorMap());
            base.OnModelCreating(builder);
        }
    }
}
