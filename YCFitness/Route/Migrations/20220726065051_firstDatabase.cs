using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Route.Migrations
{
    public partial class firstDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "runApp",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    GPSxStart = table.Column<double>(type: "float", nullable: false),
                    GPSxEnd = table.Column<double>(type: "float", nullable: false),
                    GPSyStart = table.Column<double>(type: "float", nullable: false),
                    GPSyEnd = table.Column<double>(type: "float", nullable: false),
                    FK_AutorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_runApp", x => x.RouteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "runApp");
        }
    }
}
