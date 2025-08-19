using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Array = new List<int>() { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 , 17 };

            #region First OverLoad 
            /// Taking Func Of One Parameter

            // Fluent Syntax
            var Result = Array.Where(P => P % 2 == 0); // You Can Add More Conditions By using "&&"
            foreach (var item in Result) Console.WriteLine(item);

            // Query Syntax
            Result = from N in Array
                     where N % 2 == 0// You Can Add More Conditions By using "&&"
                     select N;
            foreach (var item in Result) Console.WriteLine(item);


            #endregion

            #region Second OverLoad

            /// Taking Func Of Two Parameters

            var Result02 = Array.Where((P, I) => I < 10 && P % 2 == 0);
            /// Get The Even Number In The First 10 indexs
            foreach (var item in Result02) Console.WriteLine(item);

            #endregion

            


        }
    }

}
