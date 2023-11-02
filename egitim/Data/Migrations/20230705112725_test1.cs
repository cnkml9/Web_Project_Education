using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace egitim.Data.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktif",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitGuncelleme",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitOlmaTarihi",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktif",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KayitGuncelleme",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KayitOlmaTarihi",
                table: "AspNetUsers");
        }
    }
}
