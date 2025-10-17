using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationAnalysing.Migrations
{
    /// <inheritdoc />
    public partial class InitialBaseline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table10",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table10", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table5",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table6",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table7",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table8",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table8", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table9",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table9", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table1");

            migrationBuilder.DropTable(
                name: "Table10");

            migrationBuilder.DropTable(
                name: "Table2");

            migrationBuilder.DropTable(
                name: "Table3");

            migrationBuilder.DropTable(
                name: "Table4");

            migrationBuilder.DropTable(
                name: "Table5");

            migrationBuilder.DropTable(
                name: "Table6");

            migrationBuilder.DropTable(
                name: "Table7");

            migrationBuilder.DropTable(
                name: "Table8");

            migrationBuilder.DropTable(
                name: "Table9");
        }
    }
}
