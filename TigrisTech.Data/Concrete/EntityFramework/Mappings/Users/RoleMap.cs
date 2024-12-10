using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.UserTable;


namespace TigrisTech.Data.Concrete.EntityFramework.Mappings.Users
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasDatabaseName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("Roles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(100);
            builder.Property(u => u.NormalizedName).HasMaxLength(100);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(
                //Category
                new Role{Id = 1,Name = "Category.Create",NormalizedName = "CATEGORY.CREATE",ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                new Role{Id = 2, Name = "Category.Read", NormalizedName = "CATEGORY.READ", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role{ Id = 3, Name = "Category.Update", NormalizedName = "CATEGORY.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role{Id = 4,Name = "Category.Delete",NormalizedName = "CATEGORY.DELETE",ConcurrencyStamp = Guid.NewGuid().ToString()},
                //Article
                new Role{ Id = 5, Name = "Article.Create", NormalizedName = "ARTICLE.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role{ Id = 6, Name = "Article.Read", NormalizedName = "ARTICLE.READ", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role { Id = 7, Name = "Article.Update", NormalizedName = "ARTICLE.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                new Role { Id = 8, Name = "Article.Delete", NormalizedName = "ARTICLE.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                //User
                new Role { Id = 9,  Name = "User.Create", NormalizedName = "USER.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString()} ,
                new Role{ Id = 10, Name = "User.Read",  NormalizedName = "USER.READ",  ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role { Id = 11, Name = "User.Update", NormalizedName = "USER.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role{ Id = 12, Name = "User.Delete", NormalizedName = "USER.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Role
                new Role{Id = 13, Name = "Role.Create", NormalizedName = "ROLE.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role{ Id = 14, Name = "Role.Read", NormalizedName = "ROLE.READ", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role { Id = 15,  Name = "Role.Update",  NormalizedName = "ROLE.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                new Role {  Id = 16,  Name = "Role.Delete",  NormalizedName = "ROLE.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Comment
                new Role{Id = 17, Name = "Comment.Create", NormalizedName = "COMMENT.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() }  ,
                new Role { Id = 18, Name = "Comment.Read", NormalizedName = "COMMENT.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 19, Name = "Comment.Update", NormalizedName = "COMMENT.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString()} ,
                new Role {Id = 20, Name = "Comment.Delete", NormalizedName = "COMMENT.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //AdminArea.Home.Read
                new Role {  Id = 21, Name = "AdminArea.Home.Read", NormalizedName = "ADMINAREA.HOME.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //SuperAdmin
                new Role { Id = 22, Name = "SuperAdmin", NormalizedName = "SUPERADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                //Role
                new Role { Id = 23, Name = "Profil.Read", NormalizedName = "PROFIL.READ",ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                new Role {  Id = 24,Name = "Profil.Create", NormalizedName = "PROFIL.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString()} ,
                new Role { Id = 25, Name = "Profil.Update",  NormalizedName = "PROFIL.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                new Role {  Id = 26,Name = "Profil.Delete", NormalizedName = "PROFIL.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                //Slider
                new Role{Id = 27, Name = "Slider.Read",NormalizedName = "SLIDER.READ",ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                new Role{ Id = 28, Name = "Slider.Create", NormalizedName = "SLIDER.CREATE",ConcurrencyStamp = Guid.NewGuid().ToString() } ,
                new Role{Id = 29, Name = "Slider.Update", NormalizedName = "SLIDER.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString()} ,
                new Role{ Id = 30, Name = "Slider.Delete",NormalizedName = "SLIDER.DELETE",ConcurrencyStamp = Guid.NewGuid().ToString()},
                //Galery
                new Role { Id = 31, Name = "Galery.Read", NormalizedName = "GALERY.READ", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role { Id = 32, Name = "Galery.Create", NormalizedName = "GALERY.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role { Id = 33, Name = "Galery.Update", NormalizedName = "GALERY.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString()},
                new Role { Id = 34, Name = "Galery.Delete", NormalizedName = "GALERY.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString()},
                //AccountCode
                new Role { Id = 35, Name = "AccountCode.Read", NormalizedName = "ACCOUNTCODE.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 36, Name = "AccountCode.Create", NormalizedName = "ACCOUNTCODE.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 37, Name = "AccountCode.Update", NormalizedName = "ACCOUNTCODE.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 38, Name = "AccountCode.Delete", NormalizedName = "ACCOUNTCODE.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Appointment
                new Role { Id = 39, Name = "Appointment.Read", NormalizedName = "APPOINTMENT.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 40, Name = "Appointment.Create", NormalizedName = "APPOINTMENT.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 41, Name = "Appointment.Update", NormalizedName = "APPOINTMENT.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 42, Name = "Appointment.Delete", NormalizedName = "APPOINTMENT.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //AppointmentState
                new Role { Id = 43, Name = "AppointmentState.Read", NormalizedName = "APPOINTMENTSTATE.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 44, Name = "AppointmentState.Create", NormalizedName = "APPOINTMENTSTATE.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 45, Name = "AppointmentState.Update", NormalizedName = "APPOINTMENTSTATE.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 46, Name = "AppointmentState.Delete", NormalizedName = "APPOINTMENTSTATE.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //ExpendeInCome
                new Role { Id = 47, Name = "ExpendeInCome.Read", NormalizedName = "EXPENDEINCOME.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 48, Name = "ExpendeInCome.Create", NormalizedName = "EXPENDEINCOME.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 49, Name = "ExpendeInCome.Update", NormalizedName = "EXPENDEINCOME.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 50, Name = "ExpendeInCome.Delete", NormalizedName = "EXPENDEINCOME.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },               
                //PaymentMove
                new Role { Id = 51, Name = "PaymentMove.Read", NormalizedName = "PAYMENTMOVE.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 52, Name = "PaymentMove.Create", NormalizedName = "PAYMENTMOVE.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 53, Name = "PaymentMove.Update", NormalizedName = "PAYMENTMOVE.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 54, Name = "PaymentMove.Delete", NormalizedName = "PAYMENTMOVE.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //PaymentType
                new Role { Id = 55, Name = "PaymentType.Read", NormalizedName = "PAYMENTTYPE.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 56, Name = "PaymentType.Create", NormalizedName = "PAYMENTTYPE.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 57, Name = "PaymentType.Update", NormalizedName = "PAYMENTTYPE.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 58, Name = "PaymentType.Delete", NormalizedName = "PAYMENTTYPE.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Photo
                new Role { Id = 59, Name = "Photo.Read", NormalizedName = "PHOTO.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 60, Name = "Photo.Create", NormalizedName = "PHOTO.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 61, Name = "Photo.Update", NormalizedName = "PHOTO.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 62, Name = "Photo.Delete", NormalizedName = "PHOTO.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Safe
                new Role { Id = 63, Name = "Safe.Read", NormalizedName = "SAFE.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 64, Name = "Safe.Create", NormalizedName = "SAFE.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 65, Name = "Safe.Update", NormalizedName = "SAFE.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 66, Name = "Safe.Delete", NormalizedName = "SAFE.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Tooth
                new Role { Id = 67, Name = "Tooth.Read", NormalizedName = "TOOTH.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 68, Name = "Tooth.Create", NormalizedName = "TOOTH.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 69, Name = "Tooth.Update", NormalizedName = "TOOTH.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 70, Name = "Tooth.Delete", NormalizedName = "TOOTH.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //TreatmentLower
                new Role { Id = 71, Name = "TreatmentLower.Read", NormalizedName = "TREATMENTLOWER.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 72, Name = "TreatmentLower.Create", NormalizedName = "TREATMENTLOWER.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 73, Name = "TreatmentLower.Update", NormalizedName = "TREATMENTLOWER.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 74, Name = "TreatmentLower.Delete", NormalizedName = "TREATMENTLOWER.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Treatment
                new Role { Id = 75, Name = "Treatment.Read", NormalizedName = "TREATMENT.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 76, Name = "Treatment.Create", NormalizedName = "TREATMENT.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 77, Name = "Treatment.Update", NormalizedName = "TREATMENT.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 78, Name = "Treatment.Delete", NormalizedName = "TREATMENT.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //TreatmentStatu
                new Role { Id = 79, Name = "TreatmentStatu.Read", NormalizedName = "TREATMENTSTATU.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 80, Name = "TreatmentStatu.Create", NormalizedName = "TREATMENTSTATU.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 81, Name = "TreatmentStatu.Update", NormalizedName = "TREATMENTSTATU.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 82, Name = "TreatmentStatu.Delete", NormalizedName = "TREATMENTSTATU.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Patient
                new Role { Id = 83, Name = "Patient.Read", NormalizedName = "PATIENT.READ", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 84, Name = "Patient.Create", NormalizedName = "PATIENT.CREATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 85, Name = "Patient.Update", NormalizedName = "PATIENT.UPDATE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 86, Name = "Patient.Delete", NormalizedName = "PATIENT.DELETE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Admin
                new Role { Id = 87, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Sekreter
                new Role { Id = 88, Name = "Sekreter", NormalizedName = "SEKRETER", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Admin
                new Role { Id = 89, Name = "Estetisyen", NormalizedName = "ESTETISYEN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Admin
                new Role { Id = 90, Name = "Editor", NormalizedName = "EDITOR", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Product
                new Role { Id = 91, Name = "Ürün Oku", NormalizedName = "ÜRÜN OKU", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 92, Name = "Ürün Oluştur", NormalizedName = "ÜRÜN OLUŞTUR", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 93, Name = "Ürün Güncelle", NormalizedName = "ÜRÜN GÜNCELLE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 94, Name = "Ürün Sil", NormalizedName = "ÜRÜN SIL", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Stok
                new Role { Id = 95, Name = "Stok Oku", NormalizedName = "STOK OKU", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 96, Name = "Stok Oluştur", NormalizedName = "STOK OLUŞTUR", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 97, Name = "Stok Güncelle", NormalizedName = "STOK GÜNCELLE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 98, Name = "Stok Sil", NormalizedName = "STOK SIL", ConcurrencyStamp = Guid.NewGuid().ToString() },
                //Şube
                new Role { Id = 99, Name = "Şube Oku", NormalizedName = "ŞUBE OKU", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 100, Name = "Şube Oluştur", NormalizedName = "ŞUBE OLUŞTUR", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 101, Name = "Şube Güncelle", NormalizedName = "ŞUBE GÜNCELLE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = 102, Name = "Şube Sil", NormalizedName = "ŞUBE SIL", ConcurrencyStamp = Guid.NewGuid().ToString() }
            );

        }
    }
}
