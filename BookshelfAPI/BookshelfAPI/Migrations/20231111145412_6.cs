using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookshelfAPI.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    authorId = table.Column<long>(type: "bigint", maxLength: 12, nullable: false),
                    publishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1L, "Hilary Maj" },
                    { 2L, "Henryka Kołakowski" },
                    { 3L, "Maksym Mucha" },
                    { 4L, "Zachary Czajkowski" },
                    { 5L, "Anna Mika" },
                    { 6L, "Miron Bukowski" },
                    { 7L, "Filip Staniszewski" },
                    { 8L, "Artur Ostrowski" },
                    { 9L, "Galfryd Smoliński" },
                    { 10L, "Ilona Murawski" },
                    { 11L, "Elżbieta Grzyb" },
                    { 12L, "Cezary Piekarski" },
                    { 13L, "Patrycy Borowski" },
                    { 14L, "Damian Sokół" },
                    { 15L, "Gertruda Skiba" },
                    { 16L, "Beniamin Kucharczyk" },
                    { 17L, "Maksym Kucharczyk" },
                    { 18L, "Fryderyk Woźniak" },
                    { 19L, "Roksana Gutowski" },
                    { 20L, "Tobiasz Włodarczyk" },
                    { 21L, "Laurencjusz Gruszczyński" },
                    { 22L, "Bazyli Wojtas" },
                    { 23L, "Żaneta Jóźwik" },
                    { 24L, "Cecylia Misztal" },
                    { 25L, "Sylwester Krawczyk" },
                    { 26L, "Krystian Borowski" },
                    { 27L, "Wiara Skowron" },
                    { 28L, "Wincenty Żurek" },
                    { 29L, "Piotr Bożek" },
                    { 30L, "Ksawera Janas" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "authorId", "name", "publishDate" },
                values: new object[,]
                {
                    { 1L, 18L, "Intelligent Granite Fish", new DateTime(2023, 6, 17, 0, 6, 0, 435, DateTimeKind.Local).AddTicks(4898) },
                    { 2L, 14L, "Incredible Rubber Towels", new DateTime(2023, 9, 26, 21, 26, 7, 944, DateTimeKind.Local).AddTicks(1121) },
                    { 3L, 18L, "Generic Rubber Pants", new DateTime(2023, 10, 10, 9, 50, 51, 750, DateTimeKind.Local).AddTicks(2113) },
                    { 4L, 19L, "Practical Soft Car", new DateTime(2023, 3, 28, 10, 34, 6, 780, DateTimeKind.Local).AddTicks(4770) },
                    { 5L, 2L, "Intelligent Soft Fish", new DateTime(2023, 4, 11, 11, 44, 36, 32, DateTimeKind.Local).AddTicks(2146) },
                    { 6L, 9L, "Handcrafted Concrete Computer", new DateTime(2023, 3, 17, 9, 55, 21, 986, DateTimeKind.Local).AddTicks(8943) },
                    { 7L, 24L, "Fantastic Steel Keyboard", new DateTime(2023, 2, 2, 4, 59, 27, 989, DateTimeKind.Local).AddTicks(2881) },
                    { 8L, 4L, "Handmade Soft Car", new DateTime(2023, 6, 4, 2, 53, 21, 632, DateTimeKind.Local).AddTicks(2587) },
                    { 9L, 23L, "Incredible Cotton Mouse", new DateTime(2022, 12, 10, 0, 51, 11, 788, DateTimeKind.Local).AddTicks(1686) },
                    { 10L, 29L, "Unbranded Concrete Hat", new DateTime(2022, 12, 3, 1, 57, 47, 982, DateTimeKind.Local).AddTicks(5099) },
                    { 11L, 18L, "Incredible Concrete Car", new DateTime(2022, 12, 14, 23, 36, 6, 192, DateTimeKind.Local).AddTicks(6133) },
                    { 12L, 10L, "Handmade Plastic Tuna", new DateTime(2023, 4, 17, 11, 40, 32, 905, DateTimeKind.Local).AddTicks(1299) },
                    { 13L, 29L, "Sleek Cotton Computer", new DateTime(2023, 10, 16, 11, 24, 47, 653, DateTimeKind.Local).AddTicks(8111) },
                    { 14L, 16L, "Tasty Soft Hat", new DateTime(2022, 11, 12, 7, 45, 28, 110, DateTimeKind.Local).AddTicks(574) },
                    { 15L, 10L, "Practical Steel Chips", new DateTime(2023, 8, 2, 13, 27, 35, 798, DateTimeKind.Local).AddTicks(3235) },
                    { 16L, 12L, "Practical Soft Shirt", new DateTime(2023, 1, 1, 18, 8, 9, 676, DateTimeKind.Local).AddTicks(6896) },
                    { 17L, 3L, "Sleek Frozen Fish", new DateTime(2022, 11, 19, 14, 1, 20, 392, DateTimeKind.Local).AddTicks(9396) },
                    { 18L, 12L, "Generic Wooden Chicken", new DateTime(2022, 11, 24, 16, 22, 38, 417, DateTimeKind.Local).AddTicks(9722) },
                    { 19L, 23L, "Gorgeous Soft Ball", new DateTime(2023, 5, 28, 8, 8, 38, 425, DateTimeKind.Local).AddTicks(8425) },
                    { 20L, 20L, "Rustic Wooden Salad", new DateTime(2023, 10, 6, 9, 23, 53, 105, DateTimeKind.Local).AddTicks(7644) },
                    { 21L, 25L, "Practical Rubber Ball", new DateTime(2023, 7, 24, 3, 16, 26, 259, DateTimeKind.Local).AddTicks(6586) },
                    { 22L, 6L, "Handcrafted Steel Shoes", new DateTime(2023, 4, 7, 22, 51, 29, 277, DateTimeKind.Local).AddTicks(8483) },
                    { 23L, 8L, "Unbranded Concrete Hat", new DateTime(2023, 1, 4, 22, 34, 26, 552, DateTimeKind.Local).AddTicks(3977) },
                    { 24L, 23L, "Gorgeous Concrete Shoes", new DateTime(2023, 5, 9, 11, 22, 47, 729, DateTimeKind.Local).AddTicks(1211) },
                    { 25L, 11L, "Licensed Concrete Table", new DateTime(2023, 1, 8, 11, 20, 35, 207, DateTimeKind.Local).AddTicks(4922) },
                    { 26L, 13L, "Awesome Metal Chips", new DateTime(2023, 7, 4, 3, 16, 42, 102, DateTimeKind.Local).AddTicks(2742) },
                    { 27L, 22L, "Handmade Wooden Bacon", new DateTime(2023, 9, 7, 8, 29, 51, 83, DateTimeKind.Local).AddTicks(2533) },
                    { 28L, 29L, "Sleek Steel Bacon", new DateTime(2023, 8, 18, 0, 51, 42, 169, DateTimeKind.Local).AddTicks(9822) },
                    { 29L, 9L, "Rustic Fresh Pizza", new DateTime(2022, 12, 19, 13, 45, 7, 178, DateTimeKind.Local).AddTicks(9744) },
                    { 30L, 8L, "Sleek Wooden Mouse", new DateTime(2023, 5, 18, 17, 10, 16, 178, DateTimeKind.Local).AddTicks(6025) },
                    { 31L, 9L, "Practical Wooden Car", new DateTime(2023, 6, 20, 3, 11, 50, 908, DateTimeKind.Local).AddTicks(2490) },
                    { 32L, 7L, "Generic Fresh Fish", new DateTime(2022, 11, 14, 10, 38, 44, 162, DateTimeKind.Local).AddTicks(9879) },
                    { 33L, 10L, "Incredible Soft Tuna", new DateTime(2022, 11, 25, 21, 41, 51, 660, DateTimeKind.Local).AddTicks(2548) },
                    { 34L, 7L, "Handmade Steel Hat", new DateTime(2023, 2, 5, 7, 22, 20, 801, DateTimeKind.Local).AddTicks(9956) },
                    { 35L, 26L, "Awesome Frozen Soap", new DateTime(2023, 5, 5, 10, 18, 36, 715, DateTimeKind.Local).AddTicks(3484) },
                    { 36L, 29L, "Rustic Plastic Computer", new DateTime(2023, 1, 15, 1, 52, 13, 86, DateTimeKind.Local).AddTicks(5396) },
                    { 37L, 3L, "Fantastic Plastic Chicken", new DateTime(2023, 7, 6, 17, 24, 3, 460, DateTimeKind.Local).AddTicks(2737) },
                    { 38L, 12L, "Fantastic Rubber Chips", new DateTime(2023, 2, 25, 20, 49, 45, 535, DateTimeKind.Local).AddTicks(8439) },
                    { 39L, 4L, "Tasty Frozen Shirt", new DateTime(2023, 6, 7, 11, 50, 30, 634, DateTimeKind.Local).AddTicks(1177) },
                    { 40L, 8L, "Generic Rubber Fish", new DateTime(2022, 12, 31, 13, 18, 22, 390, DateTimeKind.Local).AddTicks(5209) },
                    { 41L, 14L, "Practical Fresh Pizza", new DateTime(2023, 2, 25, 22, 47, 29, 403, DateTimeKind.Local).AddTicks(9960) },
                    { 42L, 9L, "Practical Fresh Shoes", new DateTime(2023, 9, 29, 2, 36, 35, 154, DateTimeKind.Local).AddTicks(294) },
                    { 43L, 18L, "Fantastic Steel Gloves", new DateTime(2023, 4, 6, 6, 31, 8, 350, DateTimeKind.Local).AddTicks(3656) },
                    { 44L, 5L, "Sleek Metal Gloves", new DateTime(2023, 9, 12, 1, 18, 37, 1, DateTimeKind.Local).AddTicks(3329) },
                    { 45L, 9L, "Small Concrete Chair", new DateTime(2023, 7, 4, 3, 5, 12, 328, DateTimeKind.Local).AddTicks(7495) },
                    { 46L, 14L, "Rustic Cotton Soap", new DateTime(2023, 2, 21, 20, 6, 47, 675, DateTimeKind.Local).AddTicks(6913) },
                    { 47L, 7L, "Licensed Frozen Chips", new DateTime(2023, 1, 16, 22, 57, 32, 30, DateTimeKind.Local).AddTicks(9951) },
                    { 48L, 4L, "Handcrafted Wooden Mouse", new DateTime(2023, 11, 10, 23, 48, 53, 629, DateTimeKind.Local).AddTicks(8139) },
                    { 49L, 9L, "Intelligent Metal Computer", new DateTime(2023, 7, 15, 4, 2, 14, 862, DateTimeKind.Local).AddTicks(5185) },
                    { 50L, 21L, "Practical Cotton Shirt", new DateTime(2023, 5, 14, 2, 53, 9, 145, DateTimeKind.Local).AddTicks(735) },
                    { 51L, 19L, "Licensed Rubber Chips", new DateTime(2023, 7, 19, 0, 51, 3, 683, DateTimeKind.Local).AddTicks(8245) },
                    { 52L, 25L, "Gorgeous Cotton Mouse", new DateTime(2023, 7, 20, 5, 9, 5, 402, DateTimeKind.Local).AddTicks(8376) },
                    { 53L, 2L, "Generic Concrete Shirt", new DateTime(2023, 7, 11, 15, 58, 43, 601, DateTimeKind.Local).AddTicks(9388) },
                    { 54L, 16L, "Awesome Cotton Chicken", new DateTime(2023, 10, 26, 19, 44, 40, 851, DateTimeKind.Local).AddTicks(7271) },
                    { 55L, 21L, "Gorgeous Wooden Sausages", new DateTime(2023, 5, 12, 14, 15, 21, 887, DateTimeKind.Local).AddTicks(8415) },
                    { 56L, 25L, "Unbranded Metal Table", new DateTime(2023, 8, 4, 11, 2, 37, 660, DateTimeKind.Local).AddTicks(1588) },
                    { 57L, 3L, "Unbranded Plastic Shirt", new DateTime(2023, 1, 27, 12, 5, 18, 791, DateTimeKind.Local).AddTicks(3612) },
                    { 58L, 1L, "Awesome Frozen Fish", new DateTime(2023, 4, 3, 0, 19, 43, 374, DateTimeKind.Local).AddTicks(9461) },
                    { 59L, 21L, "Refined Granite Towels", new DateTime(2023, 3, 31, 9, 51, 33, 328, DateTimeKind.Local).AddTicks(7163) },
                    { 60L, 1L, "Fantastic Plastic Table", new DateTime(2023, 6, 21, 23, 41, 37, 371, DateTimeKind.Local).AddTicks(4563) },
                    { 61L, 5L, "Handmade Metal Mouse", new DateTime(2023, 6, 3, 6, 23, 1, 733, DateTimeKind.Local).AddTicks(6128) },
                    { 62L, 12L, "Handcrafted Fresh Table", new DateTime(2023, 1, 14, 20, 53, 59, 724, DateTimeKind.Local).AddTicks(9829) },
                    { 63L, 19L, "Small Steel Car", new DateTime(2023, 8, 5, 19, 5, 3, 128, DateTimeKind.Local).AddTicks(9341) },
                    { 64L, 11L, "Sleek Fresh Soap", new DateTime(2023, 9, 23, 1, 51, 48, 648, DateTimeKind.Local).AddTicks(9142) },
                    { 65L, 6L, "Ergonomic Metal Shirt", new DateTime(2022, 11, 24, 15, 5, 53, 275, DateTimeKind.Local).AddTicks(2831) },
                    { 66L, 19L, "Tasty Cotton Fish", new DateTime(2023, 3, 26, 0, 3, 24, 697, DateTimeKind.Local).AddTicks(5549) },
                    { 67L, 9L, "Sleek Soft Shoes", new DateTime(2023, 11, 4, 6, 40, 13, 559, DateTimeKind.Local).AddTicks(3350) },
                    { 68L, 10L, "Licensed Steel Tuna", new DateTime(2022, 11, 22, 10, 52, 15, 224, DateTimeKind.Local).AddTicks(8188) },
                    { 69L, 21L, "Handcrafted Granite Cheese", new DateTime(2023, 8, 8, 16, 40, 13, 216, DateTimeKind.Local).AddTicks(6767) },
                    { 70L, 14L, "Practical Steel Soap", new DateTime(2023, 10, 18, 13, 46, 4, 365, DateTimeKind.Local).AddTicks(4) },
                    { 71L, 3L, "Refined Rubber Cheese", new DateTime(2023, 5, 8, 22, 41, 38, 715, DateTimeKind.Local).AddTicks(8046) },
                    { 72L, 18L, "Unbranded Granite Keyboard", new DateTime(2022, 11, 19, 13, 56, 3, 943, DateTimeKind.Local).AddTicks(9695) },
                    { 73L, 11L, "Tasty Cotton Hat", new DateTime(2023, 3, 10, 4, 43, 46, 920, DateTimeKind.Local).AddTicks(4342) },
                    { 74L, 14L, "Refined Granite Shirt", new DateTime(2023, 7, 11, 7, 24, 29, 132, DateTimeKind.Local).AddTicks(314) },
                    { 75L, 4L, "Unbranded Rubber Chips", new DateTime(2022, 12, 22, 11, 36, 25, 572, DateTimeKind.Local).AddTicks(5589) },
                    { 76L, 10L, "Fantastic Cotton Chair", new DateTime(2022, 11, 24, 14, 52, 5, 858, DateTimeKind.Local).AddTicks(3533) },
                    { 77L, 10L, "Fantastic Wooden Towels", new DateTime(2022, 12, 2, 20, 16, 15, 711, DateTimeKind.Local).AddTicks(7890) },
                    { 78L, 12L, "Rustic Plastic Chicken", new DateTime(2023, 10, 8, 23, 18, 10, 59, DateTimeKind.Local).AddTicks(5565) },
                    { 79L, 25L, "Rustic Plastic Computer", new DateTime(2023, 6, 19, 23, 43, 39, 106, DateTimeKind.Local).AddTicks(2645) },
                    { 80L, 4L, "Handcrafted Concrete Fish", new DateTime(2022, 11, 13, 23, 52, 3, 441, DateTimeKind.Local).AddTicks(7370) },
                    { 81L, 13L, "Handcrafted Granite Car", new DateTime(2023, 6, 25, 19, 24, 35, 711, DateTimeKind.Local).AddTicks(5155) },
                    { 82L, 24L, "Awesome Frozen Computer", new DateTime(2023, 8, 21, 6, 8, 10, 958, DateTimeKind.Local).AddTicks(6523) },
                    { 83L, 15L, "Rustic Cotton Pants", new DateTime(2022, 12, 19, 0, 48, 46, 236, DateTimeKind.Local).AddTicks(16) },
                    { 84L, 12L, "Small Metal Chicken", new DateTime(2023, 6, 7, 0, 39, 28, 290, DateTimeKind.Local).AddTicks(7295) },
                    { 85L, 8L, "Awesome Soft Computer", new DateTime(2023, 1, 23, 21, 37, 21, 151, DateTimeKind.Local).AddTicks(7661) },
                    { 86L, 18L, "Unbranded Concrete Pizza", new DateTime(2023, 4, 1, 19, 33, 13, 15, DateTimeKind.Local).AddTicks(9014) },
                    { 87L, 8L, "Handmade Cotton Towels", new DateTime(2023, 5, 5, 18, 30, 32, 213, DateTimeKind.Local).AddTicks(2065) },
                    { 88L, 20L, "Fantastic Steel Chicken", new DateTime(2023, 3, 6, 2, 26, 44, 286, DateTimeKind.Local).AddTicks(2479) },
                    { 89L, 17L, "Refined Frozen Bike", new DateTime(2022, 12, 28, 4, 46, 50, 51, DateTimeKind.Local).AddTicks(8050) },
                    { 90L, 13L, "Incredible Metal Shirt", new DateTime(2023, 6, 9, 1, 27, 27, 146, DateTimeKind.Local).AddTicks(6225) },
                    { 91L, 22L, "Small Plastic Bacon", new DateTime(2023, 2, 27, 19, 17, 2, 665, DateTimeKind.Local).AddTicks(3505) },
                    { 92L, 5L, "Tasty Soft Car", new DateTime(2023, 6, 7, 19, 49, 18, 247, DateTimeKind.Local).AddTicks(2908) },
                    { 93L, 21L, "Generic Metal Bacon", new DateTime(2022, 12, 31, 16, 3, 46, 415, DateTimeKind.Local).AddTicks(8760) },
                    { 94L, 23L, "Rustic Frozen Car", new DateTime(2023, 5, 19, 3, 5, 8, 843, DateTimeKind.Local).AddTicks(9480) },
                    { 95L, 9L, "Generic Granite Tuna", new DateTime(2023, 9, 22, 13, 48, 5, 118, DateTimeKind.Local).AddTicks(6630) },
                    { 96L, 23L, "Practical Rubber Pizza", new DateTime(2023, 10, 1, 2, 16, 56, 63, DateTimeKind.Local).AddTicks(2304) },
                    { 97L, 18L, "Handmade Metal Car", new DateTime(2023, 10, 17, 5, 26, 9, 631, DateTimeKind.Local).AddTicks(6292) },
                    { 98L, 12L, "Sleek Fresh Car", new DateTime(2022, 12, 7, 7, 35, 9, 882, DateTimeKind.Local).AddTicks(674) },
                    { 99L, 23L, "Fantastic Metal Bacon", new DateTime(2023, 4, 13, 17, 51, 30, 785, DateTimeKind.Local).AddTicks(1414) },
                    { 100L, 26L, "Fantastic Wooden Tuna", new DateTime(2022, 11, 19, 20, 54, 43, 165, DateTimeKind.Local).AddTicks(746) },
                    { 101L, 20L, "Fantastic Wooden Pizza", new DateTime(2023, 2, 27, 2, 4, 35, 254, DateTimeKind.Local).AddTicks(2227) },
                    { 102L, 22L, "Intelligent Fresh Towels", new DateTime(2022, 12, 11, 6, 48, 57, 977, DateTimeKind.Local).AddTicks(527) },
                    { 103L, 16L, "Unbranded Soft Bike", new DateTime(2022, 12, 22, 19, 16, 49, 865, DateTimeKind.Local).AddTicks(1709) },
                    { 104L, 22L, "Small Concrete Chips", new DateTime(2023, 6, 11, 7, 30, 51, 682, DateTimeKind.Local).AddTicks(2326) },
                    { 105L, 25L, "Sleek Metal Chips", new DateTime(2023, 7, 18, 14, 6, 43, 792, DateTimeKind.Local).AddTicks(6406) },
                    { 106L, 21L, "Handmade Frozen Sausages", new DateTime(2023, 1, 16, 13, 7, 0, 41, DateTimeKind.Local).AddTicks(474) },
                    { 107L, 3L, "Generic Fresh Shoes", new DateTime(2023, 6, 2, 8, 16, 15, 570, DateTimeKind.Local).AddTicks(203) },
                    { 108L, 27L, "Rustic Granite Computer", new DateTime(2023, 5, 15, 15, 6, 41, 682, DateTimeKind.Local).AddTicks(3264) },
                    { 109L, 9L, "Refined Metal Cheese", new DateTime(2023, 7, 20, 4, 34, 21, 749, DateTimeKind.Local).AddTicks(6198) },
                    { 110L, 6L, "Handmade Wooden Sausages", new DateTime(2022, 12, 14, 1, 35, 29, 990, DateTimeKind.Local).AddTicks(7274) },
                    { 111L, 14L, "Ergonomic Wooden Mouse", new DateTime(2023, 2, 12, 22, 13, 35, 3, DateTimeKind.Local).AddTicks(6499) },
                    { 112L, 27L, "Generic Concrete Sausages", new DateTime(2023, 10, 1, 4, 37, 33, 193, DateTimeKind.Local).AddTicks(3271) },
                    { 113L, 11L, "Handcrafted Cotton Computer", new DateTime(2023, 3, 10, 19, 47, 31, 205, DateTimeKind.Local).AddTicks(6008) },
                    { 114L, 6L, "Intelligent Plastic Ball", new DateTime(2023, 6, 20, 23, 21, 46, 569, DateTimeKind.Local).AddTicks(6365) },
                    { 115L, 8L, "Rustic Steel Computer", new DateTime(2023, 7, 30, 20, 15, 22, 656, DateTimeKind.Local).AddTicks(6483) },
                    { 116L, 16L, "Incredible Wooden Cheese", new DateTime(2023, 6, 17, 12, 12, 16, 235, DateTimeKind.Local).AddTicks(9488) },
                    { 117L, 2L, "Generic Soft Car", new DateTime(2023, 7, 3, 7, 58, 54, 630, DateTimeKind.Local).AddTicks(7295) },
                    { 118L, 9L, "Sleek Metal Fish", new DateTime(2023, 7, 8, 21, 44, 39, 169, DateTimeKind.Local).AddTicks(7070) },
                    { 119L, 10L, "Licensed Steel Bike", new DateTime(2023, 4, 12, 14, 19, 56, 164, DateTimeKind.Local).AddTicks(9196) },
                    { 120L, 26L, "Licensed Concrete Bike", new DateTime(2023, 6, 19, 7, 11, 4, 484, DateTimeKind.Local).AddTicks(4836) },
                    { 121L, 4L, "Tasty Cotton Cheese", new DateTime(2023, 2, 9, 5, 47, 48, 899, DateTimeKind.Local).AddTicks(4291) },
                    { 122L, 23L, "Fantastic Cotton Gloves", new DateTime(2023, 5, 7, 1, 56, 42, 452, DateTimeKind.Local).AddTicks(4483) },
                    { 123L, 11L, "Fantastic Cotton Keyboard", new DateTime(2023, 3, 17, 5, 59, 54, 59, DateTimeKind.Local).AddTicks(9741) },
                    { 124L, 19L, "Small Metal Towels", new DateTime(2022, 11, 19, 21, 40, 57, 722, DateTimeKind.Local).AddTicks(8051) },
                    { 125L, 22L, "Incredible Soft Computer", new DateTime(2023, 1, 2, 5, 17, 42, 514, DateTimeKind.Local).AddTicks(7906) },
                    { 126L, 22L, "Rustic Rubber Soap", new DateTime(2023, 11, 10, 5, 53, 53, 38, DateTimeKind.Local).AddTicks(9691) },
                    { 127L, 27L, "Handcrafted Soft Salad", new DateTime(2023, 9, 27, 19, 37, 44, 505, DateTimeKind.Local).AddTicks(8581) },
                    { 128L, 28L, "Ergonomic Metal Soap", new DateTime(2022, 11, 25, 14, 31, 12, 752, DateTimeKind.Local).AddTicks(3404) },
                    { 129L, 1L, "Refined Metal Gloves", new DateTime(2022, 11, 20, 10, 19, 2, 394, DateTimeKind.Local).AddTicks(2503) },
                    { 130L, 25L, "Fantastic Steel Chair", new DateTime(2023, 9, 4, 12, 16, 34, 202, DateTimeKind.Local).AddTicks(4758) },
                    { 131L, 6L, "Practical Granite Chips", new DateTime(2023, 9, 24, 0, 39, 46, 549, DateTimeKind.Local).AddTicks(1207) },
                    { 132L, 21L, "Awesome Steel Gloves", new DateTime(2023, 9, 26, 19, 46, 44, 547, DateTimeKind.Local).AddTicks(8799) },
                    { 133L, 6L, "Sleek Concrete Bike", new DateTime(2023, 10, 28, 7, 49, 10, 877, DateTimeKind.Local).AddTicks(5852) },
                    { 134L, 15L, "Ergonomic Cotton Ball", new DateTime(2023, 6, 11, 12, 8, 43, 332, DateTimeKind.Local).AddTicks(1751) },
                    { 135L, 28L, "Handmade Soft Computer", new DateTime(2023, 3, 17, 17, 33, 21, 44, DateTimeKind.Local).AddTicks(1601) },
                    { 136L, 11L, "Awesome Concrete Table", new DateTime(2023, 2, 22, 5, 19, 15, 61, DateTimeKind.Local).AddTicks(8061) },
                    { 137L, 11L, "Licensed Concrete Bacon", new DateTime(2023, 7, 20, 16, 37, 46, 703, DateTimeKind.Local).AddTicks(3668) },
                    { 138L, 22L, "Incredible Rubber Soap", new DateTime(2023, 7, 21, 1, 20, 18, 102, DateTimeKind.Local).AddTicks(2357) },
                    { 139L, 22L, "Licensed Frozen Table", new DateTime(2023, 4, 7, 9, 1, 27, 600, DateTimeKind.Local).AddTicks(1281) },
                    { 140L, 23L, "Generic Granite Shoes", new DateTime(2023, 4, 2, 14, 9, 20, 159, DateTimeKind.Local).AddTicks(5686) },
                    { 141L, 6L, "Practical Soft Tuna", new DateTime(2023, 1, 4, 21, 54, 35, 378, DateTimeKind.Local).AddTicks(7594) },
                    { 142L, 4L, "Practical Rubber Salad", new DateTime(2023, 5, 25, 9, 13, 53, 54, DateTimeKind.Local).AddTicks(1077) },
                    { 143L, 9L, "Practical Fresh Bike", new DateTime(2023, 4, 6, 0, 17, 43, 992, DateTimeKind.Local).AddTicks(3311) },
                    { 144L, 12L, "Tasty Plastic Tuna", new DateTime(2023, 8, 18, 5, 42, 40, 1, DateTimeKind.Local).AddTicks(3404) },
                    { 145L, 6L, "Ergonomic Concrete Pants", new DateTime(2023, 7, 6, 13, 41, 28, 307, DateTimeKind.Local).AddTicks(488) },
                    { 146L, 16L, "Intelligent Steel Cheese", new DateTime(2022, 12, 19, 4, 38, 11, 955, DateTimeKind.Local).AddTicks(4956) },
                    { 147L, 24L, "Generic Frozen Ball", new DateTime(2023, 9, 17, 7, 23, 13, 89, DateTimeKind.Local).AddTicks(9292) },
                    { 148L, 11L, "Unbranded Metal Bacon", new DateTime(2023, 7, 31, 23, 13, 57, 829, DateTimeKind.Local).AddTicks(655) },
                    { 149L, 20L, "Gorgeous Granite Bike", new DateTime(2023, 2, 8, 14, 55, 48, 118, DateTimeKind.Local).AddTicks(5557) },
                    { 150L, 7L, "Awesome Rubber Ball", new DateTime(2023, 8, 16, 19, 29, 42, 17, DateTimeKind.Local).AddTicks(2364) },
                    { 151L, 1L, "Incredible Plastic Pizza", new DateTime(2023, 5, 29, 9, 16, 35, 128, DateTimeKind.Local).AddTicks(1615) },
                    { 152L, 20L, "Fantastic Steel Pants", new DateTime(2023, 6, 10, 17, 41, 45, 264, DateTimeKind.Local).AddTicks(3572) },
                    { 153L, 11L, "Gorgeous Concrete Shoes", new DateTime(2023, 7, 8, 19, 40, 42, 975, DateTimeKind.Local).AddTicks(7620) },
                    { 154L, 16L, "Rustic Wooden Shirt", new DateTime(2023, 6, 8, 4, 40, 0, 686, DateTimeKind.Local).AddTicks(4893) },
                    { 155L, 6L, "Tasty Soft Bike", new DateTime(2023, 5, 9, 8, 10, 23, 468, DateTimeKind.Local).AddTicks(3626) },
                    { 156L, 13L, "Gorgeous Metal Hat", new DateTime(2023, 1, 26, 13, 9, 7, 722, DateTimeKind.Local).AddTicks(260) },
                    { 157L, 25L, "Small Frozen Gloves", new DateTime(2023, 5, 25, 5, 39, 6, 296, DateTimeKind.Local).AddTicks(4347) },
                    { 158L, 9L, "Rustic Fresh Chicken", new DateTime(2023, 4, 26, 9, 20, 50, 748, DateTimeKind.Local).AddTicks(366) },
                    { 159L, 1L, "Tasty Wooden Car", new DateTime(2022, 12, 28, 20, 23, 56, 693, DateTimeKind.Local).AddTicks(7126) },
                    { 160L, 2L, "Rustic Plastic Hat", new DateTime(2023, 4, 3, 17, 47, 5, 505, DateTimeKind.Local).AddTicks(869) },
                    { 161L, 22L, "Awesome Fresh Pizza", new DateTime(2023, 2, 18, 7, 26, 23, 136, DateTimeKind.Local).AddTicks(6879) },
                    { 162L, 21L, "Intelligent Granite Keyboard", new DateTime(2023, 9, 10, 21, 15, 4, 933, DateTimeKind.Local).AddTicks(8874) },
                    { 163L, 29L, "Ergonomic Soft Cheese", new DateTime(2023, 1, 16, 7, 15, 42, 833, DateTimeKind.Local).AddTicks(6268) },
                    { 164L, 18L, "Incredible Soft Chips", new DateTime(2023, 4, 12, 20, 42, 0, 375, DateTimeKind.Local).AddTicks(6345) },
                    { 165L, 1L, "Licensed Steel Shirt", new DateTime(2023, 6, 5, 5, 50, 7, 180, DateTimeKind.Local).AddTicks(7363) },
                    { 166L, 15L, "Handcrafted Fresh Gloves", new DateTime(2023, 6, 24, 6, 54, 47, 540, DateTimeKind.Local).AddTicks(9845) },
                    { 167L, 11L, "Sleek Frozen Shirt", new DateTime(2023, 11, 5, 8, 51, 17, 811, DateTimeKind.Local).AddTicks(7489) },
                    { 168L, 9L, "Ergonomic Granite Ball", new DateTime(2023, 3, 14, 18, 47, 37, 596, DateTimeKind.Local).AddTicks(2523) },
                    { 169L, 11L, "Intelligent Rubber Sausages", new DateTime(2023, 6, 9, 9, 37, 50, 201, DateTimeKind.Local).AddTicks(8792) },
                    { 170L, 24L, "Refined Soft Soap", new DateTime(2023, 4, 15, 5, 25, 17, 875, DateTimeKind.Local).AddTicks(6925) },
                    { 171L, 12L, "Licensed Wooden Pants", new DateTime(2023, 7, 14, 6, 23, 44, 386, DateTimeKind.Local).AddTicks(9525) },
                    { 172L, 5L, "Rustic Fresh Mouse", new DateTime(2023, 9, 2, 1, 25, 0, 876, DateTimeKind.Local).AddTicks(370) },
                    { 173L, 9L, "Rustic Granite Car", new DateTime(2023, 10, 12, 20, 12, 57, 858, DateTimeKind.Local).AddTicks(2126) },
                    { 174L, 13L, "Unbranded Steel Salad", new DateTime(2023, 3, 15, 5, 50, 13, 847, DateTimeKind.Local).AddTicks(3499) },
                    { 175L, 15L, "Awesome Granite Mouse", new DateTime(2023, 8, 13, 15, 34, 57, 859, DateTimeKind.Local).AddTicks(3640) },
                    { 176L, 24L, "Ergonomic Wooden Computer", new DateTime(2023, 4, 12, 4, 27, 6, 252, DateTimeKind.Local).AddTicks(5578) },
                    { 177L, 3L, "Sleek Wooden Soap", new DateTime(2023, 2, 19, 21, 17, 25, 613, DateTimeKind.Local).AddTicks(3449) },
                    { 178L, 19L, "Licensed Granite Fish", new DateTime(2023, 11, 6, 1, 57, 5, 773, DateTimeKind.Local).AddTicks(6762) },
                    { 179L, 29L, "Practical Fresh Tuna", new DateTime(2023, 4, 22, 1, 1, 20, 972, DateTimeKind.Local).AddTicks(3058) },
                    { 180L, 15L, "Sleek Frozen Ball", new DateTime(2023, 3, 13, 16, 2, 53, 879, DateTimeKind.Local).AddTicks(2924) },
                    { 181L, 20L, "Handmade Concrete Pizza", new DateTime(2023, 4, 1, 8, 51, 25, 130, DateTimeKind.Local).AddTicks(2253) },
                    { 182L, 3L, "Practical Concrete Fish", new DateTime(2023, 9, 26, 13, 13, 50, 874, DateTimeKind.Local).AddTicks(4046) },
                    { 183L, 22L, "Handmade Plastic Pizza", new DateTime(2023, 6, 30, 7, 34, 45, 14, DateTimeKind.Local).AddTicks(1649) },
                    { 184L, 18L, "Generic Plastic Shoes", new DateTime(2023, 3, 20, 11, 18, 42, 342, DateTimeKind.Local).AddTicks(3747) },
                    { 185L, 23L, "Small Soft Bacon", new DateTime(2023, 10, 31, 4, 34, 39, 450, DateTimeKind.Local).AddTicks(7260) },
                    { 186L, 29L, "Gorgeous Granite Pants", new DateTime(2023, 4, 2, 19, 57, 31, 277, DateTimeKind.Local).AddTicks(7125) },
                    { 187L, 2L, "Handmade Steel Tuna", new DateTime(2023, 10, 1, 21, 32, 54, 469, DateTimeKind.Local).AddTicks(37) },
                    { 188L, 5L, "Practical Plastic Keyboard", new DateTime(2023, 4, 12, 16, 52, 15, 565, DateTimeKind.Local).AddTicks(7243) },
                    { 189L, 15L, "Intelligent Granite Hat", new DateTime(2022, 12, 11, 23, 48, 7, 371, DateTimeKind.Local).AddTicks(136) },
                    { 190L, 13L, "Gorgeous Granite Computer", new DateTime(2023, 7, 21, 1, 52, 43, 950, DateTimeKind.Local).AddTicks(7836) },
                    { 191L, 14L, "Fantastic Granite Chair", new DateTime(2023, 5, 1, 2, 21, 40, 244, DateTimeKind.Local).AddTicks(8086) },
                    { 192L, 18L, "Handcrafted Plastic Shirt", new DateTime(2023, 10, 9, 9, 32, 58, 444, DateTimeKind.Local).AddTicks(1482) },
                    { 193L, 15L, "Incredible Steel Hat", new DateTime(2023, 2, 13, 14, 56, 46, 386, DateTimeKind.Local).AddTicks(955) },
                    { 194L, 5L, "Rustic Concrete Shirt", new DateTime(2023, 8, 9, 20, 8, 27, 987, DateTimeKind.Local).AddTicks(7858) },
                    { 195L, 29L, "Licensed Concrete Salad", new DateTime(2023, 6, 8, 0, 43, 59, 453, DateTimeKind.Local).AddTicks(5897) },
                    { 196L, 23L, "Awesome Rubber Chicken", new DateTime(2023, 7, 1, 3, 16, 28, 27, DateTimeKind.Local).AddTicks(3531) },
                    { 197L, 17L, "Rustic Plastic Keyboard", new DateTime(2023, 10, 21, 4, 1, 3, 90, DateTimeKind.Local).AddTicks(5374) },
                    { 198L, 20L, "Refined Rubber Shirt", new DateTime(2023, 4, 17, 8, 0, 51, 799, DateTimeKind.Local).AddTicks(8275) },
                    { 199L, 8L, "Handcrafted Granite Tuna", new DateTime(2023, 2, 3, 21, 0, 0, 893, DateTimeKind.Local).AddTicks(1335) },
                    { 200L, 5L, "Practical Fresh Sausages", new DateTime(2023, 6, 29, 10, 50, 46, 950, DateTimeKind.Local).AddTicks(895) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "books");
        }
    }
}
