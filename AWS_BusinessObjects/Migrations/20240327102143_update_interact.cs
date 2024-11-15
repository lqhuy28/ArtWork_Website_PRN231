using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class update_interact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interacts_AspNetUsers_ApplicationUserId",
                table: "Interacts");

            migrationBuilder.DropIndex(
                name: "IX_Interacts_ApplicationUserId",
                table: "Interacts");

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("1cc24e6a-2346-4871-bc5b-f05ab0cfb506"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("a53c5a0f-a45c-49f5-b14a-5bb5e4df6096"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("d6af9c10-5091-4334-9142-0d0cf16d63ff"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("2349de24-cd57-472a-9386-5fa0a04546d8"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("41c86f37-5bde-4614-a8d1-f93f7e24c2da"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("063a2723-5c40-4b3d-98a0-3d53b2ec898d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("65dd7003-65ba-4e9a-91e8-bad26c267cb0"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c2ab-1da7-4779-9891-8a362a25bad0"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("78adffc6-da3b-48f0-9ae3-122f8a3b0819"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("86baf719-84db-42fd-97fc-76cca75137aa"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("8e329e08-e700-46fb-9ef7-276002800b59"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("90c0bd5a-c9cd-4399-b20c-043a012ec944"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("d805999d-84cf-4f91-9954-853004a5f459"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e4286c2d-6ece-4c45-837e-3216cd8c89dc"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("f19cfe37-08bd-43ba-9641-023311ff11cb"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Interacts");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Interacts");

            migrationBuilder.AlterColumn<bool>(
                name: "IsLike",
                table: "Interacts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "UserAccountId",
                table: "Interacts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("4f98d43f-e5a0-433d-b9a4-770f12380ad6"), new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2455), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" },
                    { new Guid("51b6187b-d07c-4296-8475-cf3abd938e38"), new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2457), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("8aaf6d84-410c-48d7-ad7c-5d70ce095e30"), new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2449), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28c1b75a-424d-43a7-8a51-eb53bffc48da", "d51ebd6f-02ac-4fc7-9f24-3e1f481f29eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2edb30fe-5b2d-41f0-ae21-fa7c86c51798", "f0b70d44-47d0-4202-b57a-21c566dc2d3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2014f2e9-5ee3-49b0-9e2a-5b91cad50e27", "b78c2da4-ff79-48f0-a1c1-86fda6320749" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "538a6f62-9592-4398-adde-9c5142889db7", "5118f7e6-5e21-444d-9e3c-68a7f1dc8be4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4994d63b-7189-4f40-b67a-646399450712", "07a2238f-b8c0-40ab-b891-691685feae70" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("1656ab00-86aa-466f-93c7-56eb2a7d7e69"), new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2477), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("eec442a9-ead8-4ad1-9230-f5506a0dcea6"), new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2474), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ArtWorkID", "Comment", "Created", "CreatedBy", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("0cfc7443-e9cb-4167-9621-75a194a3371f"), new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2559), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("13af3978-3d66-4f60-9ee0-8cb1e5fc5640"), new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2576), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("1e207d4d-2fe6-4198-ae38-7c66b6e0b719"), new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2580), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("27cc3dae-f887-4990-9f97-f3c8bd097449"), new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2573), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("4c69f73d-0f6c-420f-a083-b87e6e2b0771"), new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2599), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("58b7083e-2df0-4f5a-b4ac-79ae4b6902ed"), new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2564), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("9fe6018a-55cb-417a-938b-092c77aa8d11"), new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2595), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("cd804807-65b7-4310-988e-94227f16fe92"), new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2568), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("d9bc8bda-6b08-4534-8522-49a26f9e64a9"), new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2592), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("e520675c-d9fc-4f02-926e-30701b8d3cae"), new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 27, 17, 21, 43, 572, DateTimeKind.Local).AddTicks(2587), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_UserAccountId",
                table: "Interacts",
                column: "UserAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interacts_AspNetUsers_UserAccountId",
                table: "Interacts",
                column: "UserAccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interacts_AspNetUsers_UserAccountId",
                table: "Interacts");

            migrationBuilder.DropIndex(
                name: "IX_Interacts_UserAccountId",
                table: "Interacts");

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("4f98d43f-e5a0-433d-b9a4-770f12380ad6"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("51b6187b-d07c-4296-8475-cf3abd938e38"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("8aaf6d84-410c-48d7-ad7c-5d70ce095e30"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("1656ab00-86aa-466f-93c7-56eb2a7d7e69"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("eec442a9-ead8-4ad1-9230-f5506a0dcea6"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("0cfc7443-e9cb-4167-9621-75a194a3371f"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("13af3978-3d66-4f60-9ee0-8cb1e5fc5640"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("1e207d4d-2fe6-4198-ae38-7c66b6e0b719"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("27cc3dae-f887-4990-9f97-f3c8bd097449"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("4c69f73d-0f6c-420f-a083-b87e6e2b0771"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("58b7083e-2df0-4f5a-b4ac-79ae4b6902ed"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("9fe6018a-55cb-417a-938b-092c77aa8d11"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("cd804807-65b7-4310-988e-94227f16fe92"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("d9bc8bda-6b08-4534-8522-49a26f9e64a9"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e520675c-d9fc-4f02-926e-30701b8d3cae"));

            migrationBuilder.DropColumn(
                name: "UserAccountId",
                table: "Interacts");

            migrationBuilder.AlterColumn<bool>(
                name: "IsLike",
                table: "Interacts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Interacts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Interacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("1cc24e6a-2346-4871-bc5b-f05ab0cfb506"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8279), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("a53c5a0f-a45c-49f5-b14a-5bb5e4df6096"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8273), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("d6af9c10-5091-4334-9142-0d0cf16d63ff"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8276), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c2afef9-58dd-4e6c-8d1c-2aaebfae32c7", "b42c3d98-0910-409e-8553-aaaca7c125b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "402cdb70-10b8-4c68-bec3-13000b656cef", "6189db8f-272b-461c-8c71-c28d626f449a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26e6ab37-15ff-4f75-9d08-ab6ae3f77747", "288fe1ed-1e7c-4705-ac6d-fa58c5fa8ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b942ed3c-53b6-4c85-9d93-4e7ce1b3c554", "7f79e2ed-6cb6-44f3-b83a-7e696faafb44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "442a02ed-1f08-4da8-9d99-9c7ce4d975f8", "2be6b765-c6da-496f-935d-b0cae2bc38ca" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("2349de24-cd57-472a-9386-5fa0a04546d8"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8298), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("41c86f37-5bde-4614-a8d1-f93f7e24c2da"), new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8304), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ApplicationUserId", "ArtWorkID", "Comment", "Created", "CreatedBy", "Date", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("063a2723-5c40-4b3d-98a0-3d53b2ec898d"), null, new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8474), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8475), false, true, null, null },
                    { new Guid("65dd7003-65ba-4e9a-91e8-bad26c267cb0"), null, new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8496), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8497), false, true, null, null },
                    { new Guid("6cd1c2ab-1da7-4779-9891-8a362a25bad0"), null, new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8459), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8460), false, true, null, null },
                    { new Guid("78adffc6-da3b-48f0-9ae3-122f8a3b0819"), null, new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8484), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8485), false, true, null, null },
                    { new Guid("86baf719-84db-42fd-97fc-76cca75137aa"), null, new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8488), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8489), false, true, null, null },
                    { new Guid("8e329e08-e700-46fb-9ef7-276002800b59"), null, new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8466), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8467), false, true, null, null },
                    { new Guid("90c0bd5a-c9cd-4399-b20c-043a012ec944"), null, new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8478), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8479), false, true, null, null },
                    { new Guid("d805999d-84cf-4f91-9954-853004a5f459"), null, new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8492), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8493), false, true, null, null },
                    { new Guid("e4286c2d-6ece-4c45-837e-3216cd8c89dc"), null, new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8453), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8456), false, true, null, null },
                    { new Guid("f19cfe37-08bd-43ba-9641-023311ff11cb"), null, new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8470), null, new DateTime(2024, 3, 27, 4, 3, 51, 934, DateTimeKind.Local).AddTicks(8471), false, true, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interacts_ApplicationUserId",
                table: "Interacts",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interacts_AspNetUsers_ApplicationUserId",
                table: "Interacts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
