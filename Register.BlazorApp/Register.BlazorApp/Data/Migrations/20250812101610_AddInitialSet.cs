using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Register.BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    ActivityLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerformedActivityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.ActivityLogId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "RoleCategories",
                columns: table => new
                {
                    RoleCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleCategories", x => x.RoleCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smoker = table.Column<bool>(type: "bit", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    IsOnHoliday = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleCategoryId = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_Persons_RoleCategories_RoleCategoryId",
                        column: x => x.RoleCategoryId,
                        principalTable: "RoleCategories",
                        principalColumn: "RoleCategoryId");
                });

            migrationBuilder.InsertData(
                table: "ActivityLogs",
                columns: new[] { "ActivityLogId", "EndTime", "PerformedActivityDescription", "PersonId", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 29, 11, 10, 31, 0, DateTimeKind.Unspecified), "Activity  1", 1, new DateTime(2024, 7, 31, 17, 40, 44, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 3, 15, 0, 49, 0, DateTimeKind.Unspecified), "Activity  2", 1, new DateTime(2024, 1, 28, 14, 27, 55, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 7, 28, 0, 9, 34, 0, DateTimeKind.Unspecified), "Activity  3", 1, new DateTime(2024, 7, 22, 11, 17, 32, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 7, 27, 7, 9, 57, 0, DateTimeKind.Unspecified), "Activity  4", 1, new DateTime(2024, 4, 19, 21, 44, 43, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 8, 31, 16, 45, 24, 0, DateTimeKind.Unspecified), "Activity  5", 1, new DateTime(2024, 3, 6, 7, 21, 55, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 12, 28, 3, 30, 18, 0, DateTimeKind.Unspecified), "Activity  6", 1, new DateTime(2024, 8, 21, 23, 30, 59, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 7, 29, 20, 58, 18, 0, DateTimeKind.Unspecified), "Activity  7", 1, new DateTime(2024, 4, 29, 20, 32, 19, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 1, 19, 20, 27, 16, 0, DateTimeKind.Unspecified), "Activity  8", 1, new DateTime(2024, 11, 3, 10, 25, 13, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 10, 11, 18, 24, 31, 0, DateTimeKind.Unspecified), "Activity  9", 1, new DateTime(2024, 7, 21, 2, 53, 53, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 6, 3, 9, 43, 49, 0, DateTimeKind.Unspecified), "Activity  10", 1, new DateTime(2024, 4, 13, 9, 44, 10, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2024, 12, 25, 17, 57, 31, 0, DateTimeKind.Unspecified), "Activity  11", 1, new DateTime(2024, 1, 23, 11, 7, 2, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2024, 6, 4, 20, 51, 1, 0, DateTimeKind.Unspecified), "Activity  12", 1, new DateTime(2024, 8, 24, 10, 38, 3, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2024, 1, 28, 6, 23, 6, 0, DateTimeKind.Unspecified), "Activity  13", 1, new DateTime(2024, 12, 14, 2, 48, 42, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2024, 8, 24, 13, 28, 59, 0, DateTimeKind.Unspecified), "Activity  14", 1, new DateTime(2024, 7, 6, 3, 24, 5, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2024, 10, 22, 1, 46, 53, 0, DateTimeKind.Unspecified), "Activity  15", 1, new DateTime(2024, 12, 25, 4, 2, 48, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2024, 6, 14, 12, 22, 34, 0, DateTimeKind.Unspecified), "Activity  16", 1, new DateTime(2024, 9, 22, 21, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2024, 9, 20, 7, 14, 39, 0, DateTimeKind.Unspecified), "Activity  17", 1, new DateTime(2024, 9, 26, 2, 24, 7, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2024, 3, 23, 12, 16, 56, 0, DateTimeKind.Unspecified), "Activity  18", 1, new DateTime(2024, 10, 28, 10, 57, 19, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2024, 10, 31, 11, 37, 29, 0, DateTimeKind.Unspecified), "Activity  19", 1, new DateTime(2024, 8, 15, 21, 37, 20, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2024, 4, 17, 19, 50, 30, 0, DateTimeKind.Unspecified), "Activity  20", 1, new DateTime(2024, 8, 6, 9, 26, 31, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2024, 2, 15, 18, 12, 52, 0, DateTimeKind.Unspecified), "Activity  21", 1, new DateTime(2024, 7, 30, 4, 4, 27, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2024, 4, 22, 23, 22, 58, 0, DateTimeKind.Unspecified), "Activity  22", 1, new DateTime(2024, 5, 8, 23, 56, 37, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2024, 10, 13, 7, 18, 17, 0, DateTimeKind.Unspecified), "Activity  23", 1, new DateTime(2024, 4, 20, 17, 17, 50, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2024, 5, 30, 17, 17, 50, 0, DateTimeKind.Unspecified), "Activity  24", 1, new DateTime(2024, 12, 23, 10, 12, 50, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2024, 2, 1, 5, 14, 40, 0, DateTimeKind.Unspecified), "Activity  25", 1, new DateTime(2024, 12, 30, 1, 54, 5, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2024, 9, 16, 4, 45, 23, 0, DateTimeKind.Unspecified), "Activity  26", 1, new DateTime(2024, 11, 26, 0, 4, 3, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2024, 7, 31, 17, 39, 4, 0, DateTimeKind.Unspecified), "Activity  27", 1, new DateTime(2024, 5, 20, 6, 50, 15, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2024, 2, 20, 17, 8, 14, 0, DateTimeKind.Unspecified), "Activity  28", 1, new DateTime(2024, 6, 20, 21, 54, 6, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2024, 2, 6, 12, 43, 18, 0, DateTimeKind.Unspecified), "Activity  29", 1, new DateTime(2024, 1, 8, 14, 51, 53, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2024, 9, 18, 17, 5, 59, 0, DateTimeKind.Unspecified), "Activity  30", 1, new DateTime(2024, 4, 13, 23, 47, 33, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2024, 1, 12, 14, 19, 59, 0, DateTimeKind.Unspecified), "Activity  31", 1, new DateTime(2024, 9, 18, 13, 14, 45, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2024, 3, 25, 12, 58, 51, 0, DateTimeKind.Unspecified), "Activity  32", 1, new DateTime(2024, 1, 31, 23, 40, 48, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2024, 8, 10, 7, 23, 11, 0, DateTimeKind.Unspecified), "Activity  33", 1, new DateTime(2024, 11, 15, 16, 19, 36, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2024, 7, 24, 6, 48, 16, 0, DateTimeKind.Unspecified), "Activity  34", 1, new DateTime(2024, 10, 31, 20, 26, 17, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2024, 3, 8, 14, 33, 44, 0, DateTimeKind.Unspecified), "Activity  35", 1, new DateTime(2024, 6, 26, 1, 49, 53, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2024, 2, 16, 15, 59, 51, 0, DateTimeKind.Unspecified), "Activity  36", 1, new DateTime(2024, 8, 17, 3, 56, 5, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2024, 4, 3, 14, 56, 31, 0, DateTimeKind.Unspecified), "Activity  37", 1, new DateTime(2024, 6, 20, 20, 15, 16, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2024, 7, 7, 11, 5, 23, 0, DateTimeKind.Unspecified), "Activity  38", 1, new DateTime(2024, 5, 15, 17, 49, 31, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2024, 5, 13, 5, 28, 2, 0, DateTimeKind.Unspecified), "Activity  39", 1, new DateTime(2024, 8, 1, 21, 52, 20, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2024, 6, 1, 1, 28, 58, 0, DateTimeKind.Unspecified), "Activity  40", 1, new DateTime(2024, 12, 2, 2, 31, 31, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2024, 3, 12, 0, 38, 30, 0, DateTimeKind.Unspecified), "Activity  41", 1, new DateTime(2024, 5, 11, 17, 54, 29, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2024, 1, 10, 7, 12, 23, 0, DateTimeKind.Unspecified), "Activity  42", 1, new DateTime(2024, 3, 18, 3, 9, 8, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2024, 4, 5, 18, 43, 41, 0, DateTimeKind.Unspecified), "Activity  43", 1, new DateTime(2024, 12, 1, 19, 35, 51, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2024, 8, 14, 11, 9, 16, 0, DateTimeKind.Unspecified), "Activity  44", 1, new DateTime(2024, 8, 30, 6, 3, 41, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2024, 6, 6, 21, 13, 18, 0, DateTimeKind.Unspecified), "Activity  45", 1, new DateTime(2024, 1, 13, 2, 46, 50, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2024, 9, 24, 18, 26, 20, 0, DateTimeKind.Unspecified), "Activity  46", 1, new DateTime(2024, 8, 15, 21, 10, 52, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2024, 11, 29, 18, 16, 35, 0, DateTimeKind.Unspecified), "Activity  47", 1, new DateTime(2024, 8, 27, 10, 33, 38, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2024, 11, 23, 2, 21, 47, 0, DateTimeKind.Unspecified), "Activity  48", 1, new DateTime(2024, 9, 30, 18, 7, 31, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2024, 8, 14, 21, 30, 20, 0, DateTimeKind.Unspecified), "Activity  49", 1, new DateTime(2024, 10, 27, 12, 21, 9, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2024, 6, 6, 9, 47, 50, 0, DateTimeKind.Unspecified), "Activity  50", 1, new DateTime(2024, 8, 18, 6, 2, 12, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2024, 12, 5, 22, 10, 48, 0, DateTimeKind.Unspecified), "Activity  51", 1, new DateTime(2024, 12, 26, 19, 25, 45, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2024, 5, 18, 2, 43, 42, 0, DateTimeKind.Unspecified), "Activity  52", 1, new DateTime(2024, 8, 9, 20, 28, 14, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2024, 8, 4, 19, 12, 45, 0, DateTimeKind.Unspecified), "Activity  53", 1, new DateTime(2024, 3, 4, 8, 39, 58, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2024, 6, 30, 7, 16, 14, 0, DateTimeKind.Unspecified), "Activity  54", 1, new DateTime(2024, 10, 5, 2, 0, 59, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2024, 8, 31, 20, 23, 52, 0, DateTimeKind.Unspecified), "Activity  55", 1, new DateTime(2024, 9, 10, 10, 14, 9, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2024, 3, 23, 7, 30, 15, 0, DateTimeKind.Unspecified), "Activity  56", 1, new DateTime(2024, 5, 29, 23, 56, 10, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2024, 4, 9, 18, 34, 24, 0, DateTimeKind.Unspecified), "Activity  57", 1, new DateTime(2024, 12, 21, 11, 28, 55, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2024, 3, 12, 4, 55, 21, 0, DateTimeKind.Unspecified), "Activity  58", 1, new DateTime(2024, 7, 5, 18, 45, 18, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2024, 7, 9, 5, 59, 7, 0, DateTimeKind.Unspecified), "Activity  59", 1, new DateTime(2024, 9, 13, 2, 53, 42, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2024, 1, 24, 12, 25, 52, 0, DateTimeKind.Unspecified), "Activity  60", 1, new DateTime(2024, 8, 12, 4, 27, 59, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2024, 1, 23, 14, 51, 35, 0, DateTimeKind.Unspecified), "Activity  61", 1, new DateTime(2024, 2, 7, 17, 20, 28, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2024, 11, 26, 2, 22, 38, 0, DateTimeKind.Unspecified), "Activity  62", 1, new DateTime(2024, 11, 29, 3, 44, 25, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2024, 4, 9, 18, 1, 53, 0, DateTimeKind.Unspecified), "Activity  63", 1, new DateTime(2024, 6, 6, 7, 55, 5, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2024, 9, 24, 21, 47, 32, 0, DateTimeKind.Unspecified), "Activity  64", 1, new DateTime(2024, 12, 3, 12, 47, 55, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2024, 6, 24, 4, 20, 20, 0, DateTimeKind.Unspecified), "Activity  65", 1, new DateTime(2024, 8, 16, 23, 38, 40, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2024, 7, 21, 22, 26, 41, 0, DateTimeKind.Unspecified), "Activity  66", 1, new DateTime(2024, 7, 28, 11, 45, 32, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2024, 4, 26, 23, 40, 28, 0, DateTimeKind.Unspecified), "Activity  67", 1, new DateTime(2024, 12, 4, 4, 6, 20, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2024, 12, 15, 6, 42, 21, 0, DateTimeKind.Unspecified), "Activity  68", 1, new DateTime(2024, 8, 21, 19, 8, 47, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2024, 10, 27, 20, 10, 21, 0, DateTimeKind.Unspecified), "Activity  69", 1, new DateTime(2024, 5, 9, 14, 38, 17, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2024, 11, 15, 0, 35, 37, 0, DateTimeKind.Unspecified), "Activity  70", 1, new DateTime(2024, 10, 11, 20, 10, 52, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2024, 6, 7, 8, 33, 9, 0, DateTimeKind.Unspecified), "Activity  71", 1, new DateTime(2024, 12, 29, 16, 17, 55, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2024, 11, 22, 4, 34, 21, 0, DateTimeKind.Unspecified), "Activity  72", 1, new DateTime(2024, 5, 17, 12, 12, 29, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2024, 4, 2, 12, 1, 53, 0, DateTimeKind.Unspecified), "Activity  73", 1, new DateTime(2024, 7, 29, 20, 32, 49, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2024, 11, 29, 10, 18, 2, 0, DateTimeKind.Unspecified), "Activity  74", 1, new DateTime(2024, 8, 28, 8, 36, 10, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2024, 3, 20, 23, 16, 5, 0, DateTimeKind.Unspecified), "Activity  75", 1, new DateTime(2024, 10, 13, 17, 18, 0, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(2024, 7, 19, 5, 9, 14, 0, DateTimeKind.Unspecified), "Activity  76", 1, new DateTime(2024, 6, 21, 21, 23, 51, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(2024, 2, 25, 17, 14, 13, 0, DateTimeKind.Unspecified), "Activity  77", 1, new DateTime(2024, 9, 25, 11, 41, 56, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(2024, 9, 21, 6, 50, 5, 0, DateTimeKind.Unspecified), "Activity  78", 1, new DateTime(2024, 12, 19, 20, 59, 39, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(2024, 6, 27, 11, 59, 7, 0, DateTimeKind.Unspecified), "Activity  79", 1, new DateTime(2024, 2, 20, 2, 31, 28, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(2024, 10, 3, 8, 41, 43, 0, DateTimeKind.Unspecified), "Activity  80", 1, new DateTime(2024, 5, 8, 17, 28, 47, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(2024, 5, 29, 11, 6, 58, 0, DateTimeKind.Unspecified), "Activity  81", 1, new DateTime(2024, 11, 16, 12, 51, 23, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(2024, 5, 30, 23, 13, 49, 0, DateTimeKind.Unspecified), "Activity  82", 1, new DateTime(2024, 9, 25, 14, 26, 6, 0, DateTimeKind.Unspecified) },
                    { 83, new DateTime(2024, 12, 6, 19, 23, 18, 0, DateTimeKind.Unspecified), "Activity  83", 1, new DateTime(2024, 9, 29, 18, 3, 17, 0, DateTimeKind.Unspecified) },
                    { 84, new DateTime(2024, 5, 18, 6, 15, 21, 0, DateTimeKind.Unspecified), "Activity  84", 1, new DateTime(2024, 9, 23, 2, 13, 56, 0, DateTimeKind.Unspecified) },
                    { 85, new DateTime(2024, 11, 15, 20, 39, 24, 0, DateTimeKind.Unspecified), "Activity  85", 1, new DateTime(2024, 7, 20, 15, 3, 45, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(2024, 8, 23, 3, 18, 26, 0, DateTimeKind.Unspecified), "Activity  86", 1, new DateTime(2024, 12, 18, 11, 38, 44, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(2024, 3, 16, 20, 39, 4, 0, DateTimeKind.Unspecified), "Activity  87", 1, new DateTime(2024, 6, 28, 3, 51, 16, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(2024, 11, 20, 17, 46, 19, 0, DateTimeKind.Unspecified), "Activity  88", 1, new DateTime(2024, 4, 6, 5, 17, 41, 0, DateTimeKind.Unspecified) },
                    { 89, new DateTime(2024, 3, 3, 20, 16, 55, 0, DateTimeKind.Unspecified), "Activity  89", 1, new DateTime(2024, 6, 13, 13, 24, 19, 0, DateTimeKind.Unspecified) },
                    { 90, new DateTime(2024, 1, 22, 13, 18, 12, 0, DateTimeKind.Unspecified), "Activity  90", 1, new DateTime(2024, 7, 12, 21, 47, 35, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2024, 12, 19, 3, 44, 15, 0, DateTimeKind.Unspecified), "Activity  91", 1, new DateTime(2024, 1, 10, 15, 3, 44, 0, DateTimeKind.Unspecified) },
                    { 92, new DateTime(2024, 4, 12, 17, 13, 5, 0, DateTimeKind.Unspecified), "Activity  92", 1, new DateTime(2024, 1, 9, 15, 49, 55, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(2024, 10, 7, 12, 45, 17, 0, DateTimeKind.Unspecified), "Activity  93", 1, new DateTime(2024, 6, 26, 13, 28, 8, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(2024, 2, 3, 2, 24, 43, 0, DateTimeKind.Unspecified), "Activity  94", 1, new DateTime(2024, 9, 12, 13, 31, 36, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(2024, 6, 21, 23, 54, 32, 0, DateTimeKind.Unspecified), "Activity  95", 1, new DateTime(2024, 8, 31, 17, 48, 11, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(2024, 12, 3, 6, 23, 3, 0, DateTimeKind.Unspecified), "Activity  96", 1, new DateTime(2024, 12, 3, 17, 39, 17, 0, DateTimeKind.Unspecified) },
                    { 97, new DateTime(2024, 11, 7, 18, 45, 14, 0, DateTimeKind.Unspecified), "Activity  97", 1, new DateTime(2024, 5, 17, 0, 17, 47, 0, DateTimeKind.Unspecified) },
                    { 98, new DateTime(2024, 12, 22, 12, 30, 5, 0, DateTimeKind.Unspecified), "Activity  98", 1, new DateTime(2024, 4, 20, 14, 20, 52, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(2024, 10, 24, 22, 18, 54, 0, DateTimeKind.Unspecified), "Activity  99", 1, new DateTime(2024, 6, 11, 9, 16, 37, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "Sweden" },
                    { 2, "Germany" },
                    { 3, "Netherlands" },
                    { 4, "Denmark" },
                    { 5, "Finland" },
                    { 6, "Island" },
                    { 7, "UK" },
                    { 8, "France" },
                    { 9, "Norway" },
                    { 10, "Belgium" }
                });

            migrationBuilder.InsertData(
                table: "RoleCategories",
                columns: new[] { "RoleCategoryId", "RoleCategoryName" },
                values: new object[,]
                {
                    { 1, "Management" },
                    { 2, "Administration" },
                    { 3, "Finance" },
                    { 4, "IT" },
                    { 5, "Consulting" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "ImageName", "IsOnHoliday", "JoinedDate", "LastName", "Latitude", "Longitude", "MaritalStatus", "PhoneNumber", "RoleCategoryId", "Smoker", "Street", "Zip" },
                values: new object[] { 1, new DateTime(1995, 8, 12, 12, 16, 10, 44, DateTimeKind.Unspecified).AddTicks(1539), "Stockholm", "Generated registration on model creating", 1, "generated.person@registered.test", null, "Anna", 1, null, false, new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 59.333219999999997, 18.064879999999999, 0, "070000000", 1, false, "Sveavägen 1", "11157" });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CountryId",
                table: "Persons",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_RoleCategoryId",
                table: "Persons",
                column: "RoleCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "RoleCategories");
        }
    }
}
