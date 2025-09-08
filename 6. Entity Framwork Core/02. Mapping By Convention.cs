using Microsoft.EntityFrameworkCore;

namespace Demo
{
    class Employee
    {
        public int Id { get; set; } // Public Numeric Property "Id" or "EmployeeId" --> Primary Key [Identity(1,1)]
        public string Name { get; set; } // Reference Type : Allow Null [Required]
        public double Salary { get; set; } // Value Type : Not Allow NULL [Required]
        public int? Age { get; set; } // Nullable<int>   : Allow Null [Optional]

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
        /// By Convention DbSet Will Create Table(Employees)
        /// from Type Employee
        /// Now You Have 1 Table in the Database(DbSet)
        
        public DbSet<Department> Departments { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // ***** By Convension (Default Behaviour) *****

            // 1. Class name => Table name

            // 2. Property name => Column name

            // 3. Primary Key Convention If Named "Id" or "{Class_Name}Id"

            // 4. Foreign Key Convention 
            /// If You Used Navigation Property
            /// And Create Property "{Class_Name}Id"  

            //5. Relationships 
            /// EF Can UnderStand The [One To Many & One To One & Many To Many]
            /// From Navigation

            // 6. Data Types
            /// int => int
            /// string => nvarchar(max)
            /// DateTime => datetime2
            /// Bool => Bit
        }
    }
}
