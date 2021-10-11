using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelO.Data.Migrations
{
    public partial class FinalCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProvinceName",
                table: "Costs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProvinceName",
                table: "Costs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
