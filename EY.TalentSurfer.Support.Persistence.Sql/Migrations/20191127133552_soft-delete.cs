using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class softdelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Status",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Sow",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ServiceLine",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Seniority",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Project",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "PositionStatus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "PositionEY",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Position",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Opportunity",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Location",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Certainty",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 711, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 712, DateTimeKind.Unspecified).AddTicks(2209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 712, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 712, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 712, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 712, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(1748), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7500), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7508), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 705, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(6269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8472), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8493), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8512), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8519), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8522), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8528), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8531), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8541), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8545), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8548), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8551), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 707, DateTimeKind.Unspecified).AddTicks(8613), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 711, DateTimeKind.Unspecified).AddTicks(417), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 711, DateTimeKind.Unspecified).AddTicks(2456), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 711, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 711, DateTimeKind.Unspecified).AddTicks(2482), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 711, DateTimeKind.Unspecified).AddTicks(2485), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(2364), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4437), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4469), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4473), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4483), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4486), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 710, DateTimeKind.Unspecified).AddTicks(4490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 709, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 709, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 709, DateTimeKind.Unspecified).AddTicks(3773), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 709, DateTimeKind.Unspecified).AddTicks(3778), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 708, DateTimeKind.Unspecified).AddTicks(4111), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 708, DateTimeKind.Unspecified).AddTicks(6146), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 708, DateTimeKind.Unspecified).AddTicks(6168), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 27, 13, 35, 51, 708, DateTimeKind.Unspecified).AddTicks(6172), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Sow");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ServiceLine");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Seniority");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "PositionStatus");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "PositionEY");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Certainty");

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
