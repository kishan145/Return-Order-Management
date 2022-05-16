using Microsoft.EntityFrameworkCore.Migrations;

namespace ChargeProceesing.API.Migrations
{
    public partial class PackageandDeliverySecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PackModels",
                columns: table => new
                {
                    requestId = table.Column<long>(type: "bigint", nullable: false),
                    componentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    packageCharges = table.Column<long>(type: "bigint", nullable: false),
                    deliveryCharges = table.Column<long>(type: "bigint", nullable: false),
                    totalCharges = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackModels");
        }
    }
}
