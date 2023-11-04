using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookshelfAPI.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 111L, new DateTime(2023, 6, 9, 22, 32, 29, 276, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 33L, new DateTime(2023, 9, 19, 19, 52, 36, 785, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 167L, new DateTime(2023, 10, 3, 8, 17, 20, 591, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 27L, new DateTime(2023, 3, 21, 9, 0, 35, 621, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 50L, new DateTime(2023, 4, 4, 10, 11, 4, 873, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 104L, new DateTime(2023, 3, 10, 8, 21, 50, 827, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 22L, new DateTime(2023, 1, 26, 3, 25, 56, 830, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 146L, new DateTime(2023, 5, 28, 1, 19, 50, 473, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 90L, new DateTime(2022, 12, 2, 23, 17, 40, 629, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 144L, new DateTime(2022, 11, 26, 0, 24, 16, 823, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 192L, new DateTime(2022, 12, 7, 22, 2, 35, 33, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 102L, new DateTime(2023, 4, 10, 10, 7, 1, 746, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 128L, new DateTime(2023, 10, 9, 9, 51, 16, 494, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 163L, new DateTime(2022, 11, 5, 6, 11, 56, 950, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 45L, new DateTime(2023, 7, 26, 11, 54, 4, 639, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 92L, new DateTime(2022, 12, 25, 16, 34, 38, 517, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 19L, new DateTime(2022, 11, 12, 12, 27, 49, 233, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 110L, new DateTime(2022, 11, 17, 14, 49, 7, 258, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 55L, new DateTime(2023, 5, 21, 6, 35, 7, 266, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 131L, new DateTime(2023, 9, 29, 7, 50, 21, 946, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 135L, new DateTime(2023, 7, 17, 1, 42, 55, 100, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 108L, new DateTime(2023, 3, 31, 21, 17, 58, 118, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 54L, new DateTime(2022, 12, 28, 21, 0, 55, 393, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 83L, new DateTime(2023, 5, 2, 9, 49, 16, 570, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 43L, new DateTime(2023, 1, 1, 9, 47, 4, 48, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 101L, new DateTime(2023, 6, 27, 1, 43, 10, 943, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 97L, new DateTime(2023, 8, 31, 6, 56, 19, 924, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 62L, new DateTime(2023, 8, 10, 23, 18, 11, 10, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 22L, new DateTime(2022, 12, 12, 12, 11, 36, 19, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 145L, new DateTime(2023, 5, 11, 15, 36, 45, 19, DateTimeKind.Local).AddTicks(5379) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 14L, new DateTime(2023, 6, 9, 22, 31, 13, 387, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 86L, new DateTime(2023, 9, 19, 19, 51, 20, 895, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 90L, new DateTime(2023, 10, 3, 8, 16, 4, 702, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 178L, new DateTime(2023, 3, 21, 8, 59, 19, 732, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 115L, new DateTime(2023, 4, 4, 10, 9, 48, 984, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 25L, new DateTime(2023, 3, 10, 8, 20, 34, 938, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 23L, new DateTime(2023, 1, 26, 3, 24, 40, 941, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 188L, new DateTime(2023, 5, 28, 1, 18, 34, 584, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 7L, new DateTime(2022, 12, 2, 23, 16, 24, 740, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 125L, new DateTime(2022, 11, 26, 0, 23, 0, 934, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 60L, new DateTime(2022, 12, 7, 22, 1, 19, 144, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 25L, new DateTime(2023, 4, 10, 10, 5, 45, 856, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 160L, new DateTime(2023, 10, 9, 9, 50, 0, 605, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 19L, new DateTime(2022, 11, 5, 6, 10, 41, 61, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 23L, new DateTime(2023, 7, 26, 11, 52, 48, 750, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 139L, new DateTime(2022, 12, 25, 16, 33, 22, 628, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 136L, new DateTime(2022, 11, 12, 12, 26, 33, 344, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 126L, new DateTime(2022, 11, 17, 14, 47, 51, 369, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 32L, new DateTime(2023, 5, 21, 6, 33, 51, 377, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 127L, new DateTime(2023, 9, 29, 7, 49, 6, 57, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 71L, new DateTime(2023, 7, 17, 1, 41, 39, 211, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 80L, new DateTime(2023, 3, 31, 21, 16, 42, 229, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 84L, new DateTime(2022, 12, 28, 20, 59, 39, 504, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 11L, new DateTime(2023, 5, 2, 9, 48, 0, 680, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 34L, new DateTime(2023, 1, 1, 9, 45, 48, 159, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 143L, new DateTime(2023, 6, 27, 1, 41, 55, 54, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 103L, new DateTime(2023, 8, 31, 6, 55, 4, 35, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 174L, new DateTime(2023, 8, 10, 23, 16, 55, 121, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 144L, new DateTime(2022, 12, 12, 12, 10, 20, 130, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "authorId", "publishDate" },
                values: new object[] { 82L, new DateTime(2023, 5, 11, 15, 35, 29, 130, DateTimeKind.Local).AddTicks(4666) });
        }
    }
}
