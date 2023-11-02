using Microsoft.EntityFrameworkCore.Migrations;

namespace egitim.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "egitims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiyat = table.Column<float>(type: "real", nullable: false),
                    resimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soruSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_egitims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dogruCevap = table.Column<int>(type: "int", nullable: false),
                    YanlisCevap = table.Column<int>(type: "int", nullable: false),
                    BosCevap = table.Column<int>(type: "int", nullable: false),
                    bitirdi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dersler_egitims_EgitimId",
                        column: x => x.EgitimId,
                        principalTable: "egitims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Konular_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sorus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoruMetni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirinciSecenek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IkıncıSecenek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UcuncuSecenek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DorduncuSecenek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BesinciSecenek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogruCevap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KonuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sorus_Konular_KonuId",
                        column: x => x.KonuId,
                        principalTable: "Konular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "testDetaylar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    KonuId = table.Column<int>(type: "int", nullable: false),
                    SoruSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testDetaylar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_testDetaylar_Konular_KonuId",
                        column: x => x.KonuId,
                        principalTable: "Konular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_testDetaylar_Testler_TestId",
                        column: x => x.TestId,
                        principalTable: "Testler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_EgitimId",
                table: "Dersler",
                column: "EgitimId");

            migrationBuilder.CreateIndex(
                name: "IX_Konular_DersId",
                table: "Konular",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sorus_KonuId",
                table: "Sorus",
                column: "KonuId");

            migrationBuilder.CreateIndex(
                name: "IX_testDetaylar_KonuId",
                table: "testDetaylar",
                column: "KonuId");

            migrationBuilder.CreateIndex(
                name: "IX_testDetaylar_TestId",
                table: "testDetaylar",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sorus");

            migrationBuilder.DropTable(
                name: "testDetaylar");

            migrationBuilder.DropTable(
                name: "Konular");

            migrationBuilder.DropTable(
                name: "Testler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "egitims");
        }
    }
}
