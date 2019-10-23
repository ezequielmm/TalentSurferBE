using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class OpportunityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessUnit");

            migrationBuilder.CreateTable(
                name: "ServiceLine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTimeOffset>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ArchivingFlag = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opportunity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Product = table.Column<string>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    CertaintyId = table.Column<int>(nullable: true),
                    PrimaryLocationId = table.Column<int>(nullable: true),
                    ProposalFolder = table.Column<string>(nullable: true),
                    Sow = table.Column<int>(nullable: false),
                    ServiceLineId = table.Column<int>(nullable: true),
                    RequestedByName = table.Column<string>(nullable: true),
                    RequestedByEmail = table.Column<string>(nullable: true),
                    RequestedOn = table.Column<DateTime>(nullable: false),
                    MapId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    OriginalOpptCopy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opportunity_Certainty_CertaintyId",
                        column: x => x.CertaintyId,
                        principalTable: "Certainty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_Opportunity_MapId",
                        column: x => x.MapId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_Location_PrimaryLocationId",
                        column: x => x.PrimaryLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_ServiceLine_ServiceLineId",
                        column: x => x.ServiceLineId,
                        principalTable: "ServiceLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityLocation",
                columns: table => new
                {
                    OpportunityId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityLocation", x => new { x.OpportunityId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_OpportunityLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityLocation_Opportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5115), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 353, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(4571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5851), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5855), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5858), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5861), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5865), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 346, DateTimeKind.Unspecified).AddTicks(5875), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8766), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8769), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8772), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8781), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8787), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8799), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8802), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8872), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 348, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1690), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1698), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 352, DateTimeKind.Unspecified).AddTicks(1701), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3908), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3914), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 351, DateTimeKind.Unspecified).AddTicks(3924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "ServiceLine",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder" },
                values: new object[,]
                {
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 0, 0, 0, 0)), "Platform", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 0, 0, 0, 0)), "ATTG", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2 },
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2622), new TimeSpan(0, 0, 0, 0, 0)), "GTP", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 350, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 0, 0, 0, 0)), "Business", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4 }
                });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(5918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(6044), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(6048), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 22, 18, 40, 20, 349, DateTimeKind.Unspecified).AddTicks(6052), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_CertaintyId",
                table: "Opportunity",
                column: "CertaintyId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_MapId",
                table: "Opportunity",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_PrimaryLocationId",
                table: "Opportunity",
                column: "PrimaryLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_ServiceLineId",
                table: "Opportunity",
                column: "ServiceLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_StatusId",
                table: "Opportunity",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityLocation_LocationId",
                table: "OpportunityLocation",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpportunityLocation");

            migrationBuilder.DropTable(
                name: "Opportunity");

            migrationBuilder.DropTable(
                name: "ServiceLine");

            migrationBuilder.CreateTable(
                name: "BusinessUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArchivingFlag = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedOn = table.Column<DateTimeOffset>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BusinessUnit",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder" },
                values: new object[,]
                {
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 940, DateTimeKind.Unspecified).AddTicks(3283), new TimeSpan(0, 0, 0, 0, 0)), "Platform", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 940, DateTimeKind.Unspecified).AddTicks(3306), new TimeSpan(0, 0, 0, 0, 0)), "ATTG", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2 },
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 940, DateTimeKind.Unspecified).AddTicks(3310), new TimeSpan(0, 0, 0, 0, 0)), "GTP", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 940, DateTimeKind.Unspecified).AddTicks(3313), new TimeSpan(0, 0, 0, 0, 0)), "Business", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4 }
                });

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9945), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9949), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9954), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8902), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8908), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8915), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8918), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8922), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8925), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(205), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(209), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(213), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(220), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(223), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(229), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(235), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(242), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(248), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(268), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(280), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(287), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1394), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1406), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3781), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3814), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3827), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3830), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7064), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7096), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
