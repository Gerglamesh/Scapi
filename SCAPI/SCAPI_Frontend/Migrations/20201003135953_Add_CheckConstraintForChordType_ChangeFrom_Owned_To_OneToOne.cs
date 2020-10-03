using Microsoft.EntityFrameworkCore.Migrations;

namespace SCAPI_Frontend.Migrations
{
    public partial class Add_CheckConstraintForChordType_ChangeFrom_Owned_To_OneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChordDiagrams_Chords_ChordModelId",
                table: "ChordDiagrams");

            migrationBuilder.DropIndex(
                name: "IX_ChordDiagrams_ChordModelId",
                table: "ChordDiagrams");

            migrationBuilder.DropColumn(
                name: "ChordModelId",
                table: "ChordDiagrams");            

            migrationBuilder.AddColumn<string>(
                name: "ChordType",
                table: "Chords",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateCheckConstraint(
                name: "CK_ChordModel_ChordType",
                table: "Chords",
                sql: "[ChordType] IN ('Open', 'Barré')");

            migrationBuilder.AddColumn<int>(
                name: "ChordId",
                table: "ChordDiagrams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Chords",
                columns: new[] { "Id", "BaseNote", "ChordType", "ColorNote", "FretPosition", "StartString", "TriadType" },
                values: new object[,]
                {
                    { 1, "C", "Open", null, 3, 5, "Major" },
                    { 2, "C", "Barré", null, 3, 5, "Major" },
                    { 3, "C", "Barré", null, 8, 6, "Major" },
                    { 4, "C", "Barré", null, 10, 4, "Major" }
                });

            migrationBuilder.InsertData(
                table: "ChordDiagrams",
                columns: new[] { "Id", "ChordId", "Path" },
                values: new object[,]
                {
                    { 1, 1, "Does not exist yet" },
                    { 2, 2, "Does not exist yet" },
                    { 3, 3, "Does not exist yet" },
                    { 4, 4, "Does not exist yet" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChordDiagrams_ChordId",
                table: "ChordDiagrams",
                column: "ChordId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChordDiagrams_Chords_ChordId",
                table: "ChordDiagrams",
                column: "ChordId",
                principalTable: "Chords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChordDiagrams_Chords_ChordId",
                table: "ChordDiagrams");

            migrationBuilder.DropCheckConstraint(
                name: "CK_ChordModel_ChordType",
                table: "Chords");

            migrationBuilder.DropIndex(
                name: "IX_ChordDiagrams_ChordId",
                table: "ChordDiagrams");

            migrationBuilder.DeleteData(
                table: "ChordDiagrams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChordDiagrams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChordDiagrams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChordDiagrams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ChordType",
                table: "Chords");

            migrationBuilder.DropColumn(
                name: "ChordId",
                table: "ChordDiagrams");

            migrationBuilder.AddColumn<int>(
                name: "ChordModelId",
                table: "ChordDiagrams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChordDiagrams_ChordModelId",
                table: "ChordDiagrams",
                column: "ChordModelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChordDiagrams_Chords_ChordModelId",
                table: "ChordDiagrams",
                column: "ChordModelId",
                principalTable: "Chords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
