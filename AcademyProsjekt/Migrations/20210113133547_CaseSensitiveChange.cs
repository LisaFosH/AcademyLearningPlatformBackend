using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyProsjekt.Migrations
{
    public partial class CaseSensitiveChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Module_Course_CourseID",
                table: "Module");

            migrationBuilder.DropForeignKey(
                name: "FK_Page_Module_ModuleID",
                table: "Page");

            migrationBuilder.RenameColumn(
                name: "ModuleID",
                table: "Page",
                newName: "ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Page_ModuleID",
                table: "Page",
                newName: "IX_Page_ModuleId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Module",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Module_CourseID",
                table: "Module",
                newName: "IX_Module_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Module_Course_CourseId",
                table: "Module",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Page_Module_ModuleId",
                table: "Page",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Module_Course_CourseId",
                table: "Module");

            migrationBuilder.DropForeignKey(
                name: "FK_Page_Module_ModuleId",
                table: "Page");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "Page",
                newName: "ModuleID");

            migrationBuilder.RenameIndex(
                name: "IX_Page_ModuleId",
                table: "Page",
                newName: "IX_Page_ModuleID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Module",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Module_CourseId",
                table: "Module",
                newName: "IX_Module_CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Module_Course_CourseID",
                table: "Module",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Page_Module_ModuleID",
                table: "Page",
                column: "ModuleID",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
