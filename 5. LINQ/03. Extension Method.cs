using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
  internal static class IntExtensionMethods
  {
    public static int Reverse(this int Number) // To Make This Method : Extension method
                                               // 1. You Need To Add this
                                               // 2. And The Class Must Be Static
    {
        int ReversedNumber = 0;
        int Remainder;
        while (Number > 0)
        {
            Remainder = Number % 10;
            ReversedNumber = ReversedNumber * 10 + Remainder;
            Number /= 10;
        }

        return ReversedNumber;
    }
  }
    


    internal class Program
    {


        static void Main(string[] args)
        {
           #region Extension Method

/// Extension Method Is A Static Method That Allows You To Add New Methods
/// To Exiting Class ( Even You Don't Have The Source Code )
/// Without Modifying Original Class Or using Inheritance

// For Example : We Need To Add Method "Reverse" To Int32

int Number = 987654321;

int ReversedNumber = Number.Reverse();
Console.WriteLine(ReversedNumber);

/// If You Need To Add Extension Method To Many Class 
/// You Can Do It By Using Class That The Classes Inherite Form Him


#endregion
                     
            

        }
    }

}
