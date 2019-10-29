using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class ProjectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ArchivingFlag = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 53, DateTimeKind.Unspecified).AddTicks(1241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 53, DateTimeKind.Unspecified).AddTicks(1265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 53, DateTimeKind.Unspecified).AddTicks(1269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 53, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 53, DateTimeKind.Unspecified).AddTicks(1275), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 53, DateTimeKind.Unspecified).AddTicks(1278), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3850), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3854), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3864), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3875), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3878), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3881), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 47, DateTimeKind.Unspecified).AddTicks(3883), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4329), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4379), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4391), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4407), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4413), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4416), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4419), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4421), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4427), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4430), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4441), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 49, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 52, DateTimeKind.Unspecified).AddTicks(3531), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 52, DateTimeKind.Unspecified).AddTicks(3550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 52, DateTimeKind.Unspecified).AddTicks(3553), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 52, DateTimeKind.Unspecified).AddTicks(3557), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 52, DateTimeKind.Unspecified).AddTicks(3559), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6850), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6859), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6861), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6864), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 51, DateTimeKind.Unspecified).AddTicks(6867), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(6928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(6931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(529), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(554), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 29, 13, 59, 55, 50, DateTimeKind.Unspecified).AddTicks(557), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

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
    }
}
