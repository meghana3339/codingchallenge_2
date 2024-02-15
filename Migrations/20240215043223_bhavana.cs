using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codingchallenge.Migrations
{
    public partial class bhavana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Airline = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DepartureAirport = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ArrivalAirport = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DepartureDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
