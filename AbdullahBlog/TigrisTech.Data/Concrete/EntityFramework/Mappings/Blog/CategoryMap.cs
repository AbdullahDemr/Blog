using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Blog;

namespace TigrisTech.Data.Concrete.EntityFramework.Mappings.Blog
{

        public class CategoryMap : IEntityTypeConfiguration<Category>
        {
            public void Configure(EntityTypeBuilder<Category> builder)
            {
                builder.HasKey(c => c.Id);
                builder.Property(c => c.Id).ValueGeneratedOnAdd();
                builder.Property(c => c.Name).IsRequired();
                builder.Property(c => c.Name).HasMaxLength(70);
                builder.Property(c => c.Description).HasMaxLength(500);
                builder.Property(c => c.CreateByName).IsRequired();
                builder.Property(c => c.CreateByName).HasMaxLength(50);
                builder.Property(c => c.ModifiedByName).IsRequired();
                builder.Property(c => c.ModifiedByName).HasMaxLength(50);
                builder.Property(c => c.CreateDate).IsRequired();
                builder.Property(c => c.ModifiedDate).IsRequired();
                builder.Property(c => c.IsActive).IsRequired();
                builder.Property(c => c.IsDeleted).IsRequired();
                builder.ToTable("Categories");

                builder.HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "C#",
                        Description = "C# Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "C++",
                        Description = "C++ Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    },

                    new Category
                    {
                        Id = 3,
                        Name = "JavaScript",
                        Description = "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "Typescript",
                        Description = "Typescript Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    }
                    ,
                    new Category
                    {
                        Id = 5,
                        Name = "Java",
                        Description = "Java Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,

                    }
                    ,
                    new Category
                    {
                        Id = 6,
                        Name = "Python",
                        Description = "Python Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    }
                    ,
                    new Category
                    {
                        Id = 7,
                        Name = "Php",
                        Description = "Php Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    }
                    ,
                    new Category
                    {
                        Id = 8,
                        Name = "Kotlin",
                        Description = "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    }
                    ,
                    new Category
                    {
                        Id = 9,
                        Name = "Swift",
                        Description = "Swift Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    }
                    ,
                    new Category
                    {
                        Id = 10,
                        Name = "Ruby",
                        Description = "Ruby Programlama Dili ile İlgili En Güncel Bilgiler",
                        IsActive = true,
                        IsDeleted = false,
                        CreateByName = "InitialCreate",
                        CreateDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                    }
                );
            }
        }
}
