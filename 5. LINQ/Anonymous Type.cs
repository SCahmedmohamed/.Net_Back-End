using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Example : 
            // When You Create Class Employee That Have Properties (ID , Name , Salary)
            // And This Class Will Use It For 1 time Or 2 Times Only 
            // Then You Haven't Need To Creat This Class
            // Best Case Here To Create Anonymous Type

            var employee = new { ID = 1, Name = "Ahmed", Salary = 30000.00 };
            Console.WriteLine(employee.ID);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Salary);

            // The Object That Will Be Created From "AnonymousType" => Is an Immutable Object [Cant Be Changed]
            // employee.ID = 20; Invaild
            // If You Want To Change Property You Have To Create New Object Or :
            /// employee = new { ID = 20, Name = "Ahmed", Salary = 30000.00 };
            employee = employee with { ID = 20 }; // Syntax Sugar   

            Console.WriteLine(employee.GetType().Name); // AnonymousType0`3 -> (0 fro ,3 for  properties)
            Console.WriteLine(employee.ToString()); // { ID = 1, Name = "Ahmed", Salary = 30000.00 }

            // The Same AnonymouseType As Long As :
            // 1. The Same Properties Naming (Case Sensetive]
            // 2. The Same Properties Order
        }
    }

}
