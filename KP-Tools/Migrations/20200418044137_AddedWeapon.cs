using Microsoft.EntityFrameworkCore.Migrations;

namespace KP_Tools.Migrations
{
    public partial class AddedWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    WeaponId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponType = table.Column<string>(nullable: true),
                    WeaponProperty = table.Column<string>(nullable: true),
                    WeaponHp = table.Column<int>(nullable: false),
                    WeaponHpRecovery = table.Column<int>(nullable: false),
                    WeaponStamina = table.Column<int>(nullable: false),
                    WeaponStaminaRecovery = table.Column<int>(nullable: false),
                    WeaponMana = table.Column<int>(nullable: false),
                    WeaponManaRecovery = table.Column<int>(nullable: false),
                    WeaponRageGeneration = table.Column<int>(nullable: false),
                    WeaponPhysicalAttack = table.Column<int>(nullable: false),
                    WeaponMagicAttack = table.Column<int>(nullable: false),
                    WeaponPhysicalCritRate = table.Column<int>(nullable: false),
                    WeaponMagicalCritRate = table.Column<int>(nullable: false),
                    WeaponActionSpeed = table.Column<int>(nullable: false),
                    WeaponCastingSpeed = table.Column<int>(nullable: false),
                    WeaponMovementSpeed = table.Column<int>(nullable: false),
                    WeaponActionEndurance = table.Column<int>(nullable: false),
                    WeaponSpellEndurance = table.Column<int>(nullable: false),
                    WeaponPhysicalDefense = table.Column<int>(nullable: false),
                    WeaponMagicDefense = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.WeaponId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
