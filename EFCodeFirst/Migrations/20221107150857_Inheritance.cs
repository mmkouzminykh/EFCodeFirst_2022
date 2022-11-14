using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCodeFirst.Migrations
{
    public partial class Inheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookNovel_Novel_NovelsId",
                table: "BookNovel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Novel",
                table: "Novel");

            migrationBuilder.RenameTable(
                name: "Novel",
                newName: "Novels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Novels",
                table: "Novels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Position = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Readers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookNovel_Novels_NovelsId",
                table: "BookNovel",
                column: "NovelsId",
                principalTable: "Novels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookNovel_Novels_NovelsId",
                table: "BookNovel");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropTable(
                name: "Readers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Novels",
                table: "Novels");

            migrationBuilder.RenameTable(
                name: "Novels",
                newName: "Novel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Novel",
                table: "Novel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookNovel_Novel_NovelsId",
                table: "BookNovel",
                column: "NovelsId",
                principalTable: "Novel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
