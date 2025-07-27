using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{



    internal class Program
    {


        static void Main(string[] args)
        {
                        // 1. Shallow Copy : A shallow copy creates a new object, but copies the references of the fields (if they are reference types)
            // rather than the actual objects.

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            Console.WriteLine($"Hash Code For arr1 {arr1.GetHashCode()}");// 58225482
            Console.WriteLine($"Hash Code For arr2 {arr2.GetHashCode()}");// 18643569

            Console.WriteLine("After Shallow Copy !");
            arr2 = arr1;

            Console.WriteLine($"Hash Code For arr1 {arr1.GetHashCode()}");// 58225482
            Console.WriteLine($"Hash Code For arr2 {arr2.GetHashCode()}");// 58225482
            /// Now This Object {1,2,3} Has 2 References [arr1,arr2] 
            /// This Object {4,5,6} Become UnReachable Object

            arr2[0] = 100;

            Console.WriteLine(arr1[0]); // 100
            /// Because arr1 and arr2 References To Same Object



            // 2. Deep Copy : : A deep copy creates a completely new object and also creates new copies of any referenced objects.

            int[] arr3 = { 1, 2, 3 };
            int[] arr4 = { 1, 2, 3 };

            Console.WriteLine($"Hash Code For arr3 {arr3.GetHashCode()}");// 33574638
            Console.WriteLine($"Hash Code For arr4 {arr4.GetHashCode()}");// 33736294

            Console.WriteLine("After Deep Copy !");

            arr4 = (int[])arr3.Clone();
            /// Clone Method : Will Generate New Object With New and Different Identity
            ///    but With The Same Object State [Data] of Caller Object "arr3"

            Console.WriteLine($"Hash Code For arr3 {arr3.GetHashCode()}");// 33574638
            Console.WriteLine($"Hash Code For arr4 {arr4.GetHashCode()}");// 35191196

            arr3[0] = 100;

            Console.WriteLine(arr4[0]);  // It Will Still "1"


            /// Shallow Copy Is Faster Thans Deep Copy
            /// Deep Copy Has More Complex

        }
    }

}
