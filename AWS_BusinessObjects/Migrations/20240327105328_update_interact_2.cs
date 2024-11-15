using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class update_interact_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("0d0b964d-c45a-4f1e-b663-580e7761b4cd"), new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5832), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("98cd1cbc-6a35-4aa0-a747-fe67eeefa7cf"), new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5842), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("d76d97f2-240d-4f8b-a178-9c2c83279a8f"), new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5836), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84407c02-2be8-4e3e-8248-061ddca305be", "0aa50e16-c2a5-4499-a608-a1215f449e98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22ddcbd7-2fc8-4f02-b658-39297814ddad", "8768091a-b638-40c1-b142-a1d2d7727b4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15a047e8-8466-477d-b551-11f8e50c2aa8", "d78ecc56-ac09-46a4-b6df-88414461b7c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98f04637-436c-4a88-b7e7-800ce56edca4", "9b17f9aa-6718-436e-9d1d-34a71df42886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "266d41c8-ac0e-4c11-9db4-232df69793e6", "9d1013ca-8e51-4031-893e-0645bb74408c" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("40cbf986-2bff-4124-9fa3-b880c2763fdf"), new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5861), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" },
                    { new Guid("49dcf2a1-8c9e-42cb-bfa7-3682cde85be3"), new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5858), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ArtWorkID", "Comment", "Created", "CreatedBy", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("019a2678-dd59-4963-8e1b-ae19677946a8"), new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(6028), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("11f567ea-a779-4f88-b133-38815dda0cd8"), new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(6003), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("1dca80c5-25fd-4dbd-83bf-36709d4b0689"), new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(6008), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("39d23551-dade-421e-9913-c6d47cc012ff"), new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5996), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("4324b51a-1d14-4353-9d14-3509a2d843ce"), new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5999), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("96049f0b-d72f-4a55-a48f-1577e460a61d"), new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(6024), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("a964d335-57b0-470c-8969-5a467a5d26d3"), new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(6012), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("b24f1ec1-2df1-4629-9e89-02e8188df6ff"), new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(5991), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("b8d91bfa-a0ab-4942-8b0c-ae433d0ea58a"), new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(6019), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("c8105254-0ff6-4107-bc17-a5dddeaa5d05"), new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 27, 17, 53, 28, 369, DateTimeKind.Local).AddTicks(6015), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("0d0b964d-c45a-4f1e-b663-580e7761b4cd"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("98cd1cbc-6a35-4aa0-a747-fe67eeefa7cf"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("d76d97f2-240d-4f8b-a178-9c2c83279a8f"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("40cbf986-2bff-4124-9fa3-b880c2763fdf"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("49dcf2a1-8c9e-42cb-bfa7-3682cde85be3"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("019a2678-dd59-4963-8e1b-ae19677946a8"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("11f567ea-a779-4f88-b133-38815dda0cd8"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("1dca80c5-25fd-4dbd-83bf-36709d4b0689"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("39d23551-dade-421e-9913-c6d47cc012ff"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("4324b51a-1d14-4353-9d14-3509a2d843ce"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("96049f0b-d72f-4a55-a48f-1577e460a61d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("a964d335-57b0-470c-8969-5a467a5d26d3"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b24f1ec1-2df1-4629-9e89-02e8188df6ff"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b8d91bfa-a0ab-4942-8b0c-ae433d0ea58a"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("c8105254-0ff6-4107-bc17-a5dddeaa5d05"));

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
        }
    }
}
