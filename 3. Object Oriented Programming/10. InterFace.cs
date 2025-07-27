using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{ 

 interface IMyType
 {
     /// Default Access Modifier Inside The Interface Is Public
      
     /// What You Can Write Inside Interface :
     /// 1. Signature Of Methods :
    public int Salary { get; set; }



     /// 2. Signature Of Property
     public void MyFun();
 
     /// 3. Default Implmented Method
     public void Print()
     {
         Console.WriteLine("Hello From Default Implmented Method !");
     }
     
 
 
 }


 class MyType : IMyType // Here Class Implment Interface
 {
     private int salary;
     // Now You Must Implment All Propertys And Methods Of InterFace
     public int Salary 
     { get { return salary; }
       set { salary = value; }
     }

     public void MyFun()
     {
         Console.WriteLine("Hello From Class");
     }

     /* OR
      public void Myfun() => Console.WriteLine("Hello From Class");
      
      */
 }


 





    internal class Program
    {


        static void Main(string[] args)
        {

    /// InterFace IS A Code Contract That Defines Methods, Properties, Events, Or IIndexers Without Implementation.
    /// A Class Or Struct That Implments Interface Must Implment All Its Members
    /// A Class Can Implment Muliple Interfaces



    // IMyType type; // You Can Create Reference From InterFace
    // type = new IMyType(); /// Invaild : You Cant Create Object From InterFace


    MyType type = new MyType();
    type.Salary = 40000;
    type.MyFun(); // "Hello From Class"

    /// To Use The Defualt Implmented Method
    /// You Should Create Reference From Interface

    IMyType type2 = new MyType();
    type2.Print();


    



        }
    }

}
