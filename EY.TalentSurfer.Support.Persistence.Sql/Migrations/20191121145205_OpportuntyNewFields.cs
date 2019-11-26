using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class OpportuntyNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "Opportunity",
                newName: "HiringManager");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EyId",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 813, DateTimeKind.Unspecified).AddTicks(1794), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 813, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 813, DateTimeKind.Unspecified).AddTicks(4136), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 813, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 813, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 813, DateTimeKind.Unspecified).AddTicks(4145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(3804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8575), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8581), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8586), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 807, DateTimeKind.Unspecified).AddTicks(8603), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(4702), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6524), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6544), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6547), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6552), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6555), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6558), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6560), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6563), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6566), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6568), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6576), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6579), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6582), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6587), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6603), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6606), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6608), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 809, DateTimeKind.Unspecified).AddTicks(6611), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 812, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 812, DateTimeKind.Unspecified).AddTicks(6149), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 812, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 812, DateTimeKind.Unspecified).AddTicks(6173), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 812, DateTimeKind.Unspecified).AddTicks(6176), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9083), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9086), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 811, DateTimeKind.Unspecified).AddTicks(9094), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(7906), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(9637), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(9655), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(9658), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(3138), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(3158), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 21, 14, 52, 4, 810, DateTimeKind.Unspecified).AddTicks(3162), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_ProjectId",
                table: "Opportunity",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunity_Project_ProjectId",
                table: "Opportunity",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunity_Project_ProjectId",
                table: "Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_Opportunity_ProjectId",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "EyId",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Opportunity");

            migrationBuilder.RenameColumn(
                name: "HiringManager",
                table: "Opportunity",
                newName: "ProjectName");

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 525, DateTimeKind.Unspecified).AddTicks(2958), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 525, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 525, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 525, DateTimeKind.Unspecified).AddTicks(2989), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 525, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 525, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(4782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5798), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5815), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5819), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5864), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5867), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5876), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5879), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5884), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 518, DateTimeKind.Unspecified).AddTicks(5889), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8774), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8780), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8786), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8792), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8801), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8807), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8818), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8824), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8832), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8838), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8844), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 520, DateTimeKind.Unspecified).AddTicks(8847), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 524, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 524, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 524, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 524, DateTimeKind.Unspecified).AddTicks(3650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 524, DateTimeKind.Unspecified).AddTicks(3653), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6129), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6132), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6135), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6140), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6143), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 523, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 522, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 522, DateTimeKind.Unspecified).AddTicks(4020), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 522, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 522, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 521, DateTimeKind.Unspecified).AddTicks(5963), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 521, DateTimeKind.Unspecified).AddTicks(5984), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 521, DateTimeKind.Unspecified).AddTicks(5988), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 31, 14, 12, 45, 521, DateTimeKind.Unspecified).AddTicks(5991), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
