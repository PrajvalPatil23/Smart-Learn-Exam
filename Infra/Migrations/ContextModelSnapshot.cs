﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Admin", b =>
                {
                    b.Property<long>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AdminID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("AdminTbl");

                    b.HasData(
                        new
                        {
                            AdminID = 1L,
                            Address = "Pune",
                            ContactNo = "9421198989",
                            ContactPerson = "Abhi",
                            EmailID = "prajval@gmail.com",
                            FirstName = "Prajval",
                            LastName = "Patil",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CityID"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StateID")
                        .HasColumnType("bigint");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("CityTbl");

                    b.HasData(
                        new
                        {
                            CityID = 1L,
                            CityName = "Pune",
                            StateID = 1L
                        },
                        new
                        {
                            CityID = 2L,
                            CityName = "Kolhapur",
                            StateID = 1L
                        },
                        new
                        {
                            CityID = 3L,
                            CityName = "Mumbai",
                            StateID = 1L
                        });
                });

            modelBuilder.Entity("Core.Company", b =>
                {
                    b.Property<long>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CompanyID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.HasIndex("CityID");

                    b.ToTable("CompanyTbl");

                    b.HasData(
                        new
                        {
                            CompanyID = 1L,
                            Address = "Mumbai",
                            CityID = 3L,
                            CompanyName = "Troy",
                            ContactPersonName = "Raman",
                            EmailID = "troy@gmail.com",
                            LogoPath = "",
                            MobileNo = "9420582699",
                            RegistrationDate = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = ""
                        });
                });

            modelBuilder.Entity("Core.CompanyAdmin", b =>
                {
                    b.Property<long>("CompanyAdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CompanyAdminID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<long>("CompanyID")
                        .HasColumnType("bigint");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyAdminID");

                    b.HasIndex("CityID");

                    b.ToTable("CompanyAdminTbl");

                    b.HasData(
                        new
                        {
                            CompanyAdminID = 1L,
                            Address = "Kolhapur",
                            CityID = 2L,
                            CompanyID = 1L,
                            EmailID = "rajat@gmail.com",
                            FirstName = "Rajat",
                            LastName = "Dalal",
                            MobileNo = "8275111415",
                            Password = "4321"
                        });
                });

            modelBuilder.Entity("Core.Country", b =>
                {
                    b.Property<long>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CountryID"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("CoutryTbl");

                    b.HasData(
                        new
                        {
                            CountryID = 1L,
                            CountryName = "India"
                        });
                });

            modelBuilder.Entity("Core.Course", b =>
                {
                    b.Property<long>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseID"));

                    b.Property<long>("CourseCategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CourseLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("DurationEnum")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.HasIndex("CourseCategoryID");

                    b.ToTable("CourseTbl");
                });

            modelBuilder.Entity("Core.CourseCategory", b =>
                {
                    b.Property<long>("CourseCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseCategoryID"));

                    b.Property<string>("CourseCategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CourseCategoryID");

                    b.ToTable("CourseCategory");
                });

            modelBuilder.Entity("Core.CourseSubject", b =>
                {
                    b.Property<long>("CourseSubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseSubjectID"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("CourseID")
                        .HasColumnType("bigint");

                    b.Property<long>("SubjectID")
                        .HasColumnType("bigint");

                    b.HasKey("CourseSubjectID");

                    b.HasIndex("SubjectID");

                    b.ToTable("CourseSubjectTbl");
                });

            modelBuilder.Entity("Core.ExamSchedule", b =>
                {
                    b.Property<long>("ExamScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ExamScheduleID"));

                    b.Property<long>("ExamID")
                        .HasColumnType("bigint");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("StudentID")
                        .HasColumnType("bigint");

                    b.HasKey("ExamScheduleID");

                    b.HasIndex("ExamID");

                    b.HasIndex("StudentID");

                    b.ToTable("ExamScheduleTbl");
                });

            modelBuilder.Entity("Core.Exams", b =>
                {
                    b.Property<long>("CourseExamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseExamID"));

                    b.Property<string>("ExamTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNegativeMarking")
                        .HasColumnType("bit");

                    b.Property<int>("MarksPerQuestion")
                        .HasColumnType("int");

                    b.Property<int>("NoOfQuestions")
                        .HasColumnType("int");

                    b.Property<decimal>("PassingPercentile")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuestionTypes")
                        .HasColumnType("int");

                    b.HasKey("CourseExamID");

                    b.ToTable("ExamsTbl");
                });

            modelBuilder.Entity("Core.ExamsResult", b =>
                {
                    b.Property<long>("ExamResult")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ExamResult"));

                    b.Property<long>("CourseExamID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ExamsCourseExamID")
                        .HasColumnType("bigint");

                    b.Property<int>("FinalMarks")
                        .HasColumnType("int");

                    b.Property<int>("NegativeMarks")
                        .HasColumnType("int");

                    b.Property<int>("ObtainedMarks")
                        .HasColumnType("int");

                    b.Property<long>("StudentID")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("int");

                    b.HasKey("ExamResult");

                    b.HasIndex("ExamsCourseExamID");

                    b.HasIndex("StudentID");

                    b.ToTable("ExamsResult");
                });

            modelBuilder.Entity("Core.ExamsSubject", b =>
                {
                    b.Property<long>("ExamsSubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ExamsSubjectID"));

                    b.Property<long>("CourseExamID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ExamsCourseExamID")
                        .HasColumnType("bigint");

                    b.Property<long>("SubjectID")
                        .HasColumnType("bigint");

                    b.Property<int>("SubjectPercentage")
                        .HasColumnType("int");

                    b.HasKey("ExamsSubjectID");

                    b.HasIndex("ExamsCourseExamID");

                    b.HasIndex("SubjectID");

                    b.ToTable("ExamsSubjectTbl");
                });

            modelBuilder.Entity("Core.Question", b =>
                {
                    b.Property<long>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("QuestionID"));

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<long>("TopicID")
                        .HasColumnType("bigint");

                    b.HasKey("QuestionID");

                    b.HasIndex("TopicID");

                    b.ToTable("QuestionTbl");
                });

            modelBuilder.Entity("Core.QuestionOptions", b =>
                {
                    b.Property<long>("QuestionOptionsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("QuestionOptionsID"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("Option")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("QuestionID")
                        .HasColumnType("bigint");

                    b.HasKey("QuestionOptionsID");

                    b.HasIndex("QuestionID");

                    b.ToTable("QuestionOptionsTbl");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StateID"));

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("StateTbl");

                    b.HasData(
                        new
                        {
                            StateID = 1L,
                            CountryID = 1L,
                            StateName = "Maharashtra"
                        });
                });

            modelBuilder.Entity("Core.Student", b =>
                {
                    b.Property<long>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentID"));

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Core.StudentCourse", b =>
                {
                    b.Property<long>("StudentCourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentCourseID"));

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("CourseID")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentID")
                        .HasColumnType("bigint");

                    b.HasKey("StudentCourseID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("Core.Subject", b =>
                {
                    b.Property<long>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SubjectID"));

                    b.Property<string>("SubjectDescription")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SubjectID");

                    b.ToTable("SubjectTbl");
                });

            modelBuilder.Entity("Core.SubjectCategory", b =>
                {
                    b.Property<long>("SubjectCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SubjectCategoryID"));

                    b.Property<string>("SubjectCategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SubjectCategoryID");

                    b.ToTable("SubjectCategory");
                });

            modelBuilder.Entity("Core.Topic", b =>
                {
                    b.Property<long>("TopicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TopicID"));

                    b.Property<long>("SubjectID")
                        .HasColumnType("bigint");

                    b.Property<string>("TopicDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TopicID");

                    b.ToTable("TopicTbl");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.HasOne("Core.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Core.Company", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.CompanyAdmin", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.Course", b =>
                {
                    b.HasOne("Core.CourseCategory", "CourseCategory")
                        .WithMany()
                        .HasForeignKey("CourseCategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CourseCategory");
                });

            modelBuilder.Entity("Core.CourseSubject", b =>
                {
                    b.HasOne("Core.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Core.ExamSchedule", b =>
                {
                    b.HasOne("Core.Exams", "Exams")
                        .WithMany()
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exams");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Core.ExamsResult", b =>
                {
                    b.HasOne("Core.Exams", "Exams")
                        .WithMany()
                        .HasForeignKey("ExamsCourseExamID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exams");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Core.ExamsSubject", b =>
                {
                    b.HasOne("Core.Exams", "Exams")
                        .WithMany()
                        .HasForeignKey("ExamsCourseExamID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Core.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exams");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Core.Question", b =>
                {
                    b.HasOne("Core.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Core.QuestionOptions", b =>
                {
                    b.HasOne("Core.Question", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.HasOne("Core.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Core.StudentCourse", b =>
                {
                    b.HasOne("Core.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Core.Question", b =>
                {
                    b.Navigation("QuestionOptions");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
