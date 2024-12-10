using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Editor;

namespace TigrisTech.Data.Concrete.EntityFramework.Mappings.Editor
{
    public class ProfilMap : IEntityTypeConfiguration<Profil>
    {
        public void Configure(EntityTypeBuilder<Profil> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.FirstName).HasMaxLength(20);
            builder.Property(a => a.FirstName).IsRequired(true);

            builder.Property(a => a.LastName).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(20);

            builder.Property(a => a.Picture).IsRequired();
            builder.Property(a => a.Picture).HasMaxLength(250);

            builder.Property(a => a.Email).HasMaxLength(50);

            builder.Property(a => a.Phone).HasMaxLength(13);

            builder.Property(a => a.Address).HasMaxLength(150);

            builder.Property(a => a.TcNo).HasMaxLength(70);


            // Social Media Links
            builder.Property(u => u.YoutubeLink).HasMaxLength(250);
            builder.Property(u => u.TwitterLink).HasMaxLength(250);
            builder.Property(u => u.InstagramLink).HasMaxLength(250);
            builder.Property(u => u.FacebookLink).HasMaxLength(250);
            builder.Property(u => u.LinkedInLink).HasMaxLength(250);
            builder.Property(u => u.GitHubLink).HasMaxLength(250);
            builder.Property(u => u.WebsiteLink).HasMaxLength(250);
            builder.Property(a => a.CreateByName).IsRequired();
            builder.Property(a => a.CreateByName).HasMaxLength(250);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(250);
            builder.Property(a => a.CreateDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();        
            builder.ToTable("Profils");
            builder.HasData(
                new Profil
                {
                    Id = 1,
                    Email = "dtEmin@gmail.com",
                    Phone = "+905555555555",
                    Picture = "/profilImages/defaultProfil.jpg",
                    FirstName = "Emin",
                    LastName = "Kara",
                    Address = "Gül Tepe Mah.",
                    TcNo = "11111111111",
                    TwitterLink = "https://twitter.com/alikara",
                    InstagramLink = "https://instagram.com/alikara",
                    YoutubeLink = "https://youtube.com/alikara",
                    GitHubLink = "https://github.com/alikara",
                    LinkedInLink = "https://linkedin.com/alikara",
                    WebsiteLink = "https://programmersblog.com/",
                    FacebookLink = "https://facebook.com/alikara",
                    IsActive = true,
                    IsDeleted = false,
                    CreateByName = "InitialCreate",
                    CreateDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                },
                 new Profil
                 {
                     Id = 2,
                     Email = "nurcan@gmail.com",
                     Phone = "+905555555555",
                     Picture = "/profilImages/defaultProfil.jpg",
                     FirstName = "Nurcan",
                     LastName = "Güneş",
                     Address = "Gül Tepe Mah.",
                     TcNo = "11111111111",
                     TwitterLink = "https://twitter.com/fatmagunus",
                     InstagramLink = "https://instagram.com/fatmagunus",
                     YoutubeLink = "https://youtube.com/fatmagunus",
                     GitHubLink = "https://github.com/fatmagunus",
                     LinkedInLink = "https://linkedin.com/fatmagunus",
                     WebsiteLink = "https://programmersblog.com/",
                     FacebookLink = "https://facebook.com/fatmagunus",
                     IsActive = true,
                     IsDeleted = false,
                     CreateByName = "InitialCreate",
                     CreateDate = DateTime.Now,
                     ModifiedByName = "InitialCreate",
                     ModifiedDate = DateTime.Now,
                 },
                  new Profil
                  {
                      Id = 3,
                      Email = "Aslı@gmail.com",
                      Phone = "+905555555555",
                      Picture = "/profilImages/defaultProfil.jpg",
                      FirstName = "Aslı",
                      LastName = "Tekin",
                      Address = "Gül Tepe Mah.",
                      TcNo = "11111111111",
                      TwitterLink = "https://twitter.com/fatmagunus",
                      InstagramLink = "https://instagram.com/fatmagunus",
                      YoutubeLink = "https://youtube.com/fatmagunus",
                      GitHubLink = "https://github.com/fatmagunus",
                      LinkedInLink = "https://linkedin.com/fatmagunus",
                      WebsiteLink = "https://programmersblog.com/",
                      FacebookLink = "https://facebook.com/fatmagunus",
                      IsActive = true,
                      IsDeleted = false,
                      CreateByName = "InitialCreate",
                      CreateDate = DateTime.Now,
                      ModifiedByName = "InitialCreate",
                      ModifiedDate = DateTime.Now,
                  });
        }
    }
}
