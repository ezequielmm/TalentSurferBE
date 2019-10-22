using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EY.TalentSurfer.Support.Persistence.Sql.Migrations
{
    public partial class InitialDataLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Certainty",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder", "Value" },
                values: new object[,]
                {
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9918), new TimeSpan(0, 0, 0, 0, 0)), "1. Lost", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "0%" },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9945), new TimeSpan(0, 0, 0, 0, 0)), "2. Forecast", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "20%" },
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9949), new TimeSpan(0, 0, 0, 0, 0)), "3. Under Discussion", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, "40%" },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9954), new TimeSpan(0, 0, 0, 0, 0)), "4. Proposal Sent", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4, "60%" },
                    { 5, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 0, 0, 0, 0)), "5. SOW Sent", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5, "80%" },
                    { 6, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), "6. SOW Approved", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6, "100%" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder" },
                values: new object[,]
                {
                    { 14, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 0, 0, 0, 0)), "Medellin", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 14 },
                    { 13, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 0, 0, 0, 0)), "Bogota", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 13 },
                    { 12, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8925), new TimeSpan(0, 0, 0, 0, 0)), "MDZ", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12 },
                    { 11, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8922), new TimeSpan(0, 0, 0, 0, 0)), "RO", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11 },
                    { 10, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8918), new TimeSpan(0, 0, 0, 0, 0)), "CBA", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10 },
                    { 8, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 0, 0, 0, 0)), "Bangalore", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8 },
                    { 9, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8915), new TimeSpan(0, 0, 0, 0, 0)), "CABA", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 9 },
                    { 6, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 0, 0, 0, 0)), "Anywhere CO", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6 },
                    { 5, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8902), new TimeSpan(0, 0, 0, 0, 0)), "Anywhere ARG", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8898), new TimeSpan(0, 0, 0, 0, 0)), "US", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4 },
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 0, 0, 0, 0)), "Anywhere INDIA", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 0, 0, 0, 0)), "Anywhere LATAM", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2 },
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 0, 0, 0, 0)), "Anywhere", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 },
                    { 7, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 936, DateTimeKind.Unspecified).AddTicks(8908), new TimeSpan(0, 0, 0, 0, 0)), "Pune", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 7 }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder" },
                values: new object[,]
                {
                    { 17, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 0, 0, 0, 0)), "Salesforce Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 17 },
                    { 18, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 0, 0, 0, 0)), "Scrum Master", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 18 },
                    { 19, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(261), new TimeSpan(0, 0, 0, 0, 0)), "Service Now Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 19 },
                    { 20, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)), "Sharepoint Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 20 },
                    { 21, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(268), new TimeSpan(0, 0, 0, 0, 0)), "SOA Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 21 },
                    { 22, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 0, 0, 0, 0)), "SQL Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 22 },
                    { 25, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(280), new TimeSpan(0, 0, 0, 0, 0)), "SME", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 25 },
                    { 24, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(277), new TimeSpan(0, 0, 0, 0, 0)), "Tech Manager", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 24 },
                    { 26, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 0, 0, 0, 0)), "User Experience Designer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 26 },
                    { 27, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(287), new TimeSpan(0, 0, 0, 0, 0)), "Visual Designer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 27 },
                    { 28, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 0, 0, 0, 0)), "Web UI Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 28 },
                    { 16, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 0, 0, 0, 0)), "QC Analyst", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 16 },
                    { 23, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(274), new TimeSpan(0, 0, 0, 0, 0)), "Test Automation Engineer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 23 },
                    { 15, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(248), new TimeSpan(0, 0, 0, 0, 0)), "Python Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 15 },
                    { 12, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(239), new TimeSpan(0, 0, 0, 0, 0)), "Mobile Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12 },
                    { 13, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(242), new TimeSpan(0, 0, 0, 0, 0)), "Performance Test Engineer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 13 },
                    { 11, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(235), new TimeSpan(0, 0, 0, 0, 0)), "Java Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 11 },
                    { 10, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), "DevOps/Cloud Engineer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10 },
                    { 9, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(229), new TimeSpan(0, 0, 0, 0, 0)), "DBA", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 9 },
                    { 8, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 0, 0, 0, 0)), "Data Scientist", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8 },
                    { 7, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(223), new TimeSpan(0, 0, 0, 0, 0)), "Data Architect", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 7 },
                    { 6, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(220), new TimeSpan(0, 0, 0, 0, 0)), "Business Intelligence", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6 },
                    { 5, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(216), new TimeSpan(0, 0, 0, 0, 0)), "Business Analyst", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(213), new TimeSpan(0, 0, 0, 0, 0)), "BPM Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4 },
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(209), new TimeSpan(0, 0, 0, 0, 0)), "BI Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(205), new TimeSpan(0, 0, 0, 0, 0)), ".Net Developer", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2 },
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 0, 0, 0, 0)), "** Not Needed **", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 },
                    { 14, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 0, 0, 0, 0)), "Project Manager", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 14 }
                });

            migrationBuilder.InsertData(
                table: "PositionStatus",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder" },
                values: new object[,]
                {
                    { 5, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1406), new TimeSpan(0, 0, 0, 0, 0)), "4. Confirmed (Future)", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 },
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 0, 0, 0, 0)), "2. Internal FIT", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1402), new TimeSpan(0, 0, 0, 0, 0)), "3. Canfirmed (NOW)", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4 },
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, 0, 0, 0, 0)), "** Not Needed **", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 942, DateTimeKind.Unspecified).AddTicks(1394), new TimeSpan(0, 0, 0, 0, 0)), "1. No Candidates", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2 }
                });

            migrationBuilder.InsertData(
                table: "Seniority",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder" },
                values: new object[,]
                {
                    { 12, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 0, 0, 0, 0)), "Level 5", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 12 },
                    { 10, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3830), new TimeSpan(0, 0, 0, 0, 0)), "Level 4", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10 },
                    { 9, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3827), new TimeSpan(0, 0, 0, 0, 0)), "Architect / Level 3", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 9 },
                    { 8, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0)), "SD / Level 2", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 8 },
                    { 6, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)), "SSr Adv", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 6 },
                    { 7, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, 0, 0, 0, 0)), "Senior", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 7 },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3811), new TimeSpan(0, 0, 0, 0, 0)), "Junior Adv", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4 },
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, 0, 0, 0, 0)), "Junior", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3803), new TimeSpan(0, 0, 0, 0, 0)), "Trainee", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2 },
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3781), new TimeSpan(0, 0, 0, 0, 0)), "** Not Needed **", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 },
                    { 5, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 941, DateTimeKind.Unspecified).AddTicks(3814), new TimeSpan(0, 0, 0, 0, 0)), "SSr", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 5 }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "ArchivingFlag", "Comments", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "SortOrder" },
                values: new object[,]
                {
                    { 3, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 0, 0, 0, 0)), "3. Lost", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 },
                    { 1, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7064), new TimeSpan(0, 0, 0, 0, 0)), "1. Wating for Feedback", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 },
                    { 2, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), "2. On Hold", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2 },
                    { 4, false, null, "Initial Data Load", new DateTimeOffset(new DateTime(2019, 10, 21, 12, 54, 34, 939, DateTimeKind.Unspecified).AddTicks(7096), new TimeSpan(0, 0, 0, 0, 0)), "4. Won", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Certainty",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PositionStatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seniority",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
