using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Infra.Data.Migrations
{
    public partial class AddedStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FullName", "Mobile" },
                values: new object[] { 1, "student1@mail.com", "Student 1", "0551201651" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FullName", "Mobile" },
                values: new object[] { 2, "student2@mail.com", "Student 2", "0551201652" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FullName", "Mobile" },
                values: new object[] { 3, "student3@mail.com", "Student 3", "0551201653" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
