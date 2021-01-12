using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace api.Migrations
{
    public partial class UserHeroesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Users_UserId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_UserId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Heroes");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Heroes",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000);

            migrationBuilder.CreateTable(
                name: "UserHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    HeroId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHeroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHeroes_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHeroes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroes_HeroId",
                table: "UserHeroes",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroes_UserId",
                table: "UserHeroes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHeroes");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Heroes",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Heroes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_UserId",
                table: "Heroes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Users_UserId",
                table: "Heroes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
