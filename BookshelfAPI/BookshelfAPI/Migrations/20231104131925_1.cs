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
                    { 30L, "Ksawera Janas" },
                    { 31L, "Ryszard Stefaniak" },
                    { 32L, "Patrycjusz Tomys" },
                    { 33L, "Serafin Woliński" },
                    { 34L, "Helena Łukasik" },
                    { 35L, "Alina Czyżewski" },
                    { 36L, "Eugenia Zielonka" },
                    { 37L, "Hugo Stawicki" },
                    { 38L, "Joachim Kurowski" },
                    { 39L, "Eleazar Filipek" },
                    { 40L, "Paula Chmielewski" },
                    { 41L, "Porfiriusz Mika" },
                    { 42L, "Joachim Jezierski" },
                    { 43L, "Klara Adamczak" },
                    { 44L, "Roland Niedziela" },
                    { 45L, "Penelopa Gadomski" },
                    { 46L, "Szczepan Tkaczyk" },
                    { 47L, "Igor Górecki" },
                    { 48L, "Serafin Makowski" },
                    { 49L, "Liza Gałka" },
                    { 50L, "Platon Szymczyk" },
                    { 51L, "Zachary Pilch" },
                    { 52L, "Weronika Klimczak" },
                    { 53L, "Franciszka Czechowski" },
                    { 54L, "Lidia Fijałkowski" },
                    { 55L, "Samson Buczek" },
                    { 56L, "Lucja Grzybowski" },
                    { 57L, "Erast Wilk" },
                    { 58L, "Marianna Witczak" },
                    { 59L, "Tymoteusz Chrzanowski" },
                    { 60L, "Gerald Lewicki" },
                    { 61L, "Rajnold Dobrowolski" },
                    { 62L, "Bernard Kowalik" },
                    { 63L, "Kamila Słowiński" },
                    { 64L, "Gloria Żmuda" },
                    { 65L, "Laurencjusz Sobolewski" },
                    { 66L, "Cecylia Zdunek" },
                    { 67L, "Janina Bieniek" },
                    { 68L, "Walenty Sobczyk" },
                    { 69L, "Agnieszka Woś" },
                    { 70L, "Aleksandra Marczak" },
                    { 71L, "Eleazar Jankowski" },
                    { 72L, "Korneli Szcześniak" },
                    { 73L, "Natanael Jagodziński" },
                    { 74L, "Edyta Kałuża" },
                    { 75L, "Osmund Młynarczyk" },
                    { 76L, "Wanda Rogowski" },
                    { 77L, "Zoe Wąsowski" },
                    { 78L, "Orestes Książek" },
                    { 79L, "Aleksandra Mroczkowski" },
                    { 80L, "Helena Trojanowski" },
                    { 81L, "Paweł Szymczak" },
                    { 82L, "Michalina Rogowski" },
                    { 83L, "Prokul Urban" },
                    { 84L, "Samson Ciszewski" },
                    { 85L, "Nazariusz Buczyński" },
                    { 86L, "Łazarz Niemczyk" },
                    { 87L, "Teodor Przybysz" },
                    { 88L, "Leonard Dziedzic" },
                    { 89L, "Aleksander Górski" },
                    { 90L, "Alwar Klimczak" },
                    { 91L, "Emanuel Komorowski" },
                    { 92L, "Alina Rudziński" },
                    { 93L, "Justyna Wójcik" },
                    { 94L, "Teodora Szczepaniak" },
                    { 95L, "Daria Cebula" },
                    { 96L, "Ernest Adamczyk" },
                    { 97L, "Franciszek Rybarczyk" },
                    { 98L, "Konrad Kalinowski" },
                    { 99L, "Filemon Krakowiak" },
                    { 100L, "Onufry Maciejewski" },
                    { 101L, "Laurentyna Mierzejewski" },
                    { 102L, "Wirginia Kacprzak" },
                    { 103L, "Gerald Kot" },
                    { 104L, "Franciszek Jędrzejczyk" },
                    { 105L, "Barbara Gruszczyński" },
                    { 106L, "Patrycjusz Karaś" },
                    { 107L, "Walgierz Komorowski" },
                    { 108L, "Emilia Bednarz" },
                    { 109L, "Hilarion Dominiak" },
                    { 110L, "Ruta Madej" },
                    { 111L, "Paulina Pietrzak" },
                    { 112L, "Rajnold Jagiełło" },
                    { 113L, "Filipa Jędrzejczak" },
                    { 114L, "Patrycjusz Staniszewski" },
                    { 115L, "Adelajda Żak" },
                    { 116L, "Izolda Nowakowski" },
                    { 117L, "Maja Matusiak" },
                    { 118L, "Ksawery Olejnik" },
                    { 119L, "Oliwier Jakubowski" },
                    { 120L, "Rafał Kowalczuk" },
                    { 121L, "Irena Pawłowski" },
                    { 122L, "Gabriel Kucharski" },
                    { 123L, "Elwira Szymański" },
                    { 124L, "Reginald Szcześniak" },
                    { 125L, "Antoni Bogucki" },
                    { 126L, "Bertram Jabłoński" },
                    { 127L, "Salwator Wawrzyniak" },
                    { 128L, "Aleksandra Czerwiński" },
                    { 129L, "Klaudiusz Romanowski" },
                    { 130L, "Patrycy Zielonka" },
                    { 131L, "Wiktoria Kozłowski" },
                    { 132L, "Ilona Pakuła" },
                    { 133L, "Rudolf Stec" },
                    { 134L, "Reginald Bagiński" },
                    { 135L, "Lilianna Borowski" },
                    { 136L, "Klementyna Zwoliński" },
                    { 137L, "Ewelina Mazurkiewicz" },
                    { 138L, "Joanna Hajduk" },
                    { 139L, "Roger Adamus" },
                    { 140L, "Agrypina Bogucki" },
                    { 141L, "Maja Mróz" },
                    { 142L, "Joanna Malec" },
                    { 143L, "Paulina Lesiak" },
                    { 144L, "Damian Łukasik" },
                    { 145L, "Sylwia Krzyżanowski" },
                    { 146L, "Terencjusz Pluta" },
                    { 147L, "Melania Lenart" },
                    { 148L, "Patrycy Karczewski" },
                    { 149L, "Rachela Milczarek" },
                    { 150L, "Walentyna Wieczorek" },
                    { 151L, "Natanael Książek" },
                    { 152L, "Alan Zielonka" },
                    { 153L, "Patrycjusz Cichoń" },
                    { 154L, "Ksawery Włodarczyk" },
                    { 155L, "Cyrus Kalisz" },
                    { 156L, "Dorota Bąkowski" },
                    { 157L, "Cyrus Kasprzyk" },
                    { 158L, "Klarencjusz Kowalski" },
                    { 159L, "Krystyna Gruszka" },
                    { 160L, "Gracja Żuk" },
                    { 161L, "Dina Lisiecki" },
                    { 162L, "Bertrand Kos" },
                    { 163L, "Wilfryd Śliwiński" },
                    { 164L, "Klaudiusz Gruszka" },
                    { 165L, "Damian Kruszewski" },
                    { 166L, "Maksym Witek" },
                    { 167L, "Apollo Raczyński" },
                    { 168L, "Eugenia Kubacki" },
                    { 169L, "Jerzy Stanek" },
                    { 170L, "Klaudiusz Stefaniak" },
                    { 171L, "Renata Flis" },
                    { 172L, "Marta Nowiński" },
                    { 173L, "Joanna Kruszewski" },
                    { 174L, "Błażej Marcinkowski" },
                    { 175L, "Mikołaj Andrzejewski" },
                    { 176L, "Elwira Przybysz" },
                    { 177L, "Małgorzata Łapiński" },
                    { 178L, "Grzegorz Urbaniak" },
                    { 179L, "Maksymilian Partyka" },
                    { 180L, "Patryk Krzyżanowski" },
                    { 181L, "Abraham Karczewski" },
                    { 182L, "Lilla Robak" },
                    { 183L, "Wiktoria Sowa" },
                    { 184L, "Arkadiusz Królikowski" },
                    { 185L, "Karolina Piątek" },
                    { 186L, "Lucja Trojanowski" },
                    { 187L, "Korneli Wrona" },
                    { 188L, "Bernard Lewandowski" },
                    { 189L, "Katarzyna Kwiecień" },
                    { 190L, "Berta Czyż" },
                    { 191L, "Prokles Mucha" },
                    { 192L, "Maryna Cieśla" },
                    { 193L, "Ida Pilarski" },
                    { 194L, "Arnold Borkowski" },
                    { 195L, "Samuel Szczęsna" },
                    { 196L, "Bertram Wypych" },
                    { 197L, "Olaf Polak" },
                    { 198L, "Laurentyna Mroczkowski" },
                    { 199L, "Nestor Dominiak" },
                    { 200L, "Karolina Łukasiewicz" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "authorId", "name", "publishDate" },
                values: new object[,]
                {
                    { 1L, 14L, "Intelligent Granite Fish", new DateTime(2023, 6, 9, 22, 31, 13, 387, DateTimeKind.Local).AddTicks(3717) },
                    { 2L, 86L, "Incredible Rubber Towels", new DateTime(2023, 9, 19, 19, 51, 20, 895, DateTimeKind.Local).AddTicks(9780) },
                    { 3L, 90L, "Generic Rubber Pants", new DateTime(2023, 10, 3, 8, 16, 4, 702, DateTimeKind.Local).AddTicks(772) },
                    { 4L, 178L, "Practical Soft Car", new DateTime(2023, 3, 21, 8, 59, 19, 732, DateTimeKind.Local).AddTicks(3425) },
                    { 5L, 115L, "Intelligent Soft Fish", new DateTime(2023, 4, 4, 10, 9, 48, 984, DateTimeKind.Local).AddTicks(800) },
                    { 6L, 25L, "Handcrafted Concrete Computer", new DateTime(2023, 3, 10, 8, 20, 34, 938, DateTimeKind.Local).AddTicks(7597) },
                    { 7L, 23L, "Fantastic Steel Keyboard", new DateTime(2023, 1, 26, 3, 24, 40, 941, DateTimeKind.Local).AddTicks(1475) },
                    { 8L, 188L, "Handmade Soft Car", new DateTime(2023, 5, 28, 1, 18, 34, 584, DateTimeKind.Local).AddTicks(1231) },
                    { 9L, 7L, "Incredible Cotton Mouse", new DateTime(2022, 12, 2, 23, 16, 24, 740, DateTimeKind.Local).AddTicks(335) },
                    { 10L, 125L, "Unbranded Concrete Hat", new DateTime(2022, 11, 26, 0, 23, 0, 934, DateTimeKind.Local).AddTicks(3749) },
                    { 11L, 60L, "Incredible Concrete Car", new DateTime(2022, 12, 7, 22, 1, 19, 144, DateTimeKind.Local).AddTicks(4782) },
                    { 12L, 25L, "Handmade Plastic Tuna", new DateTime(2023, 4, 10, 10, 5, 45, 856, DateTimeKind.Local).AddTicks(9948) },
                    { 13L, 160L, "Sleek Cotton Computer", new DateTime(2023, 10, 9, 9, 50, 0, 605, DateTimeKind.Local).AddTicks(6761) },
                    { 14L, 19L, "Tasty Soft Hat", new DateTime(2022, 11, 5, 6, 10, 41, 61, DateTimeKind.Local).AddTicks(9224) },
                    { 15L, 23L, "Practical Steel Chips", new DateTime(2023, 7, 26, 11, 52, 48, 750, DateTimeKind.Local).AddTicks(1884) },
                    { 16L, 139L, "Practical Soft Shirt", new DateTime(2022, 12, 25, 16, 33, 22, 628, DateTimeKind.Local).AddTicks(5544) },
                    { 17L, 136L, "Sleek Frozen Fish", new DateTime(2022, 11, 12, 12, 26, 33, 344, DateTimeKind.Local).AddTicks(8043) },
                    { 18L, 126L, "Generic Wooden Chicken", new DateTime(2022, 11, 17, 14, 47, 51, 369, DateTimeKind.Local).AddTicks(8368) },
                    { 19L, 32L, "Gorgeous Soft Ball", new DateTime(2023, 5, 21, 6, 33, 51, 377, DateTimeKind.Local).AddTicks(7071) },
                    { 20L, 127L, "Rustic Wooden Salad", new DateTime(2023, 9, 29, 7, 49, 6, 57, DateTimeKind.Local).AddTicks(6290) },
                    { 21L, 71L, "Practical Rubber Ball", new DateTime(2023, 7, 17, 1, 41, 39, 211, DateTimeKind.Local).AddTicks(5230) },
                    { 22L, 80L, "Handcrafted Steel Shoes", new DateTime(2023, 3, 31, 21, 16, 42, 229, DateTimeKind.Local).AddTicks(7090) },
                    { 23L, 84L, "Unbranded Concrete Hat", new DateTime(2022, 12, 28, 20, 59, 39, 504, DateTimeKind.Local).AddTicks(2615) },
                    { 24L, 11L, "Gorgeous Concrete Shoes", new DateTime(2023, 5, 2, 9, 48, 0, 680, DateTimeKind.Local).AddTicks(9850) },
                    { 25L, 34L, "Licensed Concrete Table", new DateTime(2023, 1, 1, 9, 45, 48, 159, DateTimeKind.Local).AddTicks(3564) },
                    { 26L, 143L, "Awesome Metal Chips", new DateTime(2023, 6, 27, 1, 41, 55, 54, DateTimeKind.Local).AddTicks(1384) },
                    { 27L, 103L, "Handmade Wooden Bacon", new DateTime(2023, 8, 31, 6, 55, 4, 35, DateTimeKind.Local).AddTicks(1175) },
                    { 28L, 174L, "Sleek Steel Bacon", new DateTime(2023, 8, 10, 23, 16, 55, 121, DateTimeKind.Local).AddTicks(8462) },
                    { 29L, 144L, "Rustic Fresh Pizza", new DateTime(2022, 12, 12, 12, 10, 20, 130, DateTimeKind.Local).AddTicks(8385) },
                    { 30L, 82L, "Sleek Wooden Mouse", new DateTime(2023, 5, 11, 15, 35, 29, 130, DateTimeKind.Local).AddTicks(4666) }
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
