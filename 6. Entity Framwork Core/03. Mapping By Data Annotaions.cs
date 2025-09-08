using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Demo
{
    class Employee
    {
        [Key]
        public int SSN { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(30000, 50000)]
        public double Salary { get; set; }

        public int? Age { get; set; } 

    }
    internal class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }

    class CampanyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = Company; Trusted_Connection = true ;TrustServerCertificate=True;");

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            /// First Use The NameSpace "using System.ComponentModel.DataAnnotations;"

            // Data Annotations :
            // 1.  [Key] : Primary Key
            // 2.  [Required] : Dont Allow Null
            // 3.  [DatabaseGenerated(DatabaseGeneratedOption.Identity)] : Identity
            // 4.  [Column(Typename = "")] : To Set The DataType
            // 5.  [StringLength({mx},MinimumLength = {mn})] : To Make "mx" The MaxLength & "mn" The MinLenght
            // 6.  [Range({mn},{max})] : The Value Must Be Between mn and mx                -Application Balidation- 
            // 7.  [AllowedValues({v1},{v2},{v3}.....)] : Allow Value Between Them Only     -Application Balidation-
            // 8.  [DeniedValues({v1},{v2},{v3}.....)] : Doesn't Allow Any Value Of Them    -Application Balidation-
            // 9.  [EmailAddress] : Allow Emails Only [Like : qwert@gmail.com]
            // 10. [Table("{Table_Name}",Schema = "{Schema_Name}")] : Create Table in Schema
            // 11. [ForeignKey("{Property02}")] : To Link The Property01 to Property02

        }
    }
}
