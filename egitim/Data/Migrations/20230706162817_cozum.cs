using Microsoft.EntityFrameworkCore.Migrations;

namespace egitim.Data.Migrations
{
    public partial class cozum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cozum",
                table: "Sorus",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cozum",
                table: "Sorus");
        }
    }
}
