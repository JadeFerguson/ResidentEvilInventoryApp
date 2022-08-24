using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResidentEvilInventoryApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInventory",
                columns: table => new
                {
                    UserId = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ammo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FirstAid = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Fuel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Herbs = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Misc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Supplements = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Weapons = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserInve__1788CC4CEA803FC1", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInventory");
        }
    }
}
