using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminTbl",
                columns: table => new
                {
                    AdminID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTbl", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategory",
                columns: table => new
                {
                    CourseCategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategory", x => x.CourseCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CoutryTbl",
                columns: table => new
                {
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoutryTbl", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "ExamsSubjectTbl",
                columns: table => new
                {
                    ExamsSubjectID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<long>(type: "bigint", nullable: false),
                    CourseExamID = table.Column<long>(type: "bigint", nullable: false),
                    SubjectPercentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsSubjectTbl", x => x.ExamsSubjectID);
                });

            migrationBuilder.CreateTable(
                name: "ExamsTbl",
                columns: table => new
                {
                    CourseExamID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfQuestions = table.Column<int>(type: "int", nullable: false),
                    QuestionTypes = table.Column<int>(type: "int", nullable: false),
                    MarksPerQuestion = table.Column<int>(type: "int", nullable: false),
                    IsNegativeMarking = table.Column<bool>(type: "bit", nullable: false),
                    PassingPercentile = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsTbl", x => x.CourseExamID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "SubjectCategory",
                columns: table => new
                {
                    SubjectCategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectCategory", x => x.SubjectCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTbl",
                columns: table => new
                {
                    SubjectID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTbl", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "TopicTbl",
                columns: table => new
                {
                    TopicID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectID = table.Column<long>(type: "bigint", nullable: false),
                    TopicDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicTbl", x => x.TopicID);
                });

            migrationBuilder.CreateTable(
                name: "CourseTbl",
                columns: table => new
                {
                    CourseID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DurationEnum = table.Column<int>(type: "int", nullable: false),
                    CourseCategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTbl", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_CourseTbl_CourseCategory_CourseCategoryID",
                        column: x => x.CourseCategoryID,
                        principalTable: "CourseCategory",
                        principalColumn: "CourseCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StateTbl",
                columns: table => new
                {
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTbl", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_StateTbl_CoutryTbl_CountryID",
                        column: x => x.CountryID,
                        principalTable: "CoutryTbl",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamScheduleTbl",
                columns: table => new
                {
                    ExamScheduleID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<long>(type: "bigint", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExamID = table.Column<long>(type: "bigint", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamScheduleTbl", x => x.ExamScheduleID);
                    table.ForeignKey(
                        name: "FK_ExamScheduleTbl_ExamsTbl_ExamID",
                        column: x => x.ExamID,
                        principalTable: "ExamsTbl",
                        principalColumn: "CourseExamID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamScheduleTbl_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamsResult",
                columns: table => new
                {
                    ExamResult = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<long>(type: "bigint", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseExamID = table.Column<long>(type: "bigint", nullable: false),
                    TotalMarks = table.Column<int>(type: "int", nullable: false),
                    NegativeMarks = table.Column<int>(type: "int", nullable: false),
                    ObtainedMarks = table.Column<int>(type: "int", nullable: false),
                    FinalMarks = table.Column<int>(type: "int", nullable: false),
                    ExamsCourseExamID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsResult", x => x.ExamResult);
                    table.ForeignKey(
                        name: "FK_ExamsResult_ExamsTbl_ExamsCourseExamID",
                        column: x => x.ExamsCourseExamID,
                        principalTable: "ExamsTbl",
                        principalColumn: "CourseExamID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamsResult_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseSubjectTbl",
                columns: table => new
                {
                    CourseSubjectID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<long>(type: "bigint", nullable: false),
                    CourseID = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSubjectTbl", x => x.CourseSubjectID);
                    table.ForeignKey(
                        name: "FK_CourseSubjectTbl_SubjectTbl_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "SubjectTbl",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTbl",
                columns: table => new
                {
                    QuestionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicID = table.Column<long>(type: "bigint", nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTbl", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_QuestionTbl_TopicTbl_TopicID",
                        column: x => x.TopicID,
                        principalTable: "TopicTbl",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentCourseID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<long>(type: "bigint", nullable: false),
                    CourseID = table.Column<long>(type: "bigint", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => x.StudentCourseID);
                    table.ForeignKey(
                        name: "FK_StudentCourse_CourseTbl_CourseID",
                        column: x => x.CourseID,
                        principalTable: "CourseTbl",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateID = table.Column<long>(type: "bigint", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_CityTbl_StateTbl_StateID",
                        column: x => x.StateID,
                        principalTable: "StateTbl",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOptionsTbl",
                columns: table => new
                {
                    QuestionOptionsID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionID = table.Column<long>(type: "bigint", nullable: false),
                    Option = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOptionsTbl", x => x.QuestionOptionsID);
                    table.ForeignKey(
                        name: "FK_QuestionOptionsTbl_QuestionTbl_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "QuestionTbl",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAdminTbl",
                columns: table => new
                {
                    CompanyAdminID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAdminTbl", x => x.CompanyAdminID);
                    table.ForeignKey(
                        name: "FK_CompanyAdminTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTbl",
                columns: table => new
                {
                    CompanyID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityID = table.Column<long>(type: "bigint", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTbl", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_CompanyTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AdminTbl",
                columns: new[] { "AdminID", "Address", "ContactNo", "ContactPerson", "EmailID", "FirstName", "LastName", "Password" },
                values: new object[] { 1L, "Pune", "9421198989", "Abhi", "prajval@gmail.com", "Prajval", "Patil", "1234" });

            migrationBuilder.InsertData(
                table: "CoutryTbl",
                columns: new[] { "CountryID", "CountryName" },
                values: new object[] { 1L, "India" });

            migrationBuilder.InsertData(
                table: "StateTbl",
                columns: new[] { "StateID", "CountryID", "StateName" },
                values: new object[] { 1L, 1L, "Maharashtra" });

            migrationBuilder.InsertData(
                table: "CityTbl",
                columns: new[] { "CityID", "CityName", "StateID" },
                values: new object[,]
                {
                    { 1L, "Pune", 1L },
                    { 2L, "Kolhapur", 1L },
                    { 3L, "Mumbai", 1L }
                });

            migrationBuilder.InsertData(
                table: "CompanyAdminTbl",
                columns: new[] { "CompanyAdminID", "Address", "CityID", "CompanyID", "EmailID", "FirstName", "LastName", "MobileNo", "Password" },
                values: new object[] { 1L, "Kolhapur", 2L, 1L, "rajat@gmail.com", "Rajat", "Dalal", "8275111415", "4321" });

            migrationBuilder.InsertData(
                table: "CompanyTbl",
                columns: new[] { "CompanyID", "Address", "CityID", "CompanyName", "ContactPersonName", "EmailID", "LogoPath", "MobileNo", "RegistrationDate", "WebsiteUrl" },
                values: new object[] { 1L, "Mumbai", 3L, "Troy", "Raman", "troy@gmail.com", "", "9420582699", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAdminTbl_CityID",
                table: "CompanyAdminTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTbl_CityID",
                table: "CompanyTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubjectTbl_SubjectID",
                table: "CourseSubjectTbl",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTbl_CourseCategoryID",
                table: "CourseTbl",
                column: "CourseCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduleTbl_ExamID",
                table: "ExamScheduleTbl",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduleTbl_StudentID",
                table: "ExamScheduleTbl",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamsResult_ExamsCourseExamID",
                table: "ExamsResult",
                column: "ExamsCourseExamID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamsResult_StudentID",
                table: "ExamsResult",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptionsTbl_QuestionID",
                table: "QuestionOptionsTbl",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTbl_TopicID",
                table: "QuestionTbl",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_StateTbl_CountryID",
                table: "StateTbl",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseID",
                table: "StudentCourse",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentID",
                table: "StudentCourse",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTbl");

            migrationBuilder.DropTable(
                name: "CompanyAdminTbl");

            migrationBuilder.DropTable(
                name: "CompanyTbl");

            migrationBuilder.DropTable(
                name: "CourseSubjectTbl");

            migrationBuilder.DropTable(
                name: "ExamScheduleTbl");

            migrationBuilder.DropTable(
                name: "ExamsResult");

            migrationBuilder.DropTable(
                name: "ExamsSubjectTbl");

            migrationBuilder.DropTable(
                name: "QuestionOptionsTbl");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "SubjectCategory");

            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "SubjectTbl");

            migrationBuilder.DropTable(
                name: "ExamsTbl");

            migrationBuilder.DropTable(
                name: "QuestionTbl");

            migrationBuilder.DropTable(
                name: "CourseTbl");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "StateTbl");

            migrationBuilder.DropTable(
                name: "TopicTbl");

            migrationBuilder.DropTable(
                name: "CourseCategory");

            migrationBuilder.DropTable(
                name: "CoutryTbl");
        }
    }
}
