using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TigrisTech.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    About = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    IsDentist = table.Column<bool>(type: "bit", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InstagramLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LinkedInLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GitHubLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    WebsiteLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Test = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Logged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Logger = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Callsite = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    Exception = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TcNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InstagramLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LinkedInLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GitHubLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    WebsiteLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sldiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sldiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 47, "cb56f688-d2b7-481a-8027-3af730c47d47", "ExpendeInCome.Read", "EXPENDEINCOME.READ" },
                    { 61, "76625c5d-3c5e-41a0-8a7c-c47b0b41a042", "Photo.Update", "PHOTO.UPDATE" },
                    { 60, "7866f4e2-01ca-4803-974a-d0f04c98af19", "Photo.Create", "PHOTO.CREATE" },
                    { 59, "7dd2a6dd-224c-48d7-97d5-764550f4a7bc", "Photo.Read", "PHOTO.READ" },
                    { 58, "713e1372-a086-4134-9f5d-64093c6b063f", "PaymentType.Delete", "PAYMENTTYPE.DELETE" },
                    { 57, "efda924c-5daa-49fc-9555-2d0aaa2007e8", "PaymentType.Update", "PAYMENTTYPE.UPDATE" },
                    { 56, "6167ea96-8c37-46bb-85b3-83b40c9f8043", "PaymentType.Create", "PAYMENTTYPE.CREATE" },
                    { 55, "edc5e6d0-21e7-4aef-b70f-9a17b9cb9873", "PaymentType.Read", "PAYMENTTYPE.READ" },
                    { 54, "3d529e1b-3a82-4906-b033-dbd643f144e6", "PaymentMove.Delete", "PAYMENTMOVE.DELETE" },
                    { 53, "0e52dc77-d97d-480f-8564-1ad5e7ae732e", "PaymentMove.Update", "PAYMENTMOVE.UPDATE" },
                    { 52, "7f514e2a-76e3-4ba4-8779-4d9fab9b1c42", "PaymentMove.Create", "PAYMENTMOVE.CREATE" },
                    { 51, "4effe8dd-5b2c-4d26-9891-0de29fe44775", "PaymentMove.Read", "PAYMENTMOVE.READ" },
                    { 50, "0ae42c82-de6c-42fe-8d87-d4baca692987", "ExpendeInCome.Delete", "EXPENDEINCOME.DELETE" },
                    { 49, "7587b482-d847-4f1e-8367-d6f6ef1f8772", "ExpendeInCome.Update", "EXPENDEINCOME.UPDATE" },
                    { 48, "9d0df68d-ea63-4fcf-8bb1-33c9bcdca727", "ExpendeInCome.Create", "EXPENDEINCOME.CREATE" },
                    { 92, "9329db76-5609-4147-bd34-067d0c22a548", "Ürün Oluştur", "ÜRÜN OLUŞTUR" },
                    { 46, "5d569a74-edaf-4fc8-98a3-745dd41b322f", "AppointmentState.Delete", "APPOINTMENTSTATE.DELETE" },
                    { 45, "3cb05a4a-a62b-4643-afaa-a0c56aa02316", "AppointmentState.Update", "APPOINTMENTSTATE.UPDATE" },
                    { 44, "81dfc2ae-8059-4bfa-bdf5-1a75f82a26b5", "AppointmentState.Create", "APPOINTMENTSTATE.CREATE" },
                    { 43, "e54ea92d-1ac6-45f1-ab77-169db39617fa", "AppointmentState.Read", "APPOINTMENTSTATE.READ" },
                    { 42, "78cb4c1c-6680-45d6-a0dd-9600f40fd0b7", "Appointment.Delete", "APPOINTMENT.DELETE" },
                    { 41, "b68fbdb2-c045-4792-bd5d-e9b84d66fb71", "Appointment.Update", "APPOINTMENT.UPDATE" },
                    { 40, "718f9ddc-ac80-49e1-ac01-a40aa27611fb", "Appointment.Create", "APPOINTMENT.CREATE" },
                    { 39, "43d7e1f2-ca45-4155-a74d-96f1c03011c8", "Appointment.Read", "APPOINTMENT.READ" },
                    { 62, "1db0a7a0-20b5-4172-b4b9-7f6a4da6459e", "Photo.Delete", "PHOTO.DELETE" },
                    { 63, "7fd51edb-e97c-4376-8eeb-00326e74483f", "Safe.Read", "SAFE.READ" },
                    { 64, "d00ac323-02c0-4617-9e79-5e61fe82a482", "Safe.Create", "SAFE.CREATE" },
                    { 65, "7ef2a9d6-7e14-4fe0-80cb-07c9b1ca7290", "Safe.Update", "SAFE.UPDATE" },
                    { 89, "69cb6517-a4b4-4690-b7ff-dfffe364d736", "Estetisyen", "ESTETISYEN" },
                    { 88, "a2237e9d-790e-4fd4-adb1-cd87ea120500", "Sekreter", "SEKRETER" },
                    { 87, "8c9c5da2-f095-439e-b1a7-b8c81c316d66", "Admin", "ADMIN" },
                    { 86, "dab889ed-09d0-464e-8b1b-3a1ec6100080", "Patient.Delete", "PATIENT.DELETE" },
                    { 85, "058c891f-a794-4363-a902-e27cbb672724", "Patient.Update", "PATIENT.UPDATE" },
                    { 84, "b0d37a1a-294c-4d59-b52a-9d7b41095f8f", "Patient.Create", "PATIENT.CREATE" },
                    { 83, "4c348a2a-cfc4-4440-9fbe-74d27c6b0845", "Patient.Read", "PATIENT.READ" },
                    { 82, "a28700dc-e2c0-4062-811e-f8f83a9aaf3e", "TreatmentStatu.Delete", "TREATMENTSTATU.DELETE" },
                    { 81, "a3f88244-e81c-4e33-a146-ecd5c436ce72", "TreatmentStatu.Update", "TREATMENTSTATU.UPDATE" },
                    { 80, "7ff3ca55-dd98-443e-bb9a-3a569e652457", "TreatmentStatu.Create", "TREATMENTSTATU.CREATE" },
                    { 79, "0e4d7be0-7b52-4527-8384-6cedebfe7eb7", "TreatmentStatu.Read", "TREATMENTSTATU.READ" },
                    { 38, "fb41a9cb-2c3f-4c05-8244-21ca104a9246", "AccountCode.Delete", "ACCOUNTCODE.DELETE" },
                    { 78, "fdc8d64c-4db6-4c45-9d0a-fc90aa949d9c", "Treatment.Delete", "TREATMENT.DELETE" },
                    { 76, "e209954f-8996-43b3-a7ab-d05d36b1da17", "Treatment.Create", "TREATMENT.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 75, "1b66ed64-4aa2-4b4c-a3f4-cec7b16d67e9", "Treatment.Read", "TREATMENT.READ" },
                    { 74, "276e07d1-9340-4816-9e94-4d53bc9b1ba8", "TreatmentLower.Delete", "TREATMENTLOWER.DELETE" },
                    { 73, "91d20417-7473-48f8-8344-9b3674d5c147", "TreatmentLower.Update", "TREATMENTLOWER.UPDATE" },
                    { 72, "6fedc064-49ee-46f6-a94c-e30ab9e6e131", "TreatmentLower.Create", "TREATMENTLOWER.CREATE" },
                    { 71, "80c09b26-7fd8-450e-a9fc-3ee6cfc98552", "TreatmentLower.Read", "TREATMENTLOWER.READ" },
                    { 70, "48029fe2-5522-40a7-b3f2-33da69332207", "Tooth.Delete", "TOOTH.DELETE" },
                    { 69, "bb51e8e8-f413-4356-a5f6-012f41e584dc", "Tooth.Update", "TOOTH.UPDATE" },
                    { 68, "438f92c6-c72c-46fb-8942-dd81910688b4", "Tooth.Create", "TOOTH.CREATE" },
                    { 67, "daeb2aed-cb61-4ec0-8161-3d6396247b24", "Tooth.Read", "TOOTH.READ" },
                    { 66, "93e88551-c2eb-4b37-ad64-c8ffe0c50cb5", "Safe.Delete", "SAFE.DELETE" },
                    { 77, "a8f9a7ed-e146-440a-bf3a-fdd98d1f0438", "Treatment.Update", "TREATMENT.UPDATE" },
                    { 37, "ef5f26c1-00c6-4bff-8663-8267e8166f8c", "AccountCode.Update", "ACCOUNTCODE.UPDATE" },
                    { 36, "f16dd752-7556-43a7-a1c8-dc2cc2938a9b", "AccountCode.Create", "ACCOUNTCODE.CREATE" },
                    { 35, "4905e702-084d-4449-8738-221c8cb2c628", "AccountCode.Read", "ACCOUNTCODE.READ" },
                    { 10, "fcf767d9-e28f-4ba1-8259-ce8cd60d90ca", "User.Read", "USER.READ" },
                    { 9, "ec69d230-b3a8-4a6c-bed3-7aed6aa2c29b", "User.Create", "USER.CREATE" },
                    { 90, "22372f97-aa56-4d29-917b-f04da7f4a931", "Editor", "EDITOR" },
                    { 7, "54cdb713-ca8e-4318-a360-b74452bed84e", "Article.Update", "ARTICLE.UPDATE" },
                    { 6, "1b3787ec-7c74-4177-a468-567a1d6e5889", "Article.Read", "ARTICLE.READ" },
                    { 5, "82555312-16d0-435e-a39d-b1b698ee47ce", "Article.Create", "ARTICLE.CREATE" },
                    { 4, "301eeeaf-76cf-4929-a58e-bc6f3a0cdb2c", "Category.Delete", "CATEGORY.DELETE" },
                    { 3, "fd79c0f4-735d-45ac-93ab-cb4bd121c037", "Category.Update", "CATEGORY.UPDATE" },
                    { 2, "85e8d92e-acde-4cb6-bf03-8e0e958344f8", "Category.Read", "CATEGORY.READ" },
                    { 11, "60c71d3a-cc63-45b5-96dd-434478ed03db", "User.Update", "USER.UPDATE" },
                    { 1, "af0eeddf-abc2-4c1f-b153-9c280ee7ee02", "Category.Create", "CATEGORY.CREATE" },
                    { 94, "b5d00603-5772-40fc-882b-f85c0400bea3", "Ürün Sil", "ÜRÜN SIL" },
                    { 95, "7a945891-55a9-4716-a830-ca788ab34f10", "Stok Oku", "STOK OKU" },
                    { 96, "bfccf5a2-ea27-437e-9266-1047dd04e9bf", "Stok Oluştur", "STOK OLUŞTUR" },
                    { 97, "80cfe13c-796b-4e50-b363-a7833cee3c4d", "Stok Güncelle", "STOK GÜNCELLE" },
                    { 98, "7e835e3f-40a7-419c-96cf-d43d74e3256a", "Stok Sil", "STOK SIL" },
                    { 99, "a71a4ce1-9aa7-4a70-82a6-07a65092a7e3", "Şube Oku", "ŞUBE OKU" },
                    { 100, "8c5a76b7-dd84-404f-b0c5-9642f75321b6", "Şube Oluştur", "ŞUBE OLUŞTUR" },
                    { 101, "43f95bf5-25a9-4ca9-a778-dcdf3655f7ab", "Şube Güncelle", "ŞUBE GÜNCELLE" },
                    { 102, "0f8f7e7b-5f0a-486f-b4cb-d5088ac16c77", "Şube Sil", "ŞUBE SIL" },
                    { 93, "e18199da-e6e6-433c-88aa-f33ba938cfbb", "Ürün Güncelle", "ÜRÜN GÜNCELLE" },
                    { 12, "8e0feeb3-1355-4c90-bd75-7914cb97ff1f", "User.Delete", "USER.DELETE" },
                    { 8, "02ef514d-56e3-41f6-a3e4-24a81ede4a5b", "Article.Delete", "ARTICLE.DELETE" },
                    { 14, "32bfa3bb-d388-4d84-b0f4-14e5258463c3", "Role.Read", "ROLE.READ" },
                    { 34, "bf95c0e6-225d-42da-a9e2-521f3aaf40a3", "Galery.Delete", "GALERY.DELETE" },
                    { 33, "d4ae5a41-b64b-4404-b0b6-6313b85574f0", "Galery.Update", "GALERY.UPDATE" },
                    { 32, "529ca023-7cb1-41d8-a47e-6e529421294f", "Galery.Create", "GALERY.CREATE" },
                    { 31, "7095a19d-5c54-4988-9bcf-5b93a9bbad58", "Galery.Read", "GALERY.READ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 30, "02ca0673-5ff6-4c19-b8e1-fd0e6761f79b", "Slider.Delete", "SLIDER.DELETE" },
                    { 13, "445ebd7c-169b-4c9f-954c-6c766e527672", "Role.Create", "ROLE.CREATE" },
                    { 28, "cb17a40a-ce44-4141-bbc0-da3d558328f9", "Slider.Create", "SLIDER.CREATE" },
                    { 27, "669e251a-2361-4a3c-b71b-48925acd16f0", "Slider.Read", "SLIDER.READ" },
                    { 26, "0940d326-3248-4ef2-809e-84361e5ab11f", "Profil.Delete", "PROFIL.DELETE" },
                    { 25, "0fed2810-86da-4d82-aa12-6cc75eec82b0", "Profil.Update", "PROFIL.UPDATE" },
                    { 29, "15cae723-93f4-465b-8ac3-0f5cc173fa10", "Slider.Update", "SLIDER.UPDATE" },
                    { 23, "ab5b4986-c0cf-411b-a27c-88f07a1c3d2d", "Profil.Read", "PROFIL.READ" },
                    { 24, "1c63e6d2-91d4-410d-b218-b39668b7e8c0", "Profil.Create", "PROFIL.CREATE" },
                    { 15, "ef2b9042-da14-449d-8351-cd827a3c0dc7", "Role.Update", "ROLE.UPDATE" },
                    { 16, "6c29afee-a274-4744-8c7a-471069656653", "Role.Delete", "ROLE.DELETE" },
                    { 17, "72452279-ef17-428f-884d-bd0f28c39471", "Comment.Create", "COMMENT.CREATE" },
                    { 91, "a852cab4-cdc5-4839-8f50-eeead7e0fbb3", "Ürün Oku", "ÜRÜN OKU" },
                    { 19, "70b48ee5-5c0d-4c5f-8cfe-71c7883c6828", "Comment.Update", "COMMENT.UPDATE" },
                    { 20, "4d5cc254-1612-441b-84f8-bdcfd61790bb", "Comment.Delete", "COMMENT.DELETE" },
                    { 21, "f3326944-aeed-406e-8aea-c2dcc3a9d3c7", "AdminArea.Home.Read", "ADMINAREA.HOME.READ" },
                    { 22, "785ae55a-6ed3-463b-b2ae-ed0920af8e37", "SuperAdmin", "SUPERADMIN" },
                    { 18, "c4a5f23a-f18e-4a89-8a7a-a13e8f761af7", "Comment.Read", "COMMENT.READ" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Color", "ConcurrencyStamp", "Email", "EmailConfirmed", "FacebookLink", "FirstName", "GitHubLink", "InstagramLink", "IsDentist", "LastName", "LinkedInLink", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwitterLink", "TwoFactorEnabled", "UserName", "WebsiteLink", "YoutubeLink" },
                values: new object[,]
                {
                    { 2, "Admin User of ProgrammersBlog", 0, "", "53b7d8f3-150d-4c9d-b68a-1980ed5852fa", "adminuser1@gmail.com", true, "https://facebook.com/editoruser", "Admin", "https://github.com/editoruser", "https://instagram.com/editoruser", false, "User", "https://linkedin.com/editoruser", false, null, "ADMINUSER1@GMAIL.COM", "ADMINUSER1", "AQAAAAEAACcQAAAAEByodIbwoLSSMTurgXkHv6i8dMiHJQB6OuZMrgB1WYD9z8u64/HUU1UXd6Hk2XaA7g==", "+905555555555", true, "/userImages/defaultUser.png", "c4c1c2cb-951c-46b3-8895-0f36f5b285ec", "https://twitter.com/editoruser", false, "adminuser1", "https://programmersblog.com/", "https://youtube.com/editoruser" },
                    { 3, "Admin User of ProgrammersBlog", 0, "", "8a04f240-d499-43ca-9533-916cf54f8028", "adminuser2@gmail.com", true, "https://facebook.com/editoruser", "Admin", "https://github.com/editoruser", "https://instagram.com/editoruser", false, "User", "https://linkedin.com/editoruser", false, null, "ADMINUSER2@GMAIL.COM", "ADMINUSER2", "AQAAAAEAACcQAAAAECq2p2ZT32U9eFbS2quNiiBFVUru9pi7gRatDd3NLzgvI7rF0AaURdPBMUjSQa54IA==", "+905555555555", true, "/userImages/defaultUser.png", "3de716ea-708b-43b1-bb53-90a05edf2e27", "https://twitter.com/editoruser", false, "adminuser2", "https://programmersblog.com/", "https://youtube.com/editoruser" },
                    { 5, "Secretary User  of TigrisTech Blog", 0, "", "c521c9df-ed70-40ba-b54e-c4d84124786c", "secretaryuser@gmail.com", true, "https://facebook.com/adminuser", "Secretary", "https://github.com/adminuser", "https://instagram.com/adminuser", false, "User", "https://linkedin.com/adminuser", false, null, "SECRETARYUSER@GMAIL.COM", "SECRETARYUSER", "AQAAAAEAACcQAAAAEB1tfw8loVS1Op7OHkc1lMzei0xq/37ChbP9nxTL4puqk5NNMK+MUNtRPNSJpaxK/Q==", "+905555555555", true, "/userImages/defaultUser.png", "c52edf27-0cdc-4cf0-b033-297c347c370c", "https://twitter.com/adminuser", false, "secretaryuser", "https://programmersblog.com/", "https://youtube.com/adminuser" },
                    { 4, "Editor User of ProgrammersBlog", 0, "", "c4ca7baf-86fb-4c5e-a04b-22ea09984060", "editorUser@gmail.com", true, "https://facebook.com/editoruser", "Editor", "https://github.com/editoruser", "https://instagram.com/editoruser", false, "User", "https://linkedin.com/editoruser", false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEEElm7I+bKnmI377zquTd5pGXN3t0fTIbM66kYs+nDLVbCYmrPW57GuknlD298xNtw==", "+905555555555", true, "/userImages/defaultUser.png", "13858640-c84e-4147-8e60-21824ae564c4", "https://twitter.com/editoruser", false, "editorUser", "https://programmersblog.com/", "https://youtube.com/editoruser" },
                    { 6, "Estetisyen User 1 of TigrisTech Blog", 0, "red", "a9752adb-f5cd-4b82-8331-68d46b3e9e0f", "estetisyenuser1@gmail.com", true, "https://facebook.com/adminuser", "Estetisyen", "https://github.com/adminuser", "https://instagram.com/adminuser", true, "User 1", "https://linkedin.com/adminuser", false, null, "ESTETISYENUSER1@GMAIL.COM", "ESTETISYENUSER1", "AQAAAAEAACcQAAAAEAWO5e4TOtBrfT0V0j/hb9wCZT/ADL1CaqoHxh2iY9mIrcAKW08qyvrk53t4EfgSkQ==", "+905555555555", true, "/userImages/defaultUser.png", "111aee15-4bea-4092-821a-505605033bbd", "https://twitter.com/adminuser", false, "estetisyenuser1", "https://programmersblog.com/", "https://youtube.com/adminuser" },
                    { 7, "Estetisyen User 2 of TigrisTech Blog", 0, "blue", "82f8ce70-6677-44e1-890c-8f151338356b", "estetisyenuser2@gmail.com", true, "https://facebook.com/adminuser", "Estetisyen", "https://github.com/adminuser", "https://instagram.com/adminuser", true, "User 2", "https://linkedin.com/adminuser", false, null, "ESTETISYENUSER2@GMAIL.COM", "ESTETISYENUSER2", "AQAAAAEAACcQAAAAEOPkzk4jJrqrMe3gSvgoO4HZwUSvb4yh3w1T1Jl3m/0IGL0BuHo5Hw7vvDzzO/5zGQ==", "+905555555555", true, "/userImages/defaultUser.png", "3fc7e7db-aa40-44fd-a1b0-e6d618827345", "https://twitter.com/adminuser", false, "estetisyenuser2", "https://programmersblog.com/", "https://youtube.com/adminuser" },
                    { 8, "Estetisyen User 3 of TigrisTech Blog", 0, "orange", "296be42e-b2a5-4e93-8646-e60af3078314", "estetisyenuser3@gmail.com", true, "https://facebook.com/adminuser", "Estetisyen3", "https://github.com/adminuser", "https://instagram.com/adminuser", true, "User 3", "https://linkedin.com/adminuser", false, null, "ESTETISUYENUSER3@GMAIL.COM", "ESTETISYENUSER3", "AQAAAAEAACcQAAAAEMm0bxejIF7U8ddsw3LPj5Ny3+/+gZI/czRjOSOHOLDiZj0V7PLaACvF5HzRmLViGg==", "+905555555555", true, "/userImages/defaultUser.png", "dccf2441-40c6-4fdb-a981-c3ecada5d420", "https://twitter.com/adminuser", false, "estetisyenuser3", "https://programmersblog.com/", "https://youtube.com/adminuser" },
                    { 1, "Super Admin  User Abdullah", 0, "", "68b19b14-e76c-4fa3-a625-cb9174d79eda", "adminuserabdullah@gmail.com", true, "https://facebook.com/adminuser", "Super Admin Abdullah", "https://github.com/adminuser", "https://instagram.com/adminuser", false, "User", "https://linkedin.com/adminuser", false, null, "SUPERADMINABDULLAH@GMAIL.COM", "SUPERADMINABDULLAH", "AQAAAAEAACcQAAAAELPrBOeIWUY41IuU87JTM+Jy0MZ0HZhzIirgd/3QzuZ/mAFviZYbR87/cz/TJK0ECw==", "+905555555555", true, "/userImages/defaultUser.png", "a36a0faa-be4d-4e95-94c9-98c9b78609b3", "https://twitter.com/adminuser", false, "adminuserabdullah", "https://programmersblog.com/", "https://youtube.com/adminuser" },
                    { 10, "Estetisyen User 5 of TigrisTech Blog", 0, "grey", "1fc8bfa4-6e4b-4bce-960e-7b5daeefebde", "estetisyenuser5@gmail.com", false, "https://facebook.com/adminuser", "ESTETISYEN5", "https://github.com/adminuser", "https://instagram.com/adminuser", true, "User 5", "https://linkedin.com/adminuser", false, null, "ESTETISYENUSER5@GMAIL.COM", "ESTETISYENUSER5", "AQAAAAEAACcQAAAAEMdPwtCWkZGBGdGVX4x2Wy//NODhHzPRD2z3EmL1T85OSUB/sjKQGj56h8LkuhZ0jw==", "+905555555555", true, "/userImages/defaultUser.png", "180f943d-9ea0-4b9e-9071-3b4b94664827", "https://twitter.com/adminuser", false, "estetisyenuser5", "https://programmersblog.com/", "https://youtube.com/adminuser" },
                    { 9, "Estetisyen User 4 of TigrisTech Blog", 0, "purple", "7ca97ce2-1a8d-464b-bd6b-8ad4203aba26", "estetisyenuser4@gmail.com", false, "https://facebook.com/adminuser", "Estetisyen4", "https://github.com/adminuser", "https://instagram.com/adminuser", true, "User 4", "https://linkedin.com/adminuser", false, null, "ESTETISYENUSER4@GMAIL.COM", "ESTETISYENUSER4", "AQAAAAEAACcQAAAAEOqKUtOuWuoYjOtRuxvQrrNEkp2bF/sJKQdB86Rpfc8ok+j8C+yLY7kT24BgT8/pcA==", "+905555555555", true, "/userImages/defaultUser.png", "b9dc5e09-3788-4079-8a7d-df06ef9419f8", "https://twitter.com/adminuser", false, "estetisyenuser4", "https://programmersblog.com/", "https://youtube.com/adminuser" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateByName", "CreateDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 10, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(4009), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(4010), "Ruby" },
                    { 2, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3943), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3944), "C++" },
                    { 3, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3948), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3949), "JavaScript" },
                    { 4, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3954), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3955), "Typescript" },
                    { 5, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3961), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3961), "Java" },
                    { 6, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3965), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3966), "Python" },
                    { 7, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3969), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3971), "Php" },
                    { 8, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(4001), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(4002), "Kotlin" },
                    { 9, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(4005), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(4006), "Swift" },
                    { 1, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3921), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 427, DateTimeKind.Local).AddTicks(3931), "C#" }
                });

            migrationBuilder.InsertData(
                table: "Galeries",
                columns: new[] { "Id", "CreateByName", "CreateDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Picture", "Title" },
                values: new object[,]
                {
                    { 2, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 418, DateTimeKind.Local).AddTicks(5526), "Diş Hastanemiz bekleme kısmı", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 418, DateTimeKind.Local).AddTicks(5527), "/galeryImages/defaultGalery.jpg", "Galery  2" },
                    { 3, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 418, DateTimeKind.Local).AddTicks(5531), "Diş Hastanemiz tedavi bölümü", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 418, DateTimeKind.Local).AddTicks(5532), "/galeryImages/defaultGalery.jpg", "Galery  3" },
                    { 1, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 418, DateTimeKind.Local).AddTicks(5024), "Diş Hastanemiz Lab kısmı", true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 418, DateTimeKind.Local).AddTicks(5365), "/galeryImages/defaultGalery.jpg", "Galery  1" }
                });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "About", "Address", "CreateByName", "CreateDate", "Email", "FacebookLink", "FirstName", "GitHubLink", "InstagramLink", "IsActive", "IsDeleted", "LastName", "LinkedInLink", "ModifiedByName", "ModifiedDate", "Phone", "Picture", "TcNo", "TwitterLink", "WebsiteLink", "YoutubeLink" },
                values: new object[] { 1, null, "Gül Tepe Mah.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 420, DateTimeKind.Local).AddTicks(5890), "dtEmin@gmail.com", "https://facebook.com/alikara", "Emin", "https://github.com/alikara", "https://instagram.com/alikara", true, false, "Kara", "https://linkedin.com/alikara", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 420, DateTimeKind.Local).AddTicks(5900), "+905555555555", "/profilImages/defaultProfil.jpg", "11111111111", "https://twitter.com/alikara", "https://programmersblog.com/", "https://youtube.com/alikara" });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "About", "Address", "CreateByName", "CreateDate", "Email", "FacebookLink", "FirstName", "GitHubLink", "InstagramLink", "IsActive", "IsDeleted", "LastName", "LinkedInLink", "ModifiedByName", "ModifiedDate", "Phone", "Picture", "TcNo", "TwitterLink", "WebsiteLink", "YoutubeLink" },
                values: new object[,]
                {
                    { 2, null, "Gül Tepe Mah.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 420, DateTimeKind.Local).AddTicks(5911), "nurcan@gmail.com", "https://facebook.com/fatmagunus", "Nurcan", "https://github.com/fatmagunus", "https://instagram.com/fatmagunus", true, false, "Güneş", "https://linkedin.com/fatmagunus", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 420, DateTimeKind.Local).AddTicks(5912), "+905555555555", "/profilImages/defaultProfil.jpg", "11111111111", "https://twitter.com/fatmagunus", "https://programmersblog.com/", "https://youtube.com/fatmagunus" },
                    { 3, null, "Gül Tepe Mah.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 420, DateTimeKind.Local).AddTicks(5916), "Aslı@gmail.com", "https://facebook.com/fatmagunus", "Aslı", "https://github.com/fatmagunus", "https://instagram.com/fatmagunus", true, false, "Tekin", "https://linkedin.com/fatmagunus", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 420, DateTimeKind.Local).AddTicks(5917), "+905555555555", "/profilImages/defaultProfil.jpg", "11111111111", "https://twitter.com/fatmagunus", "https://programmersblog.com/", "https://youtube.com/fatmagunus" }
                });

            migrationBuilder.InsertData(
                table: "Sldiers",
                columns: new[] { "Id", "CreateByName", "CreateDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Picture", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 421, DateTimeKind.Local).AddTicks(7770), null, true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 421, DateTimeKind.Local).AddTicks(7780), "/sliderImages/defaultSlider.jpg", "Diş  Temizleme" },
                    { 2, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 421, DateTimeKind.Local).AddTicks(7787), null, true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 421, DateTimeKind.Local).AddTicks(7788), null, "Diş  İplant" },
                    { 3, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 421, DateTimeKind.Local).AddTicks(7791), null, true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 421, DateTimeKind.Local).AddTicks(7792), null, "Diş  Zirkonyum" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreateByName", "CreateDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8025), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8275), "Hakim Kaya", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 1, 100 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8683), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8682), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8684), "Hakim Kaya", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 1, 295 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8689), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8688), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8690), "Hakim Kaya", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 1, 12 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8695), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8693), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8696), "Hakim Kaya", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 1, 666 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8699), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8701), "Hakim Kaya", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 1, 3225 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8705), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8707), "Hakim Kaya", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 1, 9999 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8710), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8713), "Hakim Kaya", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 1, 4818 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8718), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8716), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8718), "Hakim Kaya", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 1, 750 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8726), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8725), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8727), "Hakim Kaya", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 1, 14900 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8730), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 425, DateTimeKind.Local).AddTicks(8732), "Hakim Kaya", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 1, 26777 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 28, 4 },
                    { 29, 4 },
                    { 30, 4 },
                    { 31, 4 },
                    { 32, 4 },
                    { 39, 6 },
                    { 34, 4 },
                    { 90, 4 },
                    { 21, 6 },
                    { 27, 4 },
                    { 33, 4 },
                    { 26, 4 },
                    { 20, 4 },
                    { 24, 4 },
                    { 23, 4 },
                    { 21, 4 },
                    { 40, 6 },
                    { 19, 4 },
                    { 18, 4 },
                    { 17, 4 },
                    { 8, 4 },
                    { 7, 4 },
                    { 6, 4 },
                    { 5, 4 },
                    { 25, 4 },
                    { 41, 6 },
                    { 62, 6 },
                    { 59, 6 },
                    { 21, 7 },
                    { 86, 6 },
                    { 85, 6 },
                    { 84, 6 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 83, 6 },
                    { 82, 6 },
                    { 81, 6 },
                    { 80, 6 },
                    { 79, 6 },
                    { 78, 6 },
                    { 77, 6 },
                    { 42, 6 },
                    { 76, 6 },
                    { 74, 6 },
                    { 73, 6 },
                    { 72, 6 },
                    { 71, 6 },
                    { 70, 6 },
                    { 69, 6 },
                    { 68, 6 },
                    { 67, 6 },
                    { 4, 4 },
                    { 61, 6 },
                    { 60, 6 },
                    { 75, 6 },
                    { 3, 4 },
                    { 85, 5 },
                    { 1, 4 },
                    { 46, 5 },
                    { 45, 5 },
                    { 44, 5 },
                    { 43, 5 },
                    { 42, 5 },
                    { 41, 5 },
                    { 40, 5 },
                    { 39, 5 },
                    { 38, 5 },
                    { 37, 5 },
                    { 36, 5 },
                    { 47, 5 },
                    { 35, 5 },
                    { 102, 3 },
                    { 101, 3 },
                    { 100, 3 },
                    { 99, 3 },
                    { 98, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 97, 3 },
                    { 96, 3 },
                    { 95, 3 },
                    { 94, 3 },
                    { 93, 3 },
                    { 92, 3 },
                    { 21, 5 },
                    { 48, 5 },
                    { 49, 5 },
                    { 50, 5 },
                    { 88, 5 },
                    { 86, 5 },
                    { 39, 7 },
                    { 84, 5 },
                    { 83, 5 },
                    { 70, 5 },
                    { 69, 5 },
                    { 68, 5 },
                    { 67, 5 },
                    { 66, 5 },
                    { 65, 5 },
                    { 64, 5 },
                    { 63, 5 },
                    { 62, 5 },
                    { 61, 5 },
                    { 60, 5 },
                    { 59, 5 },
                    { 58, 5 },
                    { 57, 5 },
                    { 56, 5 },
                    { 55, 5 },
                    { 54, 5 },
                    { 53, 5 },
                    { 52, 5 },
                    { 51, 5 },
                    { 2, 4 },
                    { 40, 7 },
                    { 61, 7 },
                    { 42, 7 },
                    { 85, 9 },
                    { 84, 9 },
                    { 83, 9 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 82, 9 },
                    { 81, 9 },
                    { 80, 9 },
                    { 79, 9 },
                    { 78, 9 },
                    { 77, 9 },
                    { 76, 9 },
                    { 75, 9 },
                    { 86, 9 },
                    { 74, 9 },
                    { 72, 9 },
                    { 71, 9 },
                    { 70, 9 },
                    { 69, 9 },
                    { 68, 9 },
                    { 67, 9 },
                    { 62, 9 },
                    { 61, 9 },
                    { 60, 9 },
                    { 59, 9 },
                    { 42, 9 },
                    { 73, 9 },
                    { 41, 9 },
                    { 21, 10 },
                    { 40, 10 },
                    { 84, 10 },
                    { 83, 10 },
                    { 82, 10 },
                    { 81, 10 },
                    { 80, 10 },
                    { 79, 10 },
                    { 78, 10 },
                    { 77, 10 },
                    { 76, 10 },
                    { 75, 10 },
                    { 74, 10 },
                    { 39, 10 },
                    { 73, 10 },
                    { 71, 10 },
                    { 70, 10 },
                    { 69, 10 },
                    { 68, 10 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 67, 10 },
                    { 62, 10 },
                    { 61, 10 },
                    { 60, 10 },
                    { 59, 10 },
                    { 42, 10 },
                    { 41, 10 },
                    { 72, 10 },
                    { 40, 9 },
                    { 39, 9 },
                    { 21, 9 },
                    { 86, 7 },
                    { 85, 7 },
                    { 84, 7 },
                    { 83, 7 },
                    { 82, 7 },
                    { 81, 7 },
                    { 80, 7 },
                    { 79, 7 },
                    { 78, 7 },
                    { 77, 7 },
                    { 76, 7 },
                    { 21, 8 },
                    { 75, 7 },
                    { 73, 7 },
                    { 72, 7 },
                    { 71, 7 },
                    { 70, 7 },
                    { 69, 7 },
                    { 68, 7 },
                    { 67, 7 },
                    { 62, 7 },
                    { 91, 3 },
                    { 60, 7 },
                    { 59, 7 },
                    { 74, 7 },
                    { 39, 8 },
                    { 40, 8 },
                    { 41, 8 },
                    { 86, 8 },
                    { 85, 8 },
                    { 84, 8 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 83, 8 },
                    { 82, 8 },
                    { 81, 8 },
                    { 80, 8 },
                    { 79, 8 },
                    { 78, 8 },
                    { 77, 8 },
                    { 76, 8 },
                    { 75, 8 },
                    { 74, 8 },
                    { 73, 8 },
                    { 72, 8 },
                    { 71, 8 },
                    { 70, 8 },
                    { 69, 8 },
                    { 68, 8 },
                    { 67, 8 },
                    { 62, 8 },
                    { 61, 8 },
                    { 60, 8 },
                    { 59, 8 },
                    { 42, 8 },
                    { 41, 7 },
                    { 89, 3 },
                    { 84, 3 },
                    { 87, 3 },
                    { 81, 1 },
                    { 80, 1 },
                    { 79, 1 },
                    { 78, 1 },
                    { 77, 1 },
                    { 76, 1 },
                    { 75, 1 },
                    { 74, 1 },
                    { 73, 1 },
                    { 72, 1 },
                    { 71, 1 },
                    { 82, 1 },
                    { 70, 1 },
                    { 68, 1 },
                    { 67, 1 },
                    { 66, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 65, 1 },
                    { 64, 1 },
                    { 63, 1 },
                    { 62, 1 },
                    { 61, 1 },
                    { 60, 1 },
                    { 59, 1 },
                    { 58, 1 },
                    { 69, 1 },
                    { 57, 1 },
                    { 83, 1 },
                    { 85, 1 },
                    { 40, 2 },
                    { 39, 2 },
                    { 38, 2 },
                    { 37, 2 },
                    { 36, 2 },
                    { 35, 2 },
                    { 21, 2 },
                    { 102, 1 },
                    { 101, 1 },
                    { 100, 1 },
                    { 99, 1 },
                    { 84, 1 },
                    { 98, 1 },
                    { 96, 1 },
                    { 95, 1 },
                    { 94, 1 },
                    { 93, 1 },
                    { 92, 1 },
                    { 91, 1 },
                    { 90, 1 },
                    { 89, 1 },
                    { 88, 1 },
                    { 87, 1 },
                    { 86, 1 },
                    { 97, 1 },
                    { 56, 1 },
                    { 55, 1 },
                    { 54, 1 },
                    { 24, 1 },
                    { 23, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 22, 1 },
                    { 21, 1 },
                    { 20, 1 },
                    { 19, 1 },
                    { 18, 1 },
                    { 17, 1 },
                    { 16, 1 },
                    { 15, 1 },
                    { 14, 1 },
                    { 25, 1 },
                    { 13, 1 },
                    { 11, 1 },
                    { 10, 1 },
                    { 9, 1 },
                    { 8, 1 },
                    { 7, 1 },
                    { 6, 1 },
                    { 5, 1 },
                    { 4, 1 },
                    { 3, 1 },
                    { 2, 1 },
                    { 1, 1 },
                    { 12, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 28, 1 },
                    { 53, 1 },
                    { 52, 1 },
                    { 51, 1 },
                    { 50, 1 },
                    { 49, 1 },
                    { 48, 1 },
                    { 47, 1 },
                    { 46, 1 },
                    { 45, 1 },
                    { 44, 1 },
                    { 43, 1 },
                    { 42, 1 },
                    { 41, 1 },
                    { 40, 1 },
                    { 39, 1 },
                    { 38, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 37, 1 },
                    { 36, 1 },
                    { 35, 1 },
                    { 34, 1 },
                    { 33, 1 },
                    { 32, 1 },
                    { 31, 1 },
                    { 30, 1 },
                    { 29, 1 },
                    { 41, 2 },
                    { 42, 2 },
                    { 43, 2 },
                    { 44, 2 },
                    { 57, 3 },
                    { 56, 3 },
                    { 55, 3 },
                    { 54, 3 },
                    { 53, 3 },
                    { 52, 3 },
                    { 51, 3 },
                    { 50, 3 },
                    { 49, 3 },
                    { 48, 3 },
                    { 47, 3 },
                    { 58, 3 },
                    { 46, 3 },
                    { 44, 3 },
                    { 43, 3 },
                    { 42, 3 },
                    { 41, 3 },
                    { 40, 3 },
                    { 39, 3 },
                    { 38, 3 },
                    { 37, 3 },
                    { 36, 3 },
                    { 35, 3 },
                    { 21, 3 },
                    { 45, 3 },
                    { 59, 3 },
                    { 60, 3 },
                    { 61, 3 },
                    { 86, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 85, 3 },
                    { 85, 10 },
                    { 83, 3 },
                    { 82, 3 },
                    { 81, 3 },
                    { 80, 3 },
                    { 79, 3 },
                    { 78, 3 },
                    { 77, 3 },
                    { 76, 3 },
                    { 75, 3 },
                    { 74, 3 },
                    { 73, 3 },
                    { 72, 3 },
                    { 71, 3 },
                    { 70, 3 },
                    { 69, 3 },
                    { 68, 3 },
                    { 67, 3 },
                    { 66, 3 },
                    { 65, 3 },
                    { 64, 3 },
                    { 63, 3 },
                    { 62, 3 },
                    { 102, 2 },
                    { 88, 3 },
                    { 101, 2 },
                    { 99, 2 },
                    { 68, 2 },
                    { 67, 2 },
                    { 66, 2 },
                    { 65, 2 },
                    { 64, 2 },
                    { 63, 2 },
                    { 62, 2 },
                    { 61, 2 },
                    { 60, 2 },
                    { 59, 2 },
                    { 58, 2 },
                    { 69, 2 },
                    { 57, 2 },
                    { 55, 2 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 54, 2 },
                    { 53, 2 },
                    { 52, 2 },
                    { 51, 2 },
                    { 50, 2 },
                    { 49, 2 },
                    { 48, 2 },
                    { 47, 2 },
                    { 46, 2 },
                    { 45, 2 },
                    { 56, 2 },
                    { 70, 2 },
                    { 71, 2 },
                    { 72, 2 },
                    { 98, 2 },
                    { 97, 2 },
                    { 96, 2 },
                    { 95, 2 },
                    { 94, 2 },
                    { 93, 2 },
                    { 92, 2 },
                    { 91, 2 },
                    { 89, 2 },
                    { 88, 2 },
                    { 87, 2 },
                    { 86, 2 },
                    { 85, 2 },
                    { 84, 2 },
                    { 83, 2 },
                    { 82, 2 },
                    { 81, 2 },
                    { 80, 2 },
                    { 79, 2 },
                    { 78, 2 },
                    { 77, 2 },
                    { 76, 2 },
                    { 75, 2 },
                    { 74, 2 },
                    { 73, 2 },
                    { 100, 2 },
                    { 86, 10 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreateByName", "CreateDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Text" },
                values: new object[,]
                {
                    { 1, 1, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(68), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(76), "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır." },
                    { 2, 2, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(83), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(84), "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker" },
                    { 3, 3, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(87), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(88), "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum." },
                    { 4, 4, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(91), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(92), "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst." },
                    { 5, 5, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(94), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(95), "Lorem Ipsum este pur şi simplu o machetă pentru text a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum." },
                    { 6, 6, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(98), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(99), "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a." },
                    { 7, 7, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(102), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(103), "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts." },
                    { 8, 8, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(107), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(108), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)." },
                    { 9, 9, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(111), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(112), "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت." },
                    { 10, 10, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(115), true, false, "InitialCreate", new DateTime(2024, 3, 21, 15, 48, 25, 429, DateTimeKind.Local).AddTicks(116), "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Galeries");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Profils");

            migrationBuilder.DropTable(
                name: "Sldiers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
