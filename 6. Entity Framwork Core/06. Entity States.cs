using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace States
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
    }



    class MyCompanyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company055;trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            #region States

            //[1] Detached
            /// The Entity Is Not Being Tracked By The DbContext
            /// Created But You Didnt Add It To DbContext Yet 

            //[2] Added
            /// The Entity Is New And Will Be INSERTED Into The Database On SaveChanges().
            /// You Create Entity And Added It To DbContext But Didnt Use SaveChanges() Yet

            //[3] Modified
            /// The entity has been changed and will be UPDATED in the database On SaveChanges()
            /// You Change SomeThing In The Entity But Didnt Save It In DateBase

            //[4] Deleted
            /// You Delete The Entity From DbContext But Didnt SaveChanges()

            //[5] UnChanged
            /// The entity exists in the DbContext and matches the database (no modifications).
            /// The Same Entity In DbContext = The Same Entity In DataBase

            #endregion



            using MyCompanyDbContext Context = new MyCompanyDbContext();

            Employee employee = new Employee() {Name ="Ahmed" ,Age = 20};

            Console.WriteLine(Context.Entry(employee)); // Detached

            Context.Add(employee);

            Console.WriteLine(Context.Entry(employee)); // Added

            Context.SaveChanges();

            Console.WriteLine(Context.Entry(employee)); // UnChanged

            employee.Age = 22;

            Console.WriteLine(Context.Entry(employee)); // Modified

            Context.Employees.Remove(employee);
            //Context.Remove(employee);

            Console.WriteLine(Context.Entry(employee)); // Deleted



        }
    }
}
