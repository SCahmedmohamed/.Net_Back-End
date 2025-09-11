using Microsoft.EntityFrameworkCore;

namespace Fluent_APIs
{

    class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public int Emp_Age { get; set; }
    }
    class Department
    {
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        
    }

    class MyCompanyDbContext : DbContext
    {

        /// In DbContext Class , You Have To Override OnModelCreating();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// In Deafult This Function Is Empty
            /// Entity => TableName
            /// Property => Column

            modelBuilder.Entity<Employee>() // .ToTable("Employees","dbo") // .ToView("Employees","dbo")
                .HasKey(e => e.Emp_Id);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Emp_Id)
                .UseIdentityColumn(10, 10); // [10,20,30,40,50,60,....]

            modelBuilder.Entity<Employee>()
                .Property(e=>e.Emp_Name)
                .HasColumnName("Full Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired(); // The Default Value is True 


            // EF Core 3.1 New Feature
            modelBuilder.Entity<Department>(E =>
            {
                E.HasKey(e => e.Dept_Id);
                E.Property(e => e.Dept_Name)
                .IsRequired(false);
            });

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Sever = .; Database = Company03;trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /// Fluent APIs
            
            

        }
    }
}
