using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AdminAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminAccount_AspNetUsers_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistAccount_AspNetUsers_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AudienceAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudienceAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AudienceAccount_AspNetUsers_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    applicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserAccountID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAccountIDReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_applicationUserId",
                        column: x => x.applicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtWorks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserOwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtWorkStatus = table.Column<int>(type: "int", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    IsPreOrder = table.Column<bool>(type: "bit", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtWorks_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArtWorks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtWorkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interacts_ArtWorks_ArtWorkID",
                        column: x => x.ArtWorkID,
                        principalTable: "ArtWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interacts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtWorkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_ArtWorks_ArtWorkID",
                        column: x => x.ArtWorkID,
                        principalTable: "ArtWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtWorkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_ArtWorks_ArtWorkID",
                        column: x => x.ArtWorkID,
                        principalTable: "ArtWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishLists_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cf", 0, null, "f3f05e8c-bcab-44f5-91db-6b70ceb5c81f", "hieu123@gmail.com", false, false, null, null, null, "TRANHIEU1", null, null, false, "140cacd6-571b-4f0a-8c25-26654e26d96f", false, "TranHieu1" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cg", 0, null, "ce3dfe14-3cd2-4ce5-a0e5-fe99e1f1e1ee", "hieuaccount2@gmail.com", false, false, null, null, null, "TRANHIEU2", null, null, false, "279aa2a4-b729-4b07-ad2f-765e165e062b", false, "TranHieu2" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866ch", 0, null, "a02f62a7-22d9-45a2-b2fd-b9837e7e379b", "hieuaccount3@gmail.com", false, false, null, null, null, "TRANHIEU3", null, null, false, "605ff71d-3455-4001-8939-ee94022162c0", false, "TranHieu3" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866ci", 0, null, "081e35f5-477e-4116-8c3d-f468f4578bf9", "hieuaccount4@gmail.com", false, false, null, null, null, "TRANHIEU4", null, null, false, "530e329b-fbcb-4119-802a-afda0d753dbe", false, "TranHieu4" },
                    { "871a809a-b3fa-495b-9cc2-c5d738a866cj", 0, null, "fc4a9a4f-5dfc-40cd-98fd-b2ac2c5e1b2f", "hieuaccount5@gmail.com", false, false, null, null, null, "TRANHIEU5", null, null, false, "80f0da9c-8906-4848-9fb7-090c16da0f81", false, "TranHieu5" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Created", "CreatedBy", "Description", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"), "Category 6", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7516), null, "Description Category 6", false, null, null },
                    { new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"), "Category 3", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7498), null, "Description Category 3", false, null, null },
                    { new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"), "Category 4", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7500), null, "Description Category 4", false, null, null },
                    { new Guid("5d935698-bc0f-4692-88a3-43234943be40"), "Category 5", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7514), null, "Description Category 5", false, null, null },
                    { new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"), "Category 1", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7467), null, "Description Category 1", false, null, null },
                    { new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"), "Category 2", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7495), null, "Description Category 2", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "ArtWorks",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkStatus", "CategoryId", "Created", "CreatedBy", "Description", "ImageUrl", "IsDeleted", "IsPreOrder", "IsSold", "LastModified", "LastModifiedBy", "Name", "Price", "UserAccountId", "UserOwnerId" },
                values: new object[,]
                {
                    { new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), null, 1, new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7871), null, "Description 8", "https://scontent.fsgn5-3.fna.fbcdn.net/v/t1.6435-9/191815536_1305384429858113_8269960277638413432_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=FYh3OT-x0AIAX-Z3VNM&_nc_ht=scontent.fsgn5-3.fna&oh=00_AfCifetKtGNeQBaVh8Yrx3lnW3U1CxznHdMAZMB1a1w5XA&oe=6623B508", false, false, false, null, null, "ArtWork 8", 800f, "871a809a-b3fa-495b-9cc2-c5d738a866ci", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), null, 1, new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7844), null, "Description 2", "https://i.ebayimg.com/images/g/pAUAAOSw5yJjhMYl/s-l1200.webp", false, true, false, null, null, "ArtWork 2", 200f, "871a809a-b3fa-495b-9cc2-c5d738a866cf", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), null, 1, new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7853), null, "Description 4", "https://studio.pinotspalette.com/naperville/images/nap-uniquevangogh.jpg", false, false, false, null, null, "ArtWork 4", 400f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), null, 1, new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7848), null, "Description 3", "https://media.takealot.com/covers_images/0e56acf396604d34ac7c414b287c7cd7/s-pdpxl.file", false, true, false, null, null, "ArtWork 3", 300f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), null, 1, new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7838), null, "Description 1", "https://img.cdn-pictorem.com/uploads/collection/D/DN4DFF8JRC/900_Nature-Art_10.jpg", false, false, false, null, null, "ArtWork 1", 100f, "871a809a-b3fa-495b-9cc2-c5d738a866cf", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), null, 1, new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7876), null, "Description 9", "https://scontent.fsgn5-11.fna.fbcdn.net/v/t1.6435-9/107542684_1068121206917771_2494785157216852040_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=o9rZ89Am3UEAX-VFzIF&_nc_ht=scontent.fsgn5-11.fna&oh=00_AfCNUsxrhFPBP5F0Yu-A-dnY-gT2TF8zwifP0MFBwfUTgQ&oe=66239792", false, true, false, null, null, "ArtWork 9", 900f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), null, 1, new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7857), null, "Description 5", "https://www.singulart.com/images/artworks/v2/cropped/2479/main/carousel/1844446_b5d87c0efe493d715a1d57f480131a2f.jpeg", false, false, false, null, null, "ArtWork 5", 500f, "871a809a-b3fa-495b-9cc2-c5d738a866cj", "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), null, 1, new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7863), null, "Description 6", "https://images.saatchiart.com/saatchi/1093024/art/4707641/3777473-FIDYEXAV-7.jpg", false, false, false, null, null, "ArtWork 6", 600f, "871a809a-b3fa-495b-9cc2-c5d738a866cj", "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), null, 1, new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7867), null, "Description 7", "https://images.saatchiart.com/saatchi/770124/art/8867466/7930834-HSC00923-7.jpg", false, false, false, null, null, "ArtWork 7", 700f, "871a809a-b3fa-495b-9cc2-c5d738a866ci", "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), null, 1, new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7880), null, "Description 10", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Vincent_Willem_van_Gogh_127.jpg/270px-Vincent_Willem_van_Gogh_127.jpg", false, true, false, null, null, "ArtWork 10", 1000f, "871a809a-b3fa-495b-9cc2-c5d738a866cg", "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("2faf0458-3928-4f00-832e-93bd1a425a06"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7789), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("725cc757-35ab-4adc-8aed-c6e6f1b08f64"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7786), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("b7b9068a-a245-4b34-bc6d-104e1f69d561"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7791), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" }
                });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("1e1f085d-2998-49ad-ad0d-9b182b610d11"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7815), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("f6b83e57-e360-4537-8368-27a3c98be349"), new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7812), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("3381518e-0176-469c-be6c-bd5fc445050a"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7901), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7904), false, true, null, null },
                    { new Guid("44094f36-f103-4cd6-86d4-f89023546393"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7909), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7910), false, true, null, null },
                    { new Guid("63b6f510-dda3-41ff-927a-21fc38d3167c"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7929), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7931), false, true, null, null },
                    { new Guid("641b9768-1a0b-4fdc-9b34-6ba140818acd"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7937), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7938), false, true, null, null },
                    { new Guid("b1080d50-33e4-415b-9984-e8e919d37e66"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7926), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7927), false, true, null, null },
                    { new Guid("b1ceff87-8c0d-480b-8f98-bf17d864bc01"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7917), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7918), false, true, null, null },
                    { new Guid("c1f3d88a-212c-4694-b6c8-accce65bedf6"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7913), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7914), false, true, null, null },
                    { new Guid("c345caa7-8138-4c2f-b623-d71e801becce"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7942), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7944), false, true, null, null },
                    { new Guid("d29dc285-e9f0-4af4-b045-6d8fc0a18caa"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7920), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7921), false, true, null, null },
                    { new Guid("f6445393-e4d5-4814-85b5-de8163d76eaf"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7933), null, new DateTime(2024, 3, 26, 19, 33, 55, 331, DateTimeKind.Local).AddTicks(7934), false, true, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminAccount_UserAccountId",
                table: "AdminAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAccount_UserAccountId",
                table: "ArtistAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_ApplicationUserId",
                table: "ArtWorks",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_CategoryId",
                table: "ArtWorks",
                column: "CategoryId");

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
                name: "IX_AudienceAccount_UserAccountId",
                table: "AudienceAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_ApplicationUserId",
                table: "Interacts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_ArtWorkID",
                table: "Interacts",
                column: "ArtWorkID");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ArtWorkID",
                table: "Orders",
                column: "ArtWorkID");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_applicationUserId",
                table: "Reports",
                column: "applicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ApplicationUserId",
                table: "WishLists",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ArtWorkID",
                table: "WishLists",
                column: "ArtWorkID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAccount");

            migrationBuilder.DropTable(
                name: "ArtistAccount");

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
                name: "AudienceAccount");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Interacts");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ArtWorks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
