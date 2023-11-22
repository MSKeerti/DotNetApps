using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDal
{
    //Domain Classes
    #region Inheritance

    #region One2One And One2Many

    
    public class One
    {
        [Key]
        public int Id { get; set; }
          
        public string Value { get; set; }

    }

    public class ToOne
    {
        [Key]
        public int Id { get; set; }
        public string RelatedToOne { get; set; }

    }

    public class ToMany1
    {
        [Key]
        public int Id { get; set; }
        public List<One> ToManyOnes { get; set; }
    }
    #endregion 
    public class Many
    {
        [Key]
        public int Id { get; set; }
        public List<ToMany2> ToMany2s { get; set; }
    }

    public class ToMany2
    {
        [Key]

        public int Id { get; set; }

        public List<Many> Manys { get; set; }
    }
    public class Parent
    {
        [Key] //Attribute, Data Annotation, Decorator
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ParentKey { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

    }

    public class Child: Parent
    {
        [NotMapped]
        public int ChildId { get; set; }
         
        public DateTime BirthDate { get; set; }

        [Range(18,10)]

        public int Age {  get; set; }   

    }
     
    public class Child2 : Parent
    {
          public string Hobbies { get; set; }
    }

    #endregion Inheritance
    //Mapping Layer
    public class TestDbContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
         
        public DbSet<Child> Children { get; set; }

        public DbSet<Child2> Children2 { get; set; }

        public DbSet<One> Ones { get; set; }

        public DbSet<ToOne> ToOnes { get; set; }

        public DbSet<ToMany1> ToMany1s { get; set; }

        public DbSet<Many> Manys { get; set; }

        public DbSet<ToMany2> ToMany2s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=TestDb;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Using Fluent API
            modelBuilder.Entity<Parent>().Property(p => p.ParentKey).UseIdentityColumn();
            modelBuilder.Entity<Parent>().HasOne<Child>();
            modelBuilder.Entity<One>().HasMany<Many>();
        }
    }
}
