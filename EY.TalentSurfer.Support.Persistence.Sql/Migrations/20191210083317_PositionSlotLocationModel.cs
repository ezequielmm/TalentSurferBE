using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class PositionSlotLocationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PositionSlot",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTimeOffset>(nullable: false),
                    Glober = table.Column<string>(nullable: true),
                    GloberEmail = table.Column<string>(nullable: true),
                    Tickets = table.Column<string>(nullable: true),
                    NonGlober = table.Column<string>(nullable: true),
                    NonGloberEmail = table.Column<string>(nullable: true),
                    PositionId = table.Column<int>(nullable: true),
                    SeniorityId = table.Column<int>(nullable: true),
                    LocationId = table.Column<int>(nullable: true),
                    PostionStatusId = table.Column<int>(nullable: true),
                    CandidateSeniorityId = table.Column<int>(nullable: true),
                    CandidateLocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionSlot_Location_CandidateLocationId",
                        column: x => x.CandidateLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PositionSlot_Seniority_CandidateSeniorityId",
                        column: x => x.CandidateSeniorityId,
                        principalTable: "Seniority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PositionSlot_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PositionSlot_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PositionSlot_PositionStatus_PostionStatusId",
                        column: x => x.PostionStatusId,
                        principalTable: "PositionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PositionSlot_Seniority_SeniorityId",
                        column: x => x.SeniorityId,
                        principalTable: "Seniority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PositionSlotLocation",
                columns: table => new
                {
                    PositionSlotId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionSlotLocation", x => new { x.PositionSlotId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_PositionSlotLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionSlotLocation_PositionSlot_PositionSlotId",
                        column: x => x.PositionSlotId,
                        principalTable: "PositionSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 377, DateTimeKind.Unspecified).AddTicks(3221), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 377, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 377, DateTimeKind.Unspecified).AddTicks(5334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 377, DateTimeKind.Unspecified).AddTicks(5339), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 377, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 377, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(3326), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7142), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7147), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7160), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7164), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7179), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 369, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(2890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4545), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4552), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4556), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4563), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4567), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4578), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4581), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4585), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4588), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4591), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4600), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4605), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4612), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4622), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(4708), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 376, DateTimeKind.Unspecified).AddTicks(4186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 376, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 376, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 376, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 376, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(6762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8157), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8187), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8190), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8194), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8201), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 375, DateTimeKind.Unspecified).AddTicks(8204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 374, DateTimeKind.Unspecified).AddTicks(6415), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 374, DateTimeKind.Unspecified).AddTicks(7764), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 374, DateTimeKind.Unspecified).AddTicks(7785), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 374, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 373, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 374, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 374, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 12, 10, 8, 33, 16, 374, DateTimeKind.Unspecified).AddTicks(1383), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_PositionSlot_CandidateLocationId",
                table: "PositionSlot",
                column: "CandidateLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionSlot_CandidateSeniorityId",
                table: "PositionSlot",
                column: "CandidateSeniorityId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionSlot_LocationId",
                table: "PositionSlot",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionSlot_PositionId",
                table: "PositionSlot",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionSlot_PostionStatusId",
                table: "PositionSlot",
                column: "PostionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionSlot_SeniorityId",
                table: "PositionSlot",
                column: "SeniorityId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionSlotLocation_LocationId",
                table: "PositionSlotLocation",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PositionSlotLocation");

            migrationBuilder.DropTable(
                name: "PositionSlot");

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 824, DateTimeKind.Unspecified).AddTicks(8963), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 825, DateTimeKind.Unspecified).AddTicks(1361), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 825, DateTimeKind.Unspecified).AddTicks(1384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 825, DateTimeKind.Unspecified).AddTicks(1388), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 825, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 825, DateTimeKind.Unspecified).AddTicks(1394), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 818, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2783), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2834), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2837), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2843), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2846), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2849), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2851), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 819, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2413), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2434), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2450), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2455), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2458), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2461), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2464), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2467), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2484), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2495), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2498), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2501), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 824, DateTimeKind.Unspecified).AddTicks(1161), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 824, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 824, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 824, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 824, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(3809), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5705), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 823, DateTimeKind.Unspecified).AddTicks(5730), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 822, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 822, DateTimeKind.Unspecified).AddTicks(6179), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 822, DateTimeKind.Unspecified).AddTicks(6198), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceLine",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 822, DateTimeKind.Unspecified).AddTicks(6201), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(9602), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(9676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 11, 28, 20, 10, 9, 821, DateTimeKind.Unspecified).AddTicks(9680), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
