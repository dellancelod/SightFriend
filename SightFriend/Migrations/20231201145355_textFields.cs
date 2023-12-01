using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SightFriend.Migrations
{
    /// <inheritdoc />
    public partial class textFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.CreateTable(
                name: "NewsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subtitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsItems", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TextFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CodeWord = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFields", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "4a6c1b15-2df4-4743-a39e-7a37c625d24f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "936fafb1-9b6f-4564-b9cd-1eb9e90dddf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b167495c-7b90-4b05-8dc8-256823348341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8f694dc-c7d2-41f8-9aed-dadc0d3db859", "AQAAAAEAACcQAAAAECSRMa+qV1/fY+HiMMIC9d1mAy57EGighgMNlwQVyOIhFN/QEuNtLhqEaweccAUmdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9dacebc-402e-48df-8d60-dae005eece05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c1d53ec-356b-47a7-9f5b-dd944d95f131", "AQAAAAEAACcQAAAAEJk8t+UPm08THms03HZN7HAEVIzI0d5Q7P69iaGyB0qf3Hu9rI5hs8LHlXKp1VTgRw==" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"), "PageMedia", new DateTime(2023, 12, 1, 14, 53, 55, 220, DateTimeKind.Utc).AddTicks(4625), "Вміст заповнюється адміністратором", "Медіа" },
                    { new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"), "PageNews", new DateTime(2023, 12, 1, 14, 53, 55, 220, DateTimeKind.Utc).AddTicks(4396), "Вміст заповнюється адміністратором", "Новини" },
                    { new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"), "PageBooks", new DateTime(2023, 12, 1, 14, 53, 55, 220, DateTimeKind.Utc).AddTicks(4547), "Вміст заповнюється адміністратором", "Аудіо-книги" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsItems");

            migrationBuilder.DropTable(
                name: "TextFields");

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Subtitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74e67259-c3b6-49ae-96f8-d5cd2874edc2", "AQAAAAEAACcQAAAAEBkRPcp5OFVuJJ9GwcKTqcy27icS3ADaSPJ2KZFxyrKSEL51wKNkyx4vv2/93ta9ng==" });
        }
    }
}
