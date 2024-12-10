using Microsoft.AspNetCore.Identity;
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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            // Social Media Links
            builder.Property(u => u.YoutubeLink).HasMaxLength(250);
            builder.Property(u => u.TwitterLink).HasMaxLength(250);
            builder.Property(u => u.InstagramLink).HasMaxLength(250);
            builder.Property(u => u.FacebookLink).HasMaxLength(250);
            builder.Property(u => u.LinkedInLink).HasMaxLength(250);
            builder.Property(u => u.GitHubLink).HasMaxLength(250);
            builder.Property(u => u.WebsiteLink).HasMaxLength(250);
            // About
            builder.Property(u => u.FirstName).HasMaxLength(30);
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.Property(u => u.About).HasMaxLength(1000);

            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("Users");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(50);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(100);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            
            //SuperAdmin User
            var superAdminUser = new User
            {
                Id = 1,
                
                UserName = "adminuserabdullah",
                NormalizedUserName = "SUPERADMINABDULLAH",
                Email = "adminuserabdullah@gmail.com",
                NormalizedEmail = "SUPERADMINABDULLAH@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Super Admin Abdullah",
                LastName = "User",
                About = "Super Admin  User Abdullah",
                IsDentist = false,
                Color = "",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                GitHubLink = "https://github.com/adminuser",
                LinkedInLink = "https://linkedin.com/adminuser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            superAdminUser.PasswordHash = CreatePasswordHash(superAdminUser, "adminuserabdullah");

            //Admin User 1
            var adminUser1 = new User
            {
                Id = 2,
                
                UserName = "adminuser1",
                NormalizedUserName = "ADMINUSER1",
                Email = "adminuser1@gmail.com",
                NormalizedEmail = "ADMINUSER1@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Admin",
                LastName = "User",
                About = "Admin User of ProgrammersBlog",
                IsDentist = false,
                Color = "",
                TwitterLink = "https://twitter.com/editoruser",
                InstagramLink = "https://instagram.com/editoruser",
                YoutubeLink = "https://youtube.com/editoruser",
                GitHubLink = "https://github.com/editoruser",
                LinkedInLink = "https://linkedin.com/editoruser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/editoruser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser1.PasswordHash = CreatePasswordHash(adminUser1, "adminuser1");

            //Admin User 1
            var adminUser2 = new User
            {
                Id = 3,
                UserName = "adminuser2",
                NormalizedUserName = "ADMINUSER2",
                Email = "adminuser2@gmail.com",
                NormalizedEmail = "ADMINUSER2@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Admin",
                LastName = "User",
                About = "Admin User of ProgrammersBlog",
                IsDentist = false,
                Color = "",
                TwitterLink = "https://twitter.com/editoruser",
                InstagramLink = "https://instagram.com/editoruser",
                YoutubeLink = "https://youtube.com/editoruser",
                GitHubLink = "https://github.com/editoruser",
                LinkedInLink = "https://linkedin.com/editoruser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/editoruser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser2.PasswordHash = CreatePasswordHash(adminUser2, "adminuser2");

            //Editor User
            var editorUser = new User
            {
                Id = 4,
                UserName = "editorUser",
                NormalizedUserName = "EDITORUSER",
                Email = "editorUser@gmail.com",
                NormalizedEmail = "EDITORUSER@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Editor",
                LastName = "User",
                About = "Editor User of ProgrammersBlog",
                IsDentist = false,
                Color = "",
                TwitterLink = "https://twitter.com/editoruser",
                InstagramLink = "https://instagram.com/editoruser",
                YoutubeLink = "https://youtube.com/editoruser",
                GitHubLink = "https://github.com/editoruser",
                LinkedInLink = "https://linkedin.com/editoruser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/editoruser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            editorUser.PasswordHash = CreatePasswordHash(editorUser, "editoruser");

            //Sekreter
            var secretaryUser = new User
            {
                Id = 5,
                UserName = "secretaryuser",
                NormalizedUserName = "SECRETARYUSER",
                Email = "secretaryuser@gmail.com",
                NormalizedEmail = "SECRETARYUSER@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Secretary",
                LastName = "User",
                About = "Secretary User  of TigrisTech Blog",
                IsDentist = false,
                Color = "",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                GitHubLink = "https://github.com/adminuser",
                LinkedInLink = "https://linkedin.com/adminuser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            secretaryUser.PasswordHash = CreatePasswordHash(secretaryUser, "secretaryuser");

            //estetisyenUser1
            var estetisyenUser1 = new User
            {
                Id = 6,
                UserName = "estetisyenuser1",
                NormalizedUserName = "ESTETISYENUSER1",
                Email = "estetisyenuser1@gmail.com",
                NormalizedEmail = "ESTETISYENUSER1@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Estetisyen",
                LastName = "User 1",
                About = "Estetisyen User 1 of TigrisTech Blog",
                IsDentist = true,
                Color = "red",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                GitHubLink = "https://github.com/adminuser",
                LinkedInLink = "https://linkedin.com/adminuser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            estetisyenUser1.PasswordHash = CreatePasswordHash(estetisyenUser1, "estetisyenuser1");

            //estetisyenUser2
            var estetisyenUser2 = new User
            {
                Id = 7,
                UserName = "estetisyenuser2",
                NormalizedUserName = "ESTETISYENUSER2",
                Email = "estetisyenuser2@gmail.com",
                NormalizedEmail = "ESTETISYENUSER2@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Estetisyen",
                LastName = "User 2",
                About = "Estetisyen User 2 of TigrisTech Blog",
                IsDentist = true,
                Color = "blue",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                GitHubLink = "https://github.com/adminuser",
                LinkedInLink = "https://linkedin.com/adminuser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            estetisyenUser2.PasswordHash = CreatePasswordHash(estetisyenUser2, "estetisyenuser2");

            //estetisyenUser3
            var estetisyenUser3 = new User
            {
                Id = 8,
                UserName = "estetisyenuser3",
                NormalizedUserName = "ESTETISYENUSER3",
                Email = "estetisyenuser3@gmail.com",
                NormalizedEmail = "ESTETISUYENUSER3@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Estetisyen3",
                LastName = "User 3",
                About = "Estetisyen User 3 of TigrisTech Blog",
                IsDentist = true,
                Color = "orange",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                GitHubLink = "https://github.com/adminuser",
                LinkedInLink = "https://linkedin.com/adminuser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            estetisyenUser3.PasswordHash = CreatePasswordHash(estetisyenUser3, "estetisyenuser3");

            //estetisyenUser4
            var estetisyenUser4 = new User
            {
                Id = 9,
                UserName = "estetisyenuser4",
                NormalizedUserName = "ESTETISYENUSER4",
                Email = "estetisyenuser4@gmail.com",
                NormalizedEmail = "ESTETISYENUSER4@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "Estetisyen4",
                LastName = "User 4",
                About = "Estetisyen User 4 of TigrisTech Blog",
                IsDentist = true,
                Color = "purple",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                GitHubLink = "https://github.com/adminuser",
                LinkedInLink = "https://linkedin.com/adminuser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = false,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            estetisyenUser4.PasswordHash = CreatePasswordHash(estetisyenUser4, "estetisyenuser4");

            //estetisyenUser5
            var estetisyenUser5 = new User
            {
                Id = 10,
                UserName = "estetisyenuser5",
                NormalizedUserName = "ESTETISYENUSER5",
                Email = "estetisyenuser5@gmail.com",
                NormalizedEmail = "ESTETISYENUSER5@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Picture = "/userImages/defaultUser.png",
                FirstName = "ESTETISYEN5",
                LastName = "User 5",
                About = "Estetisyen User 5 of TigrisTech Blog",
                IsDentist = true,
                Color = "grey",
                TwitterLink = "https://twitter.com/adminuser",
                InstagramLink = "https://instagram.com/adminuser",
                YoutubeLink = "https://youtube.com/adminuser",
                GitHubLink = "https://github.com/adminuser",
                LinkedInLink = "https://linkedin.com/adminuser",
                WebsiteLink = "https://programmersblog.com/",
                FacebookLink = "https://facebook.com/adminuser",
                EmailConfirmed = false,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            estetisyenUser5.PasswordHash = CreatePasswordHash(estetisyenUser5, "estetisyenuser5");

   
            builder.HasData(
                superAdminUser,
                adminUser1, 
                adminUser2,
                secretaryUser,
                editorUser,
                estetisyenUser1,
                estetisyenUser2,
                estetisyenUser3,
                estetisyenUser4,
                estetisyenUser5
                );
        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
