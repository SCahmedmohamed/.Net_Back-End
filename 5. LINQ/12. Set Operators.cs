using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            int[] arr1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] arr2 = {6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var Result01 = arr1.Union(arr2);
            // Returns Unique Elements That Appear In Either Sequence 
            // Without Duplication (Repeating)

            var Result02 = arr1.Concat(arr2);
            // Return All Elements Of The 2 Sequences 
            // With Duplication (Repeating)

            var Result03 = Result02.Distinct();
            // Remove The Duplication (Repeating)


            var Result04 = arr1.Intersect(arr2);
            // Returns Elements Common To Both Sequences (Like AND).


            var Result05 = arr1.Except(arr2);
            // Returns Elements In The First Sequence That Don’t Appear In The Second One.

            foreach ( var i in Result04)
            {
                Console.WriteLine(i);
            }
           

        }
    }
}
