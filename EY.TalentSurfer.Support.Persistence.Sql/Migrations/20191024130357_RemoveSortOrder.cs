using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class RemoveSortOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "ServiceLine");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Seniority");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "PositionStatus");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Certainty");

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 363, DateTimeKind.Unspecified).AddTicks(2021), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 363, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 363, DateTimeKind.Unspecified).AddTicks(2051), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 363, DateTimeKind.Unspecified).AddTicks(2055), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 363, DateTimeKind.Unspecified).AddTicks(2059), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 363, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(1949), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3020), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3041), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3055), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3059), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3063), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3071), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 357, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4645), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4692), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4696), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4699), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4706), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4721), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4731), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4735), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4746), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4750), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 359, DateTimeKind.Unspecified).AddTicks(4765), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 362, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 362, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 362, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 362, DateTimeKind.Unspecified).AddTicks(4213), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 362, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7309), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7313), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7317), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7324), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 361, DateTimeKind.Unspecified).AddTicks(7331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(7300), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(7322), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(7328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(7334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(1038), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(1060), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 24, 13, 3, 57, 360, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Status",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "ServiceLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Seniority",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "PositionStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Position",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Location",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Certainty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 0, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5115), new TimeSpan(0, 0, 0, 0, 0)), 5 });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)), 6 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(4571), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, 0, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 0, 0, 0, 0)), 5 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)), 6 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, 0, 0, 0, 0)), 7 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5855), new TimeSpan(0, 0, 0, 0, 0)), 8 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5858), new TimeSpan(0, 0, 0, 0, 0)), 9 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5861), new TimeSpan(0, 0, 0, 0, 0)), 10 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5865), new TimeSpan(0, 0, 0, 0, 0)), 11 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, 0, 0, 0, 0)), 12 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 0, 0, 0, 0)), 13 });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5875), new TimeSpan(0, 0, 0, 0, 0)), 14 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8766), new TimeSpan(0, 0, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8769), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8772), new TimeSpan(0, 0, 0, 0, 0)), 5 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 0, 0, 0, 0)), 6 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 0, 0, 0, 0)), 7 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8781), new TimeSpan(0, 0, 0, 0, 0)), 8 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 0, 0, 0, 0)), 9 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8787), new TimeSpan(0, 0, 0, 0, 0)), 10 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 0, 0, 0, 0)), 11 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), 12 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)), 13 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8799), new TimeSpan(0, 0, 0, 0, 0)), 14 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8802), new TimeSpan(0, 0, 0, 0, 0)), 15 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8845), new TimeSpan(0, 0, 0, 0, 0)), 16 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, 0, 0, 0, 0)), 17 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)), 18 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)), 19 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)), 20 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)), 21 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, 0, 0, 0, 0)), 22 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 0, 0, 0, 0)), 23 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), 24 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8872), new TimeSpan(0, 0, 0, 0, 0)), 25 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 0, 0, 0, 0)), 26 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 0, 0, 0, 0)), 27 });

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 0, 0, 0, 0)), 28 });

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1690), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 0, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1698), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1701), new TimeSpan(0, 0, 0, 0, 0)), 5 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3894), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3898), new TimeSpan(0, 0, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 0, 0, 0, 0)), 5 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3908), new TimeSpan(0, 0, 0, 0, 0)), 6 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 0, 0, 0, 0)), 7 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3914), new TimeSpan(0, 0, 0, 0, 0)), 8 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 0, 0, 0, 0)), 9 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, 0, 0, 0, 0)), 10 });

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3924), new TimeSpan(0, 0, 0, 0, 0)), 12 });

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2622), new TimeSpan(0, 0, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 0, 0, 0, 0)), 4 });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(5918), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(6044), new TimeSpan(0, 0, 0, 0, 0)), 2 });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(6048), new TimeSpan(0, 0, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "SortOrder" },
                values: new object[] { new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(6052), new TimeSpan(0, 0, 0, 0, 0)), 4 });
        }
    }
}
