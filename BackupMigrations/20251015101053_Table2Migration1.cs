using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationAnalysing.Migrations
{
    /// <inheritdoc />
    public partial class Table2Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "column1",
                table: "Table2",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "column1",
                table: "Table2");
        }
    }
}
