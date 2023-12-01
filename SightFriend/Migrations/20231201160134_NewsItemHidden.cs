using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SightFriend.Migrations
{
    /// <inheritdoc />
    public partial class NewsItemHidden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Hidden",
                table: "NewsItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "e418a71c-8b7b-449d-a2a4-cc17bf384da5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "87b62e54-c5ed-4cdb-bc66-f6c08e7a4558");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b167495c-7b90-4b05-8dc8-256823348341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74510224-e314-40f1-b651-69d6ea5b55da", "AQAAAAEAACcQAAAAEHlctO2Uw0FS+3TiJJVsul7ums2fvEdphCwjDia+3uYCWSsGjmfnuMBGYW/48MhlNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9dacebc-402e-48df-8d60-dae005eece05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "222d2f12-c645-4f2e-93d8-5e8d98eb39fe", "AQAAAAEAACcQAAAAEDSTOCvRHyG/Gswz2T41w/kiqNIFwGEapg6q1poXCWkA30xu9RX3f45Pa6ibym/wWQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 1, 16, 1, 33, 777, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 1, 16, 1, 33, 777, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 1, 16, 1, 33, 777, DateTimeKind.Utc).AddTicks(8553));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hidden",
                table: "NewsItems");

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

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 1, 14, 53, 55, 220, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 1, 14, 53, 55, 220, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2023, 12, 1, 14, 53, 55, 220, DateTimeKind.Utc).AddTicks(4547));
        }
    }
}
