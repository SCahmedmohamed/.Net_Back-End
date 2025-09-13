using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;

namespace ConfigurationClasses
{
    //[1]
    /// You Should The Class (That You Want To Configurate it )
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? Age { get; set; }
    }
    //[2] 
    /// Create Class Configuration And Name it [Class_Name]Configuratios
    //[3]
    /// Implement InterFace "IEntityTypeConfiguration
    class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmpId);
            builder.Property(e => e.EmpName)
                .HasColumnName("Full Name")
                .HasColumnType("nvarchar")
                .IsRequired();
        }
    }
    //[4]
    /// Now Call The Configuration Class In OnModelCreating in DbContext Class


    class MyCompanyDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());

            /// To Apply All ConFiguration Classes
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            /// using System.Reflection;
 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company03;trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            /// It's Organize The 3rd Way (Fluent APIs)
            /// You Create Congfiguration Class To Each Model ( Class )
        }
    }
}
