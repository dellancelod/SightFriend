using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SightFriend.Migrations
{
    /// <inheritdoc />
    public partial class CorrectSubtitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subitle",
                table: "News",
                newName: "Subtitle");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "b24ec989-c58b-4c0d-a067-4eb735dd6b67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8f588b09-d48b-4042-a8be-3cd5e1127c44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b167495c-7b90-4b05-8dc8-256823348341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64f66c7e-6594-4d0d-b96f-637f2ebe2733", "AQAAAAEAACcQAAAAEI2PxNCnej/e5lwZ2IcVn41N3jjaoLjwYUn96cv105DBfsMtD9fitmP7RPVuCrd32w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9dacebc-402e-48df-8d60-dae005eece05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "74e67259-c3b6-49ae-96f8-d5cd2874edc2", "AQAAAAEAACcQAAAAEBkRPcp5OFVuJJ9GwcKTqcy27icS3ADaSPJ2KZFxyrKSEL51wKNkyx4vv2/93ta9ng==", "0955880395" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "News",
                newName: "Subitle");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "2ca21906-e4f8-437b-86e8-356ffe9da1c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "22a47e3c-7a10-4c79-be40-37d4d7a3d187");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b167495c-7b90-4b05-8dc8-256823348341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b96c2e3-8854-4441-8d40-e5b2e24e3b27", "AQAAAAEAACcQAAAAEAiIJvKTi68KgDrHLoJagEz8O4iO500qzQw+g7o2B2e7jVJBTmvBJv90LOaIE9xNog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9dacebc-402e-48df-8d60-dae005eece05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "3a9111f4-1686-4715-90be-53fa8a1a552b", "AQAAAAEAACcQAAAAEC9JggVwDUARwf15H4jKntPicQGJ9hEq0tbnIy3XTvx/wNAvfIk+r7Gh/vw1pNjbkA==", "+380955880395" });
        }
    }
}
