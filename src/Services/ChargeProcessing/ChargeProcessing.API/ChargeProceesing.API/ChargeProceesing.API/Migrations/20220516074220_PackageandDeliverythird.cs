using Microsoft.EntityFrameworkCore.Migrations;

namespace ChargeProceesing.API.Migrations
{
    public partial class PackageandDeliverythird : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PackModels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackModels",
                table: "PackModels",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PackModels",
                table: "PackModels");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PackModels");
        }
    }
}
