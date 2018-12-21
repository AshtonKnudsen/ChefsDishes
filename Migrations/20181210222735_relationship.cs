using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsDishes.Migrations
{
    public partial class relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Dishes_chefid",
                table: "Dishes",
                column: "chefid");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_chefid",
                table: "Dishes",
                column: "chefid",
                principalTable: "Chefs",
                principalColumn: "chefid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_chefid",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_chefid",
                table: "Dishes");
        }
    }
}
