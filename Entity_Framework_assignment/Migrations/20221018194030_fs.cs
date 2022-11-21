using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_assignment.Migrations
{
    public partial class fs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Group_GroupsGroupId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "GroupsGroupId",
                table: "Student",
                newName: "GroupsId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_GroupsGroupId",
                table: "Student",
                newName: "IX_Student_GroupsId");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Group",
                newName: "GroupsId");

            migrationBuilder.AddColumn<int>(
                name: "TeachersTeacherId",
                table: "Subject/Teacher",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject/Teacher_TeachersTeacherId",
                table: "Subject/Teacher",
                column: "TeachersTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Group_GroupsId",
                table: "Student",
                column: "GroupsId",
                principalTable: "Group",
                principalColumn: "GroupsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject/Teacher_Teacher_TeachersTeacherId",
                table: "Subject/Teacher",
                column: "TeachersTeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Group_GroupsId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject/Teacher_Teacher_TeachersTeacherId",
                table: "Subject/Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Subject/Teacher_TeachersTeacherId",
                table: "Subject/Teacher");

            migrationBuilder.DropColumn(
                name: "TeachersTeacherId",
                table: "Subject/Teacher");

            migrationBuilder.RenameColumn(
                name: "GroupsId",
                table: "Student",
                newName: "GroupsGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_GroupsId",
                table: "Student",
                newName: "IX_Student_GroupsGroupId");

            migrationBuilder.RenameColumn(
                name: "GroupsId",
                table: "Group",
                newName: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Group_GroupsGroupId",
                table: "Student",
                column: "GroupsGroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
