using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_assignment.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sub_Teach",
                table: "Sub_Teach");

            migrationBuilder.RenameTable(
                name: "Sub_Teach",
                newName: "Subject/Teacher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject/Teacher",
                table: "Subject/Teacher",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject/Teacher",
                table: "Subject/Teacher");

            migrationBuilder.RenameTable(
                name: "Subject/Teacher",
                newName: "Sub_Teach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sub_Teach",
                table: "Sub_Teach",
                column: "SubjectId");
        }
    }
}
