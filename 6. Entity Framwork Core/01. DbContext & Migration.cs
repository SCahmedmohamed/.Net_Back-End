using Microsoft.EntityFrameworkCore;

namespace Demo
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class MyCompanyDbContext : DbContext
    {
        //[1]
        /// This Class Must Be inheriting From DbContext
        /// Any New Project There are'nt DbContext
        /// Then You Have To Use The UI of Visual Studio
        /// First Right-Click on Project_Name 
        /// And Choose Manage Nuget Packages
        /// Search For : "Microsoft.EntityFramworkCore.sqlServer"

        /// Or Use The Package Manager Console To Install It 

        //[2]
        /// Use The NameSpace Of DbContect
        /// By Wirting "using Microsoft.EntityFrameworkCore;"

        //[3] 
        /// Then Go To Override OnConfiguring
        /// optionsBuilder.UseSqlServer("Server=.;Database=Company01;trusted_Connection=True;TrustServerCertificate=True;");
        /// Server = . If The DB Is Local 
        /// If No DB Named Company01 He Will Create it 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /// ***** Case Sensitive ***** 
            /// The Capital Letters Must Be Capital
            /// The Small Letters Must Be Small
            optionsBuilder.UseSqlServer("Server=.;Database=Company01;trusted_Connection=True;TrustServerCertificate=True;");

        }

        //[4]
        /// Create Property Of Type DbSet<{ClassName}> {TableName} To Convert The Class To Table
        public DbSet<Employee> Employees { get; set; }
        
        //[5] 
        /// Then Add Migration

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /// To End Connections You Have 2 Ways 
            //[1] By Using "Dispose();"
            MyCompanyDbContext Context01 = new MyCompanyDbContext(); // Start Connection
            // DataBase Opeartions
            // DataBase Opeartions
            Context01.Dispose();

            //[2] By Using "Using"
            /// Using Will Dispose Automatically When You End
            using MyCompanyDbContext Context = new MyCompanyDbContext();

            #region Before Migration

            // You Must Create Class (That Will Be The Table In DB)
            // Use The Mapping Ways For Mapping The Classes
            // And Create DbContext Class

            #endregion


            #region Migration
            /// We Use Migration For applying the change that we made in the application to the database
            ///  means that we want to make the classes (property of type DbSet) as tables in the database , this is done by the Migrations 

            /// To Add Migration

            //[1] 
            /// You Need To Install Package Tools By using The Command Like : When You Install The Microsoft.entityframworkcore.sqlserver
            /// Or Using The UI of Visual Studio
            /// First Right-Click on Project_Name 
            /// And Choose Manage Nuget Packages
            /// Search For : "Microsoft.EntityFramworkCore.Tools"

            //[2]
            /// Then Go To Package Manager Console
            /// And Write "Add-Migration {Migration_Name}"

            //[3]
            /// By Default Will Create 2 Files 
            /// Go And Check The Result 
            /// If You Need To Change AnyThing 
            /// Go To Package Manager Console And Write "Remove-Migration" 
            /// Will Delete The Last Migration

            //[4]
            /// After Migration And You Checked That Class Is Done 
            /// Go To Package Manager Console 
            /// And Write "Update-Database"
            /// Then You Will See The Database And his Tables In SSMS [SqlServerManagmentSdutio]

            #endregion

        }
    }
}
