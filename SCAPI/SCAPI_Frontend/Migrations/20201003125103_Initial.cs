using Microsoft.EntityFrameworkCore.Migrations;

namespace SCAPI_Frontend.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseNote = table.Column<string>(nullable: false),
                    FretPosition = table.Column<int>(nullable: false),
                    StartString = table.Column<int>(nullable: false),
                    TriadType = table.Column<string>(nullable: false),
                    ColorNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChordDiagrams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: false),
                    ChordModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChordDiagrams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChordDiagrams_Chords_ChordModelId",
                        column: x => x.ChordModelId,
                        principalTable: "Chords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChordDiagrams_ChordModelId",
                table: "ChordDiagrams",
                column: "ChordModelId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChordDiagrams");

            migrationBuilder.DropTable(
                name: "Chords");
        }
    }
}
