using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabDal
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Value { get; set; }

    }

    public class ManyCourse
    {
        [Key]
        public int Id { get; set; }
        public List<Student> Students { get; set; }
    }

    public class OneCourse
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
    public class ToManyStudent
    {
        [Key]
        public int Id { get; set; }
        public List<OneCourse> OneCourses { get; set; }
    }

    public class OneStudent
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }

    public class ToOneCompany
    {
        [Key]
        public int Id { get; set; }
        public string RelatedToOneStudent { get; set; }

    }
    public class LabDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<ManyCourse> ManyCourses { get; set; }
        public DbSet<OneCourse> OneCourses { get; set; }
        public DbSet<ToManyStudent> ToManyStudents { get; set; }
        public DbSet<ToOneCompany> ToOneCompanies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=LabDb;Trusted_Connection=true");
        }
    }
}