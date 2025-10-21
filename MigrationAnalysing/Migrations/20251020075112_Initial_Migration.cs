using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationAnalysing.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration : Migration
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Table11",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table11", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table12",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table12", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table13",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table13", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table14",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table14", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table15",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table15", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table16",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table16", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table17",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table17", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table18",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table18", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table19",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table19", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Table20",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Table20", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    column24 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column23 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column22 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column21 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column20 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column19 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column18 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column17 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column16 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    column10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Table11");

            migrationBuilder.DropTable(
                name: "Table12");

            migrationBuilder.DropTable(
                name: "Table13");

            migrationBuilder.DropTable(
                name: "Table14");

            migrationBuilder.DropTable(
                name: "Table15");

            migrationBuilder.DropTable(
                name: "Table16");

            migrationBuilder.DropTable(
                name: "Table17");

            migrationBuilder.DropTable(
                name: "Table18");

            migrationBuilder.DropTable(
                name: "Table19");

            migrationBuilder.DropTable(
                name: "Table2");

            migrationBuilder.DropTable(
                name: "Table20");

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
