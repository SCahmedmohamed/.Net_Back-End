using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{

 class Employee
 {
     public int ID { get; set; }
     public string Name { get; set; }

     public Employee(int ID , string Name)
     {
         this.ID = ID;                                                                             
         this.Name = Name;
     }

     public override bool Equals(object? obj)
     {
         Employee? other = (Employee?)obj; // Explicit Casting
                                           // Unsafe Casting [May Throw Execption -> InvaildCastException]
         return this.ID == other.ID && this.Name == other.Name;

     }

 }

 



    internal class Program
    {


        static void Main(string[] args)
        {
Employee employee01 = new Employee(1,"ahmed"); // His HashCode : 58225482
Employee employee02 = new Employee(1,"ahmed"); // His HashCOde : 54267293
Console.WriteLine(employee01.GetHashCode());
Console.WriteLine(employee02.GetHashCode());

if(employee01 == employee02)
/// Or if(employee01.Equals(employee02))
/// Both Of Them Compare By Reference In The Default
{
    Console.WriteLine("Equal");
} else Console.WriteLine("Not Equal");
/// The Answer is : Not Equal 
/// why : Becuase The Defualt Comparing in Class : Compare By Reference  
/// EveryOne Has His Own HashCode


/// Now You Can Let "==" Reference Base Equality (Compare By Reference)
/// And Override "Equals()" To Be Value Base Equality (Compare By Value)

if(employee01.Equals(employee02))
{
    Console.WriteLine("Equal");
} else Console.WriteLine("Not Equal");                            
            
        }
    }

}
