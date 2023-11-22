using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabDal.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManyCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManyCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToManyStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToManyStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToOneCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedToOneStudent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToOneCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManyCourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_ManyCourses_ManyCourseId",
                        column: x => x.ManyCourseId,
                        principalTable: "ManyCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OneCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToManyStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OneCourses_ToManyStudents_ToManyStudentId",
                        column: x => x.ToManyStudentId,
                        principalTable: "ToManyStudents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OneCourses_ToManyStudentId",
                table: "OneCourses",
                column: "ToManyStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ManyCourseId",
                table: "Students",
                column: "ManyCourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OneCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ToOneCompanies");

            migrationBuilder.DropTable(
                name: "ToManyStudents");

            migrationBuilder.DropTable(
                name: "ManyCourses");
        }
    }
}
