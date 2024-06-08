using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W8.Migrations
{
    /// <inheritdoc />
    public partial class Studies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdStudies",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    IdStudies = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.IdStudies);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdStudies",
                table: "Students",
                column: "IdStudies");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Studies_IdStudies",
                table: "Students",
                column: "IdStudies",
                principalTable: "Studies",
                principalColumn: "IdStudies",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Studies_IdStudies",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropIndex(
                name: "IX_Students_IdStudies",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdStudies",
                table: "Students");
        }
    }
}
