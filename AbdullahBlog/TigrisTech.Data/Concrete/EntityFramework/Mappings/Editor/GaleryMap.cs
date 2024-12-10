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
    public class GaleryMap : IEntityTypeConfiguration<Galery>
    {
        public void Configure(EntityTypeBuilder<Galery> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);

            builder.Property(a => a.CreateByName).IsRequired();
            builder.Property(a => a.CreateByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreateDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();

            builder.ToTable("Galeries");

            builder.HasData(
                new Galery
                {
                    Id = 1,
                    Title = "Galery  1",
                    Description = "Diş Hastanemiz Lab kısmı",
                    Picture = "/galeryImages/defaultGalery.jpg",
                    IsActive = true,
                    IsDeleted = false,
                    CreateByName = "InitialCreate",
                    CreateDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,

                },
                new Galery
                {
                    Id = 2,
                    Title = "Galery  2",
                    Description = "Diş Hastanemiz bekleme kısmı",
                    Picture = "/galeryImages/defaultGalery.jpg",
                    IsActive = true,
                    IsDeleted = false,
                    CreateByName = "InitialCreate",
                    CreateDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                },
                new Galery
                {
                    Id = 3,
                    Title = "Galery  3",
                    Description = "Diş Hastanemiz tedavi bölümü",
                    Picture = "/galeryImages/defaultGalery.jpg",
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

