using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W8.Migrations
{
    /// <inheritdoc />
    public partial class AddedStudentGroupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    IdStudentGroup = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.IdStudentGroup);
                });

            migrationBuilder.CreateTable(
                name: "StudentStudentGroup",
                columns: table => new
                {
                    StudentGroupsIdStudentGroup = table.Column<int>(type: "int", nullable: false),
                    StudentsIdStudent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStudentGroup", x => new { x.StudentGroupsIdStudentGroup, x.StudentsIdStudent });
                    table.ForeignKey(
                        name: "FK_StudentStudentGroup_StudentGroups_StudentGroupsIdStudentGroup",
                        column: x => x.StudentGroupsIdStudentGroup,
                        principalTable: "StudentGroups",
                        principalColumn: "IdStudentGroup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentStudentGroup_Students_StudentsIdStudent",
                        column: x => x.StudentsIdStudent,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudentGroup_StudentsIdStudent",
                table: "StudentStudentGroup",
                column: "StudentsIdStudent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentStudentGroup");

            migrationBuilder.DropTable(
                name: "StudentGroups");
        }
    }
}
