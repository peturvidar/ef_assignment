using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_assignment.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subjects_SubjectsSubjectId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_SubjectsSubjectId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "SubjectsSubjectId",
                table: "Mark");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectsSubjectId",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Mark_SubjectsSubjectId",
                table: "Mark",
                column: "SubjectsSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subjects_SubjectsSubjectId",
                table: "Mark",
                column: "SubjectsSubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
