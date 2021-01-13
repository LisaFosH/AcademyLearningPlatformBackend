using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyProsjekt.Migrations
{
    public partial class ModulePages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModuleID",
                table: "Page",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Page_ModuleID",
                table: "Page",
                column: "ModuleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Page_Module_ModuleID",
                table: "Page",
                column: "ModuleID",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Page_Module_ModuleID",
                table: "Page");

            migrationBuilder.DropIndex(
                name: "IX_Page_ModuleID",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "ModuleID",
                table: "Page");
        }
    }
}
