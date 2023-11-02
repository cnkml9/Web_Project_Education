using Microsoft.EntityFrameworkCore.Migrations;

namespace egitim.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KullaniciId",
                table: "Testler",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Testler_KullaniciId",
                table: "Testler",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testler_AspNetUsers_KullaniciId",
                table: "Testler",
                column: "KullaniciId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testler_AspNetUsers_KullaniciId",
                table: "Testler");

            migrationBuilder.DropIndex(
                name: "IX_Testler_KullaniciId",
                table: "Testler");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Testler");
        }
    }
}
