using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
        // You Cant Create 2 Class With the Same Name
    // But You Can Sparete The Class
    // To Make More Than 1 People To Work In The Same Class
    


    partial class Employee
    {
        // Ahmed Is Working In This Class 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }

    partial class Employee
    {
        // Mohamed Is Working In this Class
        public decimal Salary { get; set; }
        public int? Age { get; set; }

    }

    



    internal class Program
    {


        static void Main(string[] args)
        {
           Employee employee = new Employee()
          {
              Id = 1,
              Name = "Test",
              Age = 24,
              Salary = 25000,
              Description = "Test"
          };
 

        }
    }

}
