using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{

  abstract class Shape // Not Fully Implmented Class
  {
    // You Cant Create Object [Instance] From This  Class
    // You have To Inherite This Class To Implment It
    public decimal Dim01 { get; set; }
    public decimal Dim02 { get; set; }

    #region Abstract Property

    public abstract decimal perimeter { get; }

    #endregion

    #region Abstract Method
    // You Dont Know The Type Of shape 
    // You Should Create Absract Method With no Body
    //public decimal ClacArea()
    //{
    //}

    public abstract decimal ClacArea(); // Not Fully Implmented Method 
    #endregion
  }





/// : between 2 classes --> Inheritance
/// : between Class And Interface --> Implmentation
/// : between Class And Abstract Class --> Inheritance and Implmentation
   



  class Rectangle : Shape // : --> Inherits and Implments
  {
    // Use "Override" key Word To override virtual methods
    // Or Implment Abstract Methods and property


      public override decimal perimeter 
      {
          get { return (Dim01 + Dim02) * 2; }

      }

      public override decimal ClacArea()
      {
          return Dim01 * Dim02;
      }
  }

  class Square : Shape
  {
      public override decimal perimeter
    {
        get { return Dim01 * 4; }
    }

    public override decimal ClacArea()
    {
        return (Dim01 * Dim02);
    }
  }





    internal class Program
    {


        static void Main(string[] args)
        {
            /// Abstract Class : Is A Partial Implmentation For Anthor Class

            Rectangle rectangle = new Rectangle() { Dim01 = 10,Dim02 =20};

            decimal rectArea = rectangle.ClacArea();

            Console.WriteLine(rectArea);

             #region InterFace Vs Abstract Class


///|-----------------------------|--------------------------------------|-----------------------------------|
///| Comparison point            |      InterFace                       |   Abstract Class                  |
///|-----------------------------|--------------------------------------|-----------------------------------|
///|Multiple inheritance allowed | Yes                                  | No ( Only One Base Class)         |  
///|Inherits from	             | Other interFaces                     | One Class , InterFaces            |
///|Fields                       | No                                   | Yes                               |
///|Constructor                  | No                                   | Yes                               |
///|Constants                    | Yes                                  | Yes                               |
///|Properties                   | Yes                                  | Yes                               |
///|Events                       | Yes                                  | Yes                               |
///|Method Body                  | Yes ( From C# 8.0 )                  | Yes                               |
///|--------------------------------------------------------------------------------------------------------|


// Use InterFace When:
/// 1. You Want To Define A Contract Only
/// 2. Muliple Inheritancee Is Needed 
/// 3. Unrelated Classes Need To Implement Behavior


// Use Abstract Class When:
/// 1. You Want To Share Base Logic + Contract
/// 2. Only Single Inheritance Is Required 
/// 3. Related Classes Shaare Common Base Functionality

#endregion


            

        }
    }

}
