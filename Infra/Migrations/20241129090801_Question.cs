using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Question : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "SubjectTbl",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectDescription",
                table: "SubjectTbl",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ExamsCourseExamID",
                table: "ExamsSubjectTbl",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "CourseTbl",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseDescription",
                table: "CourseTbl",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseCategoryName",
                table: "CourseCategory",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_ExamsSubjectTbl_ExamsCourseExamID",
                table: "ExamsSubjectTbl",
                column: "ExamsCourseExamID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamsSubjectTbl_SubjectID",
                table: "ExamsSubjectTbl",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamsSubjectTbl_ExamsTbl_ExamsCourseExamID",
                table: "ExamsSubjectTbl",
                column: "ExamsCourseExamID",
                principalTable: "ExamsTbl",
                principalColumn: "CourseExamID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamsSubjectTbl_SubjectTbl_SubjectID",
                table: "ExamsSubjectTbl",
                column: "SubjectID",
                principalTable: "SubjectTbl",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamsSubjectTbl_ExamsTbl_ExamsCourseExamID",
                table: "ExamsSubjectTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamsSubjectTbl_SubjectTbl_SubjectID",
                table: "ExamsSubjectTbl");

            migrationBuilder.DropIndex(
                name: "IX_ExamsSubjectTbl_ExamsCourseExamID",
                table: "ExamsSubjectTbl");

            migrationBuilder.DropIndex(
                name: "IX_ExamsSubjectTbl_SubjectID",
                table: "ExamsSubjectTbl");

            migrationBuilder.DropColumn(
                name: "ExamsCourseExamID",
                table: "ExamsSubjectTbl");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "SubjectTbl",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectDescription",
                table: "SubjectTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "CourseTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CourseDescription",
                table: "CourseTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "CourseCategoryName",
                table: "CourseCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
