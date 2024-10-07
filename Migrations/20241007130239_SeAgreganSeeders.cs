using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaDesempenoApi.Migrations
{
    /// <inheritdoc />
    public partial class SeAgreganSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "Habitación Simple" },
                    { 2, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "Habitación Doble" },
                    { 3, "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "Suite" },
                    { 4, "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Habitación Familiar" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occupancy_people", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, (byte)1, 50.0, "101", 1 },
                    { 2, true, (byte)1, 50.0, "102", 1 },
                    { 3, true, (byte)1, 50.0, "103", 1 },
                    { 4, true, (byte)1, 50.0, "104", 1 },
                    { 5, true, (byte)1, 50.0, "105", 1 },
                    { 6, true, (byte)1, 50.0, "106", 1 },
                    { 7, true, (byte)1, 50.0, "107", 1 },
                    { 8, true, (byte)1, 50.0, "108", 1 },
                    { 9, true, (byte)1, 50.0, "109", 1 },
                    { 10, true, (byte)1, 50.0, "110", 1 },
                    { 11, true, (byte)1, 50.0, "111", 1 },
                    { 12, true, (byte)1, 50.0, "112", 1 },
                    { 13, true, (byte)2, 80.0, "201", 2 },
                    { 14, true, (byte)2, 80.0, "202", 2 },
                    { 15, true, (byte)2, 80.0, "203", 2 },
                    { 16, true, (byte)2, 80.0, "204", 2 },
                    { 17, true, (byte)2, 80.0, "205", 2 },
                    { 18, true, (byte)2, 80.0, "206", 2 },
                    { 19, true, (byte)2, 80.0, "207", 2 },
                    { 20, true, (byte)2, 80.0, "208", 2 },
                    { 21, true, (byte)2, 80.0, "209", 2 },
                    { 22, true, (byte)2, 80.0, "210", 2 },
                    { 23, true, (byte)2, 80.0, "211", 2 },
                    { 24, true, (byte)2, 80.0, "212", 2 },
                    { 25, true, (byte)2, 150.0, "301", 3 },
                    { 26, true, (byte)2, 150.0, "302", 3 },
                    { 27, true, (byte)2, 150.0, "303", 3 },
                    { 28, true, (byte)2, 150.0, "304", 3 },
                    { 29, true, (byte)2, 150.0, "305", 3 },
                    { 30, true, (byte)2, 150.0, "306", 3 },
                    { 31, true, (byte)2, 150.0, "307", 3 },
                    { 32, true, (byte)2, 150.0, "308", 3 },
                    { 33, true, (byte)2, 150.0, "309", 3 },
                    { 34, true, (byte)2, 150.0, "310", 3 },
                    { 35, true, (byte)2, 150.0, "311", 3 },
                    { 36, true, (byte)2, 150.0, "312", 3 },
                    { 37, true, (byte)2, 150.0, "313", 3 },
                    { 38, true, (byte)4, 200.0, "401", 4 },
                    { 39, true, (byte)4, 200.0, "402", 4 },
                    { 40, true, (byte)4, 200.0, "403", 4 },
                    { 41, true, (byte)4, 200.0, "404", 4 },
                    { 42, true, (byte)4, 200.0, "405", 4 },
                    { 43, true, (byte)4, 200.0, "406", 4 },
                    { 44, true, (byte)4, 200.0, "407", 4 },
                    { 45, true, (byte)4, 200.0, "408", 4 },
                    { 46, true, (byte)4, 200.0, "409", 4 },
                    { 47, true, (byte)4, 200.0, "410", 4 },
                    { 48, true, (byte)4, 200.0, "411", 4 },
                    { 49, true, (byte)4, 200.0, "412", 4 },
                    { 50, true, (byte)4, 200.0, "413", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
