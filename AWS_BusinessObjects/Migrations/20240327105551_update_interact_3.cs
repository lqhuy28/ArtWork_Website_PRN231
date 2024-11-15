using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AWS_BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class update_interact_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("26709dca-1906-4c50-a00e-1c63582ab644"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ArtWorks",
                keyColumn: "Id",
                keyValue: new Guid("d9d6b461-8efd-4395-8662-a58caa152200"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.InsertData(
                table: "ArtistAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("07ca35b8-f24a-4906-b3ac-f709e1eb5385"), new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1781), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ch" },
                    { new Guid("14d98de6-913a-4b53-8221-1a25d202755e"), new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1772), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("861d24aa-6ac4-43f2-a507-d4ccc016014f"), new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1778), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cg" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a449b7f8-45a5-4cc7-9735-f1d230e02b54", "2a2f6c63-90d5-4e47-97e3-be90a5886298" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cg",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5969e47-7d38-4e19-bcc3-0f08fe437d9c", "d7b2558f-c499-43ad-8c71-a4ad84485ee5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ch",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e510ed3-5eb2-41b6-9229-525e751bafaf", "14a76f9e-c380-48ed-997e-930d63bbb025" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866ci",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a55131b-767a-4523-8b3f-6cd9e52cb824", "72f7ca41-2872-4501-b305-e38019d7daa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cj",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3af2c035-366a-44f5-b787-55c3bd23e6ef", "c83c6d90-1613-402c-b584-50a8462a04b4" });

            migrationBuilder.InsertData(
                table: "AudienceAccount",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("ea1dec39-d541-40e9-bb5d-90ad2e0e112c"), new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1800), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866ci" },
                    { new Guid("f82c792b-f6c8-4ab1-bd5b-15a709c3a838"), new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1804), null, false, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cj" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26b5fcea-c9cb-4c7c-ad93-100a6d8611d6"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53b50d7f-44eb-4dda-84b1-9d3c938eba22"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58c96dfc-1c31-429b-9c6c-378db1c68b2a"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d935698-bc0f-4692-88a3-43234943be40"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1799e22-2212-43d2-a09a-6a0371f2d89c"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3cb8ee0-c965-4970-8ef0-baad50ebf987"),
                column: "Created",
                value: new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.InsertData(
                table: "Interacts",
                columns: new[] { "Id", "ArtWorkID", "Comment", "Created", "CreatedBy", "IsDeleted", "IsLike", "LastModified", "LastModifiedBy", "UserAccountId" },
                values: new object[,]
                {
                    { new Guid("1b34791b-afd6-4bec-90c8-c1dc7b0920f6"), new Guid("d9d6b461-8efd-4395-8662-a58caa152200"), "Comment 10", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(2023), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("40fc1a5d-539e-4864-b4f9-12ccb0be9b6b"), new Guid("bd37c967-1817-495b-89eb-665c81b02d5e"), "Comment 7", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(2010), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("64d1c8da-1ee9-4e13-bf58-52ec43cf1a0d"), new Guid("1f35558f-a942-4837-81a4-720bae0e8bb1"), "Comment 8", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(2016), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("6b2bb8a0-f384-49c3-a0eb-7c0a6c4580fb"), new Guid("a25e170e-7ddc-4bdc-9215-51c6fb9bcd96"), "Comment 5", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(2003), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("72285d58-6525-46a2-8812-773088070eaf"), new Guid("9db314d0-6a55-492c-9a13-7ee6f2091cbf"), "Comment 9", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(2020), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("b4a48941-8dae-4192-b727-734ff8cd5183"), new Guid("7b76bf1f-d24c-4ac9-b466-4179e65605b2"), "Comment 4", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1999), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("e597d0d7-abf5-4587-a5f3-a0740a740880"), new Guid("26709dca-1906-4c50-a00e-1c63582ab644"), "Comment 2", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1990), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("e75964f9-6304-4a1c-9722-88fc3615014a"), new Guid("8c44d5c8-a738-4b65-a88e-3ed38fce88c4"), "Comment 3", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1994), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("f2e3e822-3b5a-4395-9291-43167d65a937"), new Guid("b18dcaa1-d99a-4f15-a30c-5fd72c30280e"), "Comment 6", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(2007), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" },
                    { new Guid("fd7f4b5f-56b3-48f1-88e0-6cc6160993b5"), new Guid("8e9acec5-54c9-4093-a450-19eb7b2109fb"), "Comment 1", new DateTime(2024, 3, 27, 17, 55, 51, 292, DateTimeKind.Local).AddTicks(1984), null, false, true, null, null, "871a809a-b3fa-495b-9cc2-c5d738a866cf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("07ca35b8-f24a-4906-b3ac-f709e1eb5385"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("14d98de6-913a-4b53-8221-1a25d202755e"));

            migrationBuilder.DeleteData(
                table: "ArtistAccount",
                keyColumn: "Id",
                keyValue: new Guid("861d24aa-6ac4-43f2-a507-d4ccc016014f"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("ea1dec39-d541-40e9-bb5d-90ad2e0e112c"));

            migrationBuilder.DeleteData(
                table: "AudienceAccount",
                keyColumn: "Id",
                keyValue: new Guid("f82c792b-f6c8-4ab1-bd5b-15a709c3a838"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("1b34791b-afd6-4bec-90c8-c1dc7b0920f6"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("40fc1a5d-539e-4864-b4f9-12ccb0be9b6b"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("64d1c8da-1ee9-4e13-bf58-52ec43cf1a0d"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("6b2bb8a0-f384-49c3-a0eb-7c0a6c4580fb"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("72285d58-6525-46a2-8812-773088070eaf"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("b4a48941-8dae-4192-b727-734ff8cd5183"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e597d0d7-abf5-4587-a5f3-a0740a740880"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("e75964f9-6304-4a1c-9722-88fc3615014a"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("f2e3e822-3b5a-4395-9291-43167d65a937"));

            migrationBuilder.DeleteData(
                table: "Interacts",
                keyColumn: "Id",
                keyValue: new Guid("fd7f4b5f-56b3-48f1-88e0-6cc6160993b5"));

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
    }
}
