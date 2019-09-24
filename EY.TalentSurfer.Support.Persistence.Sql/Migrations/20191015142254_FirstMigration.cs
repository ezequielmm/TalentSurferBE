using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessUnit",
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
                    table.PrimaryKey("PK_BusinessUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certainty",
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
                    Value = table.Column<string>(nullable: true),
                    ArchivingFlag = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certainty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
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
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
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
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionStatus",
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
                    table.PrimaryKey("PK_PositionStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seniority",
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
                    table.PrimaryKey("PK_Seniority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
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
                    table.PrimaryKey("PK_Status", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessUnit");

            migrationBuilder.DropTable(
                name: "Certainty");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "PositionStatus");

            migrationBuilder.DropTable(
                name: "Seniority");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
