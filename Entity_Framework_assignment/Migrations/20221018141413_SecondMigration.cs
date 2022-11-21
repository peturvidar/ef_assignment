using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_assignment.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupsGroupId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentsStudentId",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectsSubjectId",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sub_Teach",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Teach", x => x.SubjectId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupsGroupId",
                table: "Student",
                column: "GroupsGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StudentsStudentId",
                table: "Mark",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_SubjectsSubjectId",
                table: "Mark",
                column: "SubjectsSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Student_StudentsStudentId",
                table: "Mark",
                column: "StudentsStudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subject_SubjectsSubjectId",
                table: "Mark",
                column: "SubjectsSubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Group_GroupsGroupId",
                table: "Student",
                column: "GroupsGroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Student_StudentsStudentId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subject_SubjectsSubjectId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Group_GroupsGroupId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Sub_Teach");

            migrationBuilder.DropIndex(
                name: "IX_Student_GroupsGroupId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Mark_StudentsStudentId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_SubjectsSubjectId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "GroupsGroupId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentsStudentId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "SubjectsSubjectId",
                table: "Mark");
        }
    }
}
