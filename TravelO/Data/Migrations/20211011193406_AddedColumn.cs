using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelO.Data.Migrations
{
    public partial class AddedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProvinceID",
                table: "Costs");

            migrationBuilder.AddColumn<string>(
                name: "ProvinceName",
                table: "Costs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProvinceName",
                table: "Costs");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceID",
                table: "Costs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
