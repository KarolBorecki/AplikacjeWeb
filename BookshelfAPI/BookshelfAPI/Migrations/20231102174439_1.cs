using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookshelfAPI.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 1L, 115L, "Intelligent Granite Fish", new DateTime(2023, 6, 8, 2, 56, 26, 861, DateTimeKind.Local).AddTicks(7225) },
                    { 2L, 66L, "Incredible Rubber Towels", new DateTime(2023, 9, 18, 0, 16, 34, 370, DateTimeKind.Local).AddTicks(4379) },
                    { 3L, 196L, "Generic Rubber Pants", new DateTime(2023, 10, 1, 12, 41, 18, 176, DateTimeKind.Local).AddTicks(5393) },
                    { 4L, 183L, "Practical Soft Car", new DateTime(2023, 3, 19, 13, 24, 33, 206, DateTimeKind.Local).AddTicks(8061) },
                    { 5L, 135L, "Intelligent Soft Fish", new DateTime(2023, 4, 2, 14, 35, 2, 458, DateTimeKind.Local).AddTicks(5455) },
                    { 6L, 123L, "Handcrafted Concrete Computer", new DateTime(2023, 3, 8, 12, 45, 48, 413, DateTimeKind.Local).AddTicks(2259) },
                    { 7L, 110L, "Fantastic Steel Keyboard", new DateTime(2023, 1, 24, 7, 49, 54, 415, DateTimeKind.Local).AddTicks(6156) },
                    { 8L, 124L, "Handmade Soft Car", new DateTime(2023, 5, 26, 5, 43, 48, 58, DateTimeKind.Local).AddTicks(5866) },
                    { 9L, 5L, "Incredible Cotton Mouse", new DateTime(2022, 12, 1, 3, 41, 38, 214, DateTimeKind.Local).AddTicks(4983) },
                    { 10L, 115L, "Unbranded Concrete Hat", new DateTime(2022, 11, 24, 4, 48, 14, 408, DateTimeKind.Local).AddTicks(8415) },
                    { 11L, 41L, "Incredible Concrete Car", new DateTime(2022, 12, 6, 2, 26, 32, 618, DateTimeKind.Local).AddTicks(9458) },
                    { 12L, 192L, "Handmade Plastic Tuna", new DateTime(2023, 4, 8, 14, 30, 59, 331, DateTimeKind.Local).AddTicks(4633) },
                    { 13L, 170L, "Sleek Cotton Computer", new DateTime(2023, 10, 7, 14, 15, 14, 80, DateTimeKind.Local).AddTicks(1455) },
                    { 14L, 115L, "Tasty Soft Hat", new DateTime(2022, 11, 3, 10, 35, 54, 536, DateTimeKind.Local).AddTicks(3927) },
                    { 15L, 113L, "Practical Steel Chips", new DateTime(2023, 7, 24, 16, 18, 2, 224, DateTimeKind.Local).AddTicks(6607) },
                    { 16L, 28L, "Practical Soft Shirt", new DateTime(2022, 12, 23, 20, 58, 36, 103, DateTimeKind.Local).AddTicks(367) },
                    { 17L, 74L, "Sleek Frozen Fish", new DateTime(2022, 11, 10, 16, 51, 46, 819, DateTimeKind.Local).AddTicks(2876) },
                    { 18L, 88L, "Generic Wooden Chicken", new DateTime(2022, 11, 15, 19, 13, 4, 844, DateTimeKind.Local).AddTicks(3201) },
                    { 19L, 22L, "Gorgeous Soft Ball", new DateTime(2023, 5, 19, 10, 59, 4, 852, DateTimeKind.Local).AddTicks(1914) },
                    { 20L, 159L, "Rustic Wooden Salad", new DateTime(2023, 9, 27, 12, 14, 19, 532, DateTimeKind.Local).AddTicks(1132) },
                    { 21L, 146L, "Practical Rubber Ball", new DateTime(2023, 7, 15, 6, 6, 52, 686, DateTimeKind.Local).AddTicks(73) },
                    { 22L, 98L, "Handcrafted Steel Shoes", new DateTime(2023, 3, 30, 1, 41, 55, 704, DateTimeKind.Local).AddTicks(1933) },
                    { 23L, 148L, "Unbranded Concrete Hat", new DateTime(2022, 12, 27, 1, 24, 52, 978, DateTimeKind.Local).AddTicks(7424) },
                    { 24L, 161L, "Gorgeous Concrete Shoes", new DateTime(2023, 4, 30, 14, 13, 14, 155, DateTimeKind.Local).AddTicks(4668) },
                    { 25L, 67L, "Licensed Concrete Table", new DateTime(2022, 12, 30, 14, 11, 1, 633, DateTimeKind.Local).AddTicks(8379) },
                    { 26L, 162L, "Awesome Metal Chips", new DateTime(2023, 6, 25, 6, 7, 8, 528, DateTimeKind.Local).AddTicks(6199) },
                    { 27L, 128L, "Handmade Wooden Bacon", new DateTime(2023, 8, 29, 11, 20, 17, 509, DateTimeKind.Local).AddTicks(6000) },
                    { 28L, 197L, "Sleek Steel Bacon", new DateTime(2023, 8, 9, 3, 42, 8, 596, DateTimeKind.Local).AddTicks(3288) },
                    { 29L, 186L, "Rustic Fresh Pizza", new DateTime(2022, 12, 10, 16, 35, 33, 605, DateTimeKind.Local).AddTicks(3211) },
                    { 30L, 32L, "Sleek Wooden Mouse", new DateTime(2023, 5, 9, 20, 0, 42, 604, DateTimeKind.Local).AddTicks(9492) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 30L);
        }
    }
}
