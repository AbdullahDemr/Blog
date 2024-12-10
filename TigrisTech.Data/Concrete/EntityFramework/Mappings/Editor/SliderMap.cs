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
    public class SliderMap : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
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
        
            builder.ToTable("Sldiers");

            builder.HasData(
                new Slider
                {
                    Id = 1,
                    Title = "Diş  Temizleme",
                    IsActive = true,
                    IsDeleted = false,
                    Picture = "/sliderImages/defaultSlider.jpg",
                    CreateByName = "InitialCreate",
                    CreateDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,

                },
                new Slider
                {
                    Id = 2,
                    Title = "Diş  İplant",
                    IsActive = true,
                    IsDeleted = false,
                    CreateByName = "InitialCreate",
                    CreateDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                },
                new Slider
                {
                    Id = 3,
                    Title = "Diş  Zirkonyum",
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
