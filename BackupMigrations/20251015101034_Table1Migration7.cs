using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationAnalysing.Migrations
{
    /// <inheritdoc />
    public partial class Table1Migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "column7",
                table: "Table1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "column7",
                table: "Table1");
        }
    }
}
