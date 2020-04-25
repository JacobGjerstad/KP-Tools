using Microsoft.EntityFrameworkCore.Migrations;

namespace KP_Tools.Migrations
{
    public partial class AddedMissingColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeaponName",
                table: "Weapons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeaponName",
                table: "Weapons");
        }
    }
}
