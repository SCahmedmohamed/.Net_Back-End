using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{

   class Parent
   {
       private int salary;

       public virtual int Salary
       {
           get { return salary; }
           set { salary = value-1000; }
       }

       public virtual void Print()
       {

           Console.WriteLine("Hello From Parent");
       }
   }

   // No Class Can Inherite From Sealed Class AnyMore
   sealed class Child : Parent
   {
       // No Class Can Override This Method AnyMore

       public sealed override void Print()
       {
           Console.WriteLine("Hello From Child");
       }
       // Now No Class Can Override This Property AnyMore
       public sealed override int Salary { get => base.Salary; set => base.Salary = value; }
   }




    internal class Program
    {


        static void Main(string[] args)
        {
            

        }
    }

}
