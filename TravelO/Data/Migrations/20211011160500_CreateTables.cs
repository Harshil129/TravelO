using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelO.Data.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    Activities = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    Restaurants = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: false),
                    PerfectTimeToVisit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceID);
                    table.ForeignKey(
                        name: "FK_Places_Provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    ListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activities = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: false),
                    Cuisines = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: false),
                    PlacesToVisit = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoLists", x => x.ListID);
                    table.ForeignKey(
                        name: "FK_ToDoLists_Places_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "Places",
                        principalColumn: "PlaceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    CostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivitiesCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FoodCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccomodationCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageTotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToDoListListID = table.Column<int>(type: "int", nullable: true),
                    PlaceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.CostID);
                    table.ForeignKey(
                        name: "FK_Costs_Places_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "Places",
                        principalColumn: "PlaceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Costs_ToDoLists_ToDoListListID",
                        column: x => x.ToDoListListID,
                        principalTable: "ToDoLists",
                        principalColumn: "ListID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costs_PlaceID",
                table: "Costs",
                column: "PlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Costs_ToDoListListID",
                table: "Costs",
                column: "ToDoListListID");

            migrationBuilder.CreateIndex(
                name: "IX_Places_ProvinceID",
                table: "Places",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoLists_PlaceID",
                table: "ToDoLists",
                column: "PlaceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.DropTable(
                name: "ToDoLists");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
