using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TigrisTech.Entities.Concrete.UserTable;

namespace TigrisTech.Data.Concrete.EntityFramework.Mappings.Users
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("UserRoles");

            builder.HasData(
            #region Super Admin
                //*********************SUPER ADMIN*****************
                // Category
                new UserRole { UserId = 1, RoleId = 1 },
                new UserRole { UserId = 1, RoleId = 2 },
                new UserRole { UserId = 1, RoleId = 3 },
                new UserRole { UserId = 1, RoleId = 4 },
                // Article
                new UserRole { UserId = 1, RoleId = 5 },
                new UserRole { UserId = 1, RoleId = 6 },
                new UserRole { UserId = 1, RoleId = 7 },
                new UserRole { UserId = 1, RoleId = 8 },
                // User
                new UserRole { UserId = 1, RoleId = 9 },
                new UserRole { UserId = 1, RoleId = 10 },
                new UserRole { UserId = 1, RoleId = 11 },
                new UserRole { UserId = 1, RoleId = 12 },
                // Role
                new UserRole { UserId = 1, RoleId = 13 },
                new UserRole { UserId = 1, RoleId = 14 },
                new UserRole { UserId = 1, RoleId = 15 },
                new UserRole { UserId = 1, RoleId = 16 },
                // Comment
                new UserRole { UserId = 1, RoleId = 17 },
                new UserRole { UserId = 1, RoleId = 18 },
                new UserRole { UserId = 1, RoleId = 19 },
                new UserRole { UserId = 1, RoleId = 20 },
                // AdminArea.Home.Read
                new UserRole { UserId = 1, RoleId = 21 },
                // SuperAdmin
                new UserRole { UserId = 1, RoleId = 22 },
                //profil
                new UserRole { UserId = 1, RoleId = 23 },
                new UserRole { UserId = 1, RoleId = 24 },
                new UserRole { UserId = 1, RoleId = 25 },
                new UserRole { UserId = 1, RoleId = 26 },
                //Slider
                new UserRole { UserId = 1, RoleId = 27 },
                new UserRole { UserId = 1, RoleId = 28 },
                new UserRole { UserId = 1, RoleId = 29 },
                new UserRole { UserId = 1, RoleId = 30 },
                //Galery
                new UserRole { UserId = 1, RoleId = 31 },
                new UserRole { UserId = 1, RoleId = 32 },
                new UserRole { UserId = 1, RoleId = 33 },
                new UserRole { UserId = 1, RoleId = 34 },
                //AccountCode
                new UserRole { UserId = 1, RoleId = 35 },
                new UserRole { UserId = 1, RoleId = 36 },
                new UserRole { UserId = 1, RoleId = 37 },
                new UserRole { UserId = 1, RoleId = 38 },
                //Appointment
                new UserRole { UserId = 1, RoleId = 39 },
                new UserRole { UserId = 1, RoleId = 40 },
                new UserRole { UserId = 1, RoleId = 41 },
                new UserRole { UserId = 1, RoleId = 42 },
                //AppointmentState
                new UserRole { UserId = 1, RoleId = 43 },
                new UserRole { UserId = 1, RoleId = 44 },
                new UserRole { UserId = 1, RoleId = 45 },
                new UserRole { UserId = 1, RoleId = 46 },
                //ExpendeIncome
                new UserRole { UserId = 1, RoleId = 47 },
                new UserRole { UserId = 1, RoleId = 48 },
                new UserRole { UserId = 1, RoleId = 49 },
                new UserRole { UserId = 1, RoleId = 50 },
                //PaymentMove
                new UserRole { UserId = 1, RoleId = 51 },
                new UserRole { UserId = 1, RoleId = 52 },
                new UserRole { UserId = 1, RoleId = 53 },
                new UserRole { UserId = 1, RoleId = 54 },
                //PaymentType
                new UserRole { UserId = 1, RoleId = 55 },
                new UserRole { UserId = 1, RoleId = 56 },
                new UserRole { UserId = 1, RoleId = 57 },
                new UserRole { UserId = 1, RoleId = 58 },
                //Photo
                new UserRole { UserId = 1, RoleId = 59 },
                new UserRole { UserId = 1, RoleId = 60 },
                new UserRole { UserId = 1, RoleId = 61 },
                new UserRole { UserId = 1, RoleId = 62 },
                //Safe
                new UserRole { UserId = 1, RoleId = 63 },
                new UserRole { UserId = 1, RoleId = 64 },
                new UserRole { UserId = 1, RoleId = 65 },
                new UserRole { UserId = 1, RoleId = 66 },
                //Tooth
                new UserRole { UserId = 1, RoleId = 67 },
                new UserRole { UserId = 1, RoleId = 68 },
                new UserRole { UserId = 1, RoleId = 69 },
                new UserRole { UserId = 1, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 1, RoleId = 71 },
                new UserRole { UserId = 1, RoleId = 72 },
                new UserRole { UserId = 1, RoleId = 73 },
                new UserRole { UserId = 1, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 1, RoleId = 75 },
                new UserRole { UserId = 1, RoleId = 76 },
                new UserRole { UserId = 1, RoleId = 77 },
                new UserRole { UserId = 1, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 1, RoleId = 79 },
                new UserRole { UserId = 1, RoleId = 80 },
                new UserRole { UserId = 1, RoleId = 81 },
                new UserRole { UserId = 1, RoleId = 82 },
                //Patient
                new UserRole { UserId = 1, RoleId = 83 },
                new UserRole { UserId = 1, RoleId = 84 },
                new UserRole { UserId = 1, RoleId = 85 },
                new UserRole { UserId = 1, RoleId = 86 },
                //Admin
                new UserRole { UserId = 1, RoleId = 87 },
                //Sekreter
                new UserRole { UserId = 1, RoleId = 88 },
                //Estetisyen
                new UserRole { UserId = 1, RoleId = 89 },
                //Editor
                new UserRole { UserId = 1, RoleId = 90 },
                //Product
                new UserRole { UserId = 1, RoleId = 91 },
                new UserRole { UserId = 1, RoleId = 92 },
                new UserRole { UserId = 1, RoleId = 93 },
                new UserRole { UserId = 1, RoleId = 94 },
                //Stok
                new UserRole { UserId = 1, RoleId = 95 },
                new UserRole { UserId = 1, RoleId = 96 },
                new UserRole { UserId = 1, RoleId = 97 },
                new UserRole { UserId = 1, RoleId = 98 },
                //Şube
                new UserRole { UserId = 1, RoleId = 99 },
                new UserRole { UserId = 1, RoleId = 100 },
                new UserRole { UserId = 1, RoleId = 101 },
                new UserRole { UserId = 1, RoleId = 102 },
            #endregion
            #region Admin Şube A
                //********************* ADMIN Şube A *****************

                // AdminArea.Home.Read
                new UserRole { UserId = 2, RoleId = 21 },
                //AccountCode
                new UserRole { UserId = 2, RoleId = 35 },
                new UserRole { UserId = 2, RoleId = 36 },
                new UserRole { UserId = 2, RoleId = 37 },
                new UserRole { UserId = 2, RoleId = 38 },
                //Appointment
                new UserRole { UserId = 2, RoleId = 39 },
                new UserRole { UserId = 2, RoleId = 40 },
                new UserRole { UserId = 2, RoleId = 41 },
                new UserRole { UserId = 2, RoleId = 42 },
                //AppointmentState
                new UserRole { UserId = 2, RoleId = 43 },
                new UserRole { UserId = 2, RoleId = 44 },
                new UserRole { UserId = 2, RoleId = 45 },
                new UserRole { UserId = 2, RoleId = 46 },
                //ExpendeIncome
                new UserRole { UserId = 2, RoleId = 47 },
                new UserRole { UserId = 2, RoleId = 48 },
                new UserRole { UserId = 2, RoleId = 49 },
                new UserRole { UserId = 2, RoleId = 50 },
                //PaymentMove
                new UserRole { UserId = 2, RoleId = 51 },
                new UserRole { UserId = 2, RoleId = 52 },
                new UserRole { UserId = 2, RoleId = 53 },
                new UserRole { UserId = 2, RoleId = 54 },
                //PaymentType
                new UserRole { UserId = 2, RoleId = 55 },
                new UserRole { UserId = 2, RoleId = 56 },
                new UserRole { UserId = 2, RoleId = 57 },
                new UserRole { UserId = 2, RoleId = 58 },
                //Photo
                new UserRole { UserId = 2, RoleId = 59 },
                new UserRole { UserId = 2, RoleId = 60 },
                new UserRole { UserId = 2, RoleId = 61 },
                new UserRole { UserId = 2, RoleId = 62 },
                //Safe
                new UserRole { UserId = 2, RoleId = 63 },
                new UserRole { UserId = 2, RoleId = 64 },
                new UserRole { UserId = 2, RoleId = 65 },
                new UserRole { UserId = 2, RoleId = 66 },
                //Tooth
                new UserRole { UserId = 2, RoleId = 67 },
                new UserRole { UserId = 2, RoleId = 68 },
                new UserRole { UserId = 2, RoleId = 69 },
                new UserRole { UserId = 2, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 2, RoleId = 71 },
                new UserRole { UserId = 2, RoleId = 72 },
                new UserRole { UserId = 2, RoleId = 73 },
                new UserRole { UserId = 2, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 2, RoleId = 75 },
                new UserRole { UserId = 2, RoleId = 76 },
                new UserRole { UserId = 2, RoleId = 77 },
                new UserRole { UserId = 2, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 2, RoleId = 79 },
                new UserRole { UserId = 2, RoleId = 80 },
                new UserRole { UserId = 2, RoleId = 81 },
                new UserRole { UserId = 2, RoleId = 82 },
                //Patient
                new UserRole { UserId = 2, RoleId = 83 },
                new UserRole { UserId = 2, RoleId = 84 },
                new UserRole { UserId = 2, RoleId = 85 },
                new UserRole { UserId = 2, RoleId = 86 },
                //Admin
                new UserRole { UserId = 2, RoleId = 87 },
                //Sekreter
                new UserRole { UserId = 2, RoleId = 88 },
                //Estetisyen
                new UserRole { UserId = 2, RoleId = 89 },
                //Product
                new UserRole { UserId = 2, RoleId = 91 },
                new UserRole { UserId = 2, RoleId = 92 },
                new UserRole { UserId = 2, RoleId = 93 },
                new UserRole { UserId = 2, RoleId = 94 },
                //Stok
                new UserRole { UserId = 2, RoleId = 95 },
                new UserRole { UserId = 2, RoleId = 96 },
                new UserRole { UserId = 2, RoleId = 97 },
                new UserRole { UserId = 2, RoleId = 98 },
                //Şube
                new UserRole { UserId = 2, RoleId = 99 },
                new UserRole { UserId = 2, RoleId = 100 },
                new UserRole { UserId = 2, RoleId = 101 },
                new UserRole { UserId = 2, RoleId = 102 },

            #endregion
            #region Admin Şube B
                //********************* ADMIN ŞUBE 2 *****************

                // AdminArea.Home.Read
                new UserRole { UserId = 3, RoleId = 21 },

                //AccountCode
                new UserRole { UserId = 3, RoleId = 35 },
                new UserRole { UserId = 3, RoleId = 36 },
                new UserRole { UserId = 3, RoleId = 37 },
                new UserRole { UserId = 3, RoleId = 38 },
                //Appointment
                new UserRole { UserId = 3, RoleId = 39 },
                new UserRole { UserId = 3, RoleId = 40 },
                new UserRole { UserId = 3, RoleId = 41 },
                new UserRole { UserId = 3, RoleId = 42 },
                //AppointmentState
                new UserRole { UserId = 3, RoleId = 43 },
                new UserRole { UserId = 3, RoleId = 44 },
                new UserRole { UserId = 3, RoleId = 45 },
                new UserRole { UserId = 3, RoleId = 46 },
                //ExpendeIncome
                new UserRole { UserId = 3, RoleId = 47 },
                new UserRole { UserId = 3, RoleId = 48 },
                new UserRole { UserId = 3, RoleId = 49 },
                new UserRole { UserId = 3, RoleId = 50 },
                //PaymentMove
                new UserRole { UserId = 3, RoleId = 51 },
                new UserRole { UserId = 3, RoleId = 52 },
                new UserRole { UserId = 3, RoleId = 53 },
                new UserRole { UserId = 3, RoleId = 54 },
                //PaymentType
                new UserRole { UserId = 3, RoleId = 55 },
                new UserRole { UserId = 3, RoleId = 56 },
                new UserRole { UserId = 3, RoleId = 57 },
                new UserRole { UserId = 3, RoleId = 58 },
                //Photo
                new UserRole { UserId = 3, RoleId = 59 },
                new UserRole { UserId = 3, RoleId = 60 },
                new UserRole { UserId = 3, RoleId = 61 },
                new UserRole { UserId = 3, RoleId = 62 },
                //Safe
                new UserRole { UserId = 3, RoleId = 63 },
                new UserRole { UserId = 3, RoleId = 64 },
                new UserRole { UserId = 3, RoleId = 65 },
                new UserRole { UserId = 3, RoleId = 66 },
                //Tooth
                new UserRole { UserId = 3, RoleId = 67 },
                new UserRole { UserId = 3, RoleId = 68 },
                new UserRole { UserId = 3, RoleId = 69 },
                new UserRole { UserId = 3, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 3, RoleId = 71 },
                new UserRole { UserId = 3, RoleId = 72 },
                new UserRole { UserId = 3, RoleId = 73 },
                new UserRole { UserId = 3, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 3, RoleId = 75 },
                new UserRole { UserId = 3, RoleId = 76 },
                new UserRole { UserId = 3, RoleId = 77 },
                new UserRole { UserId = 3, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 3, RoleId = 79 },
                new UserRole { UserId = 3, RoleId = 80 },
                new UserRole { UserId = 3, RoleId = 81 },
                new UserRole { UserId = 3, RoleId = 82 },
                //Patient
                new UserRole { UserId = 3, RoleId = 83 },
                new UserRole { UserId = 3, RoleId = 84 },
                new UserRole { UserId = 3, RoleId = 85 },
                new UserRole { UserId = 3, RoleId = 86 },
                //Admin
                new UserRole { UserId = 3, RoleId = 87 },
                //Sekreter
                new UserRole { UserId = 3, RoleId = 88 },
                //EstetisyeN
                new UserRole { UserId = 3, RoleId = 89 },
                //Product
                new UserRole { UserId = 3, RoleId = 91 },
                new UserRole { UserId = 3, RoleId = 92 },
                new UserRole { UserId = 3, RoleId = 93 },
                new UserRole { UserId = 3, RoleId = 94 },
                //Stok
                new UserRole { UserId = 3, RoleId = 95 },
                new UserRole { UserId = 3, RoleId = 96 },
                new UserRole { UserId = 3, RoleId = 97 },
                new UserRole { UserId = 3, RoleId = 98 },
                //Şube
                new UserRole { UserId = 3, RoleId = 99 },
                new UserRole { UserId = 3, RoleId = 100 },
                new UserRole { UserId = 3, RoleId = 101 },
                new UserRole { UserId = 3, RoleId = 102 },

            #endregion
            #region Editör
                //*********************EDITOR*****************
                // Category
                new UserRole { UserId = 4, RoleId = 1 },
                new UserRole { UserId = 4, RoleId = 2 },
                new UserRole { UserId = 4, RoleId = 3 },
                new UserRole { UserId = 4, RoleId = 4 },
                // Article
                new UserRole { UserId = 4, RoleId = 5 },
                new UserRole { UserId = 4, RoleId = 6 },
                new UserRole { UserId = 4, RoleId = 7 },
                new UserRole { UserId = 4, RoleId = 8 },
                // Comment
                new UserRole { UserId = 4, RoleId = 17 },
                new UserRole { UserId = 4, RoleId = 18 },
                new UserRole { UserId = 4, RoleId = 19 },
                new UserRole { UserId = 4, RoleId = 20 },
                // AdminArea.Home.Read
                new UserRole { UserId = 4, RoleId = 21 },
                //profil
                new UserRole { UserId = 4, RoleId = 23 },
                new UserRole { UserId = 4, RoleId = 24 },
                new UserRole { UserId = 4, RoleId = 25 },
                new UserRole { UserId = 4, RoleId = 26 },
                //Slider
                new UserRole { UserId = 4, RoleId = 27 },
                new UserRole { UserId = 4, RoleId = 28 },
                new UserRole { UserId = 4, RoleId = 29 },
                new UserRole { UserId = 4, RoleId = 30 },
                //Galery
                new UserRole { UserId = 4, RoleId = 31 },
                new UserRole { UserId = 4, RoleId = 32 },
                new UserRole { UserId = 4, RoleId = 33 },
                new UserRole { UserId = 4, RoleId = 34 },
                //Editor
                new UserRole { UserId = 4, RoleId = 90 },

            #endregion
            #region Sekreter
                //******************SECRETARY   *****************

                // AdminArea.Home.Read
                new UserRole { UserId = 5, RoleId = 21 },
                //AccountCode
                new UserRole { UserId = 5, RoleId = 35 },
                new UserRole { UserId = 5, RoleId = 36 },
                new UserRole { UserId = 5, RoleId = 37 },
                new UserRole { UserId = 5, RoleId = 38 },
                //Appointment
                new UserRole { UserId = 5, RoleId = 39 },
                new UserRole { UserId = 5, RoleId = 40 },
                new UserRole { UserId = 5, RoleId = 41 },
                new UserRole { UserId = 5, RoleId = 42 },
                //AppointmentState
                new UserRole { UserId = 5, RoleId = 43 },
                new UserRole { UserId = 5, RoleId = 44 },
                new UserRole { UserId = 5, RoleId = 45 },
                new UserRole { UserId = 5, RoleId = 46 },
                //ExpendeIncome
                new UserRole { UserId = 5, RoleId = 47 },
                new UserRole { UserId = 5, RoleId = 48 },
                new UserRole { UserId = 5, RoleId = 49 },
                new UserRole { UserId = 5, RoleId = 50 },
                //PaymentMove
                new UserRole { UserId = 5, RoleId = 51 },
                new UserRole { UserId = 5, RoleId = 52 },
                new UserRole { UserId = 5, RoleId = 53 },
                new UserRole { UserId = 5, RoleId = 54 },
                //PaymentType
                new UserRole { UserId = 5, RoleId = 55 },
                new UserRole { UserId = 5, RoleId = 56 },
                new UserRole { UserId = 5, RoleId = 57 },
                new UserRole { UserId = 5, RoleId = 58 },
                //Photo
                new UserRole { UserId = 5, RoleId = 59 },
                new UserRole { UserId = 5, RoleId = 60 },
                new UserRole { UserId = 5, RoleId = 61 },
                new UserRole { UserId = 5, RoleId = 62 },
                //Safe
                new UserRole { UserId = 5, RoleId = 63 },
                new UserRole { UserId = 5, RoleId = 64 },
                new UserRole { UserId = 5, RoleId = 65 },
                new UserRole { UserId = 5, RoleId = 66 },
                //Tooth
                new UserRole { UserId = 5, RoleId = 67 },
                new UserRole { UserId = 5, RoleId = 68 },
                new UserRole { UserId = 5, RoleId = 69 },
                new UserRole { UserId = 5, RoleId = 70 },
                //Patient
                new UserRole { UserId = 5, RoleId = 83 },
                new UserRole { UserId = 5, RoleId = 84 },
                new UserRole { UserId = 5, RoleId = 85 },
                new UserRole { UserId = 5, RoleId = 86 },
                //Sekreter
                new UserRole { UserId = 5, RoleId = 88 },
            #endregion
            #region Doktor 1
                //******************DOKTOR  1 *****************
                // AdminArea.Home.Read
                new UserRole { UserId = 6, RoleId = 21 },
                //Appointment
                new UserRole { UserId = 6, RoleId = 39 },
                new UserRole { UserId = 6, RoleId = 40 },
                new UserRole { UserId = 6, RoleId = 41 },
                new UserRole { UserId = 6, RoleId = 42 },
                //Photo
                new UserRole { UserId = 6, RoleId = 59 },
                new UserRole { UserId = 6, RoleId = 60 },
                new UserRole { UserId = 6, RoleId = 61 },
                new UserRole { UserId = 6, RoleId = 62 },
                //Tooth
                new UserRole { UserId = 6, RoleId = 67 },
                new UserRole { UserId = 6, RoleId = 68 },
                new UserRole { UserId = 6, RoleId = 69 },
                new UserRole { UserId = 6, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 6, RoleId = 71 },
                new UserRole { UserId = 6, RoleId = 72 },
                new UserRole { UserId = 6, RoleId = 73 },
                new UserRole { UserId = 6, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 6, RoleId = 75 },
                new UserRole { UserId = 6, RoleId = 76 },
                new UserRole { UserId = 6, RoleId = 77 },
                new UserRole { UserId = 6, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 6, RoleId = 79 },
                new UserRole { UserId = 6, RoleId = 80 },
                new UserRole { UserId = 6, RoleId = 81 },
                new UserRole { UserId = 6, RoleId = 82 },
                //Patient
                new UserRole { UserId = 6, RoleId = 83 },
                new UserRole { UserId = 6, RoleId = 84 },
                new UserRole { UserId = 6, RoleId = 85 },
                new UserRole { UserId = 6, RoleId = 86 },
            #endregion
            #region Doktor 2
                //******************DOKTOR  2 *****************
                // AdminArea.Home.Read
                new UserRole { UserId = 7, RoleId = 21 },
                //Appointment
                new UserRole { UserId = 7, RoleId = 39 },
                new UserRole { UserId = 7, RoleId = 40 },
                new UserRole { UserId = 7, RoleId = 41 },
                new UserRole { UserId = 7, RoleId = 42 },
                //Photo
                new UserRole { UserId = 7, RoleId = 59 },
                new UserRole { UserId = 7, RoleId = 60 },
                new UserRole { UserId = 7, RoleId = 61 },
                new UserRole { UserId = 7, RoleId = 62 },
                //Tooth
                new UserRole { UserId = 7, RoleId = 67 },
                new UserRole { UserId = 7, RoleId = 68 },
                new UserRole { UserId = 7, RoleId = 69 },
                new UserRole { UserId = 7, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 7, RoleId = 71 },
                new UserRole { UserId = 7, RoleId = 72 },
                new UserRole { UserId = 7, RoleId = 73 },
                new UserRole { UserId = 7, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 7, RoleId = 75 },
                new UserRole { UserId = 7, RoleId = 76 },
                new UserRole { UserId = 7, RoleId = 77 },
                new UserRole { UserId = 7, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 7, RoleId = 79 },
                new UserRole { UserId = 7, RoleId = 80 },
                new UserRole { UserId = 7, RoleId = 81 },
                new UserRole { UserId = 7, RoleId = 82 },
                //Patient
                new UserRole { UserId = 7, RoleId = 83 },
                new UserRole { UserId = 7, RoleId = 84 },
                new UserRole { UserId = 7, RoleId = 85 },
                new UserRole { UserId = 7, RoleId = 86 },
            #endregion
            #region Doktor 3
                //******************DOKTOR  3 *****************
                // AdminArea.Home.Read
                new UserRole { UserId = 8, RoleId = 21 },
                //Appointment
                new UserRole { UserId = 8, RoleId = 39 },
                new UserRole { UserId = 8, RoleId = 40 },
                new UserRole { UserId = 8, RoleId = 41 },
                new UserRole { UserId = 8, RoleId = 42 },
                //Photo
                new UserRole { UserId = 8, RoleId = 59 },
                new UserRole { UserId = 8, RoleId = 60 },
                new UserRole { UserId = 8, RoleId = 61 },
                new UserRole { UserId = 8, RoleId = 62 },
                //Tooth
                new UserRole { UserId = 8, RoleId = 67 },
                new UserRole { UserId = 8, RoleId = 68 },
                new UserRole { UserId = 8, RoleId = 69 },
                new UserRole { UserId = 8, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 8, RoleId = 71 },
                new UserRole { UserId = 8, RoleId = 72 },
                new UserRole { UserId = 8, RoleId = 73 },
                new UserRole { UserId = 8, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 8, RoleId = 75 },
                new UserRole { UserId = 8, RoleId = 76 },
                new UserRole { UserId = 8, RoleId = 77 },
                new UserRole { UserId = 8, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 8, RoleId = 79 },
                new UserRole { UserId = 8, RoleId = 80 },
                new UserRole { UserId = 8, RoleId = 81 },
                new UserRole { UserId = 8, RoleId = 82 },
                //Patient
                new UserRole { UserId = 8, RoleId = 83 },
                new UserRole { UserId = 8, RoleId = 84 },
                new UserRole { UserId = 8, RoleId = 85 },
                new UserRole { UserId = 8, RoleId = 86 },
            #endregion
            #region Doktor 4
                //******************DOKTOR  4 *****************
                // AdminArea.Home.Read
                new UserRole { UserId = 9, RoleId = 21 },
                //Appointment
                new UserRole { UserId = 9, RoleId = 39 },
                new UserRole { UserId = 9, RoleId = 40 },
                new UserRole { UserId = 9, RoleId = 41 },
                new UserRole { UserId = 9, RoleId = 42 },
                //Photo
                new UserRole { UserId = 9, RoleId = 59 },
                new UserRole { UserId = 9, RoleId = 60 },
                new UserRole { UserId = 9, RoleId = 61 },
                new UserRole { UserId = 9, RoleId = 62 },
                //Tooth
                new UserRole { UserId = 9, RoleId = 67 },
                new UserRole { UserId = 9, RoleId = 68 },
                new UserRole { UserId = 9, RoleId = 69 },
                new UserRole { UserId = 9, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 9, RoleId = 71 },
                new UserRole { UserId = 9, RoleId = 72 },
                new UserRole { UserId = 9, RoleId = 73 },
                new UserRole { UserId = 9, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 9, RoleId = 75 },
                new UserRole { UserId = 9, RoleId = 76 },
                new UserRole { UserId = 9, RoleId = 77 },
                new UserRole { UserId = 9, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 9, RoleId = 79 },
                new UserRole { UserId = 9, RoleId = 80 },
                new UserRole { UserId = 9, RoleId = 81 },
                new UserRole { UserId = 9, RoleId = 82 },
                //Patient
                new UserRole { UserId = 9, RoleId = 83 },
                new UserRole { UserId = 9, RoleId = 84 },
                new UserRole { UserId = 9, RoleId = 85 },
                new UserRole { UserId = 9, RoleId = 86 },
            #endregion
            #region Doktor 5
                //******************DOKTOR  5 *****************
                // AdminArea.Home.Read
                new UserRole { UserId = 10, RoleId = 21 },
                //Appointment
                new UserRole { UserId = 10, RoleId = 39 },
                new UserRole { UserId = 10, RoleId = 40 },
                new UserRole { UserId = 10, RoleId = 41 },
                new UserRole { UserId = 10, RoleId = 42 },
                //Photo
                new UserRole { UserId = 10, RoleId = 59 },
                new UserRole { UserId = 10, RoleId = 60 },
                new UserRole { UserId = 10, RoleId = 61 },
                new UserRole { UserId = 10, RoleId = 62 },
                //Tooth
                new UserRole { UserId = 10, RoleId = 67 },
                new UserRole { UserId = 10, RoleId = 68 },
                new UserRole { UserId = 10, RoleId = 69 },
                new UserRole { UserId = 10, RoleId = 70 },
                //TreatmentLower
                new UserRole { UserId = 10, RoleId = 71 },
                new UserRole { UserId = 10, RoleId = 72 },
                new UserRole { UserId = 10, RoleId = 73 },
                new UserRole { UserId = 10, RoleId = 74 },
                //Treatment
                new UserRole { UserId = 10, RoleId = 75 },
                new UserRole { UserId = 10, RoleId = 76 },
                new UserRole { UserId = 10, RoleId = 77 },
                new UserRole { UserId = 10, RoleId = 78 },
                //TreatmentStatu
                new UserRole { UserId = 10, RoleId = 79 },
                new UserRole { UserId = 10, RoleId = 80 },
                new UserRole { UserId = 10, RoleId = 81 },
                new UserRole { UserId = 10, RoleId = 82 },
                //Patient
                new UserRole { UserId = 10, RoleId = 83 },
                new UserRole { UserId = 10, RoleId = 84 },
                new UserRole { UserId = 10, RoleId = 85 },
                new UserRole { UserId = 10, RoleId = 86 }
                #endregion
            );
        }
    }
}
