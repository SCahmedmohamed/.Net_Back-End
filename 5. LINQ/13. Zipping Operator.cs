using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /// Produces A Sequance With Elements From The Two Or Three Specific Sequances

            string[] Names = { "Ahmed", "Mohamed", "Ibrahim", "Ali" };
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            char[] Chars = { 'A', 'B', 'C', 'D', 'E' };

            var Result = Names.Zip(Numbers,Chars);

            foreach (var item in Result) Console.WriteLine(item);
            // (Ahmed, 1, A)
            // (Mohamed, 2, B)
            // (Ibrahim, 3, C)
            // (Ali, 4, D)

            /// To Customize The Output
            
            var Result02 = Names.Zip(Numbers,(Names,Numbers) => new {index = Numbers , Name = Names});


            foreach (var item in Result02) Console.WriteLine(item);

        }
    }

}
