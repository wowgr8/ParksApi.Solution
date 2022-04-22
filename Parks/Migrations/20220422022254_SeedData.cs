using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StateAndNatParks",
                columns: new[] { "StateAndNatParkId", "LocationByState", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "California", "Yosimite", "National Park" },
                    { 2, "Wyoming", "Yellowstone", "National Park" },
                    { 3, "Utah", "Arches", "National Park" },
                    { 4, "Texas", "Palo Duro Canyon", "State Park" },
                    { 5, "North Carolina", "Chimney Rock", "State Park" },
                    { 6, "Michigan", "Porcupine Mountains Wilderness", "State Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 6);
        }
    }
}
