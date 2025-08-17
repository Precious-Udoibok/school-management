using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    College_IDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_Colleges_College_IDID",
                        column: x => x.College_IDID,
                        principalTable: "Colleges",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courses_taken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department_IdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lecturers_Departments_Department_IdID",
                        column: x => x.Department_IdID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department_IDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Departments_Department_IDID",
                        column: x => x.Department_IDID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lecturer_IDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Courses_Lecturers_Lecturer_IDID",
                        column: x => x.Lecturer_IDID,
                        principalTable: "Lecturers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseRegistrations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Units = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LecturerIDID = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentIDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRegistrations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CourseRegistrations_Lecturers_LecturerIDID",
                        column: x => x.LecturerIDID,
                        principalTable: "Lecturers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRegistrations_Students_StudentIDID",
                        column: x => x.StudentIDID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hostels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HostelClearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentIDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hostels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hostels_Students_StudentIDID",
                        column: x => x.StudentIDID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolPortals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatricNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentIDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolPortals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SchoolPortals_Students_StudentIDID",
                        column: x => x.StudentIDID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistrations_LecturerIDID",
                table: "CourseRegistrations",
                column: "LecturerIDID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistrations_StudentIDID",
                table: "CourseRegistrations",
                column: "StudentIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Lecturer_IDID",
                table: "Courses",
                column: "Lecturer_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_College_IDID",
                table: "Departments",
                column: "College_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Hostels_StudentIDID",
                table: "Hostels",
                column: "StudentIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_Department_IdID",
                table: "Lecturers",
                column: "Department_IdID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPortals_StudentIDID",
                table: "SchoolPortals",
                column: "StudentIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Department_IDID",
                table: "Students",
                column: "Department_IDID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRegistrations");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Hostels");

            migrationBuilder.DropTable(
                name: "SchoolPortals");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Colleges");
        }
    }
}
