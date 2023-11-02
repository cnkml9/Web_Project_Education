using Microsoft.EntityFrameworkCore.Migrations;

namespace egitim.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BosCevap",
                table: "testDetaylar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YanlisCevap",
                table: "testDetaylar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "dogruCevap",
                table: "testDetaylar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BosCevap",
                table: "testDetaylar");

            migrationBuilder.DropColumn(
                name: "YanlisCevap",
                table: "testDetaylar");

            migrationBuilder.DropColumn(
                name: "dogruCevap",
                table: "testDetaylar");
        }
    }
}
