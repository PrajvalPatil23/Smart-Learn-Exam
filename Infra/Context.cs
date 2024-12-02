using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infra
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country() { CountryID=1,CountryName="India"}
                );

            modelBuilder.Entity<State>().HasData(
                new State() { StateID=1,StateName="Maharashtra",CountryID=1}
                );

            modelBuilder.Entity<City>().HasData(
                new City() { CityID=1,CityName="Pune",StateID=1},
                new City() { CityID=2,CityName="Kolhapur",StateID=1},
                 new City() { CityID = 3, CityName = "Mumbai", StateID = 1 }
                );


            modelBuilder.Entity<Admin>().HasData(
                
                new Admin() {AdminID=1,FirstName="Prajval",LastName="Patil",EmailID="prajval@gmail.com",ContactNo="9421198989",Password="1234",Address="Pune",ContactPerson="Abhi" }
                );
            modelBuilder.Entity<CompanyAdmin>().HasData(
                new CompanyAdmin() { CompanyAdminID=1,CompanyID=1,FirstName="Rajat",LastName="Dalal",EmailID="rajat@gmail.com",MobileNo="8275111415",Address="Kolhapur",Password="4321",CityID=2}
                );
            modelBuilder.Entity<Company>().HasData(
                new Company() { CompanyID=1,CompanyName="Troy",Address="Mumbai",EmailID="troy@gmail.com",MobileNo="9420582699",LogoPath="",RegistrationDate= new DateTime(2024,10,10),CityID=3,WebsiteUrl="",ContactPersonName="Raman"}
                );

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State>States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyAdmin> CompanyAdmins { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseSubject> CourseSubjects { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<ExamSchedule> ExamSchedules { get; set; }
        public DbSet<ExamsResult> ExamResults { get; set; }
        public DbSet<ExamsSubject> ExamSubjects {  get; set; }
        public DbSet<Question>Questions { get; set; }
        public DbSet<QuestionOptions> QuestionOptions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourse { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectCategory> SubjectCategories { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
