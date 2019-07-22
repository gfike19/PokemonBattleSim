using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonBattleSim.Migrations
{
    public partial class UpdatePkAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "Pokemons",
                newName: "type2");

            migrationBuilder.AddColumn<int>(
                name: "attack",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "defense",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "type1",
                table: "Pokemons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "attack",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "defense",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "type1",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "type2",
                table: "Pokemons",
                newName: "type");
        }
    }
}
