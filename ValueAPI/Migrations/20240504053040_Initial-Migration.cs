using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValueAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Senderid = table.Column<int>(type: "int", nullable: false),
                    Userid = table.Column<int>(type: "int", nullable: false),
                    first = table.Column<int>(type: "int", nullable: false),
                    second = table.Column<int>(type: "int", nullable: false),
                    third = table.Column<int>(type: "int", nullable: false),
                    fourth = table.Column<int>(type: "int", nullable: false),
                    fifth = table.Column<int>(type: "int", nullable: false),
                    average = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taverage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
