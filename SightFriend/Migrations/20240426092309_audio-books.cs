using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SightFriend.Migrations
{
    public partial class audiobooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AudioFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "285d6789-7c64-4e16-96be-964f159a15b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c7cd6dcb-bb97-458c-b757-d3adefb1a874");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b167495c-7b90-4b05-8dc8-256823348341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77a2c5d2-2300-4698-8a5a-178cd17d854e", "AQAAAAEAACcQAAAAEC4omz4KkSpCbgflDrhF2qZZH5IonDuSkkGCvT7KNkQmX8pIqChnTbtgSP5MD1tV7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9dacebc-402e-48df-8d60-dae005eece05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f3a8115-ebce-4968-99b9-7d88ec9c1a52", "AQAAAAEAACcQAAAAEFRy4pZNBxACJ0tUeV3pz9Y4uMr0hrZDjfJgeOvtHn5jPhhB6uZA/syBbEnipvbUmQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 9, 23, 8, 463, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 9, 23, 8, 463, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 9, 23, 8, 463, DateTimeKind.Utc).AddTicks(7091));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "0ca89755-f085-422e-ad3a-a3e5d0acb242");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "301dbdee-4a29-4775-a671-a3e95269ef2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b167495c-7b90-4b05-8dc8-256823348341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1793688-8a2c-4dc9-bd40-19269df55f90", "AQAAAAEAACcQAAAAEBUSHpBWymKZBZQhDILmma0SPORleT8p8CuZrfezjP4+2aSlXISXQUsgyBHtBAnz1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9dacebc-402e-48df-8d60-dae005eece05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8632c81-fb1d-4980-97e0-c6b481ee257b", "AQAAAAEAACcQAAAAEMnu/3/DnVvxOSjMegnYPAGB05OGhj0WFYiL4FYT17k3sRZEsA0m42ow6CS/8+dTJQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 2, 9, 30, 7, 35, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 2, 9, 30, 7, 35, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 2, 9, 30, 7, 35, DateTimeKind.Utc).AddTicks(2381));
        }
    }
}
