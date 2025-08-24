using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{



    internal class Program
    {


        static void Main(string[] args)
        {
            /// Vaild Only With Fluent Syntax
            /// The Only Way To Call Them Is An Static Methods From Class Enumerable

            Enumerable.Range(1, 10);
            /// Taking Two Paramerters (The Start , And Count)

            Enumerable.Repeat("ahmed", 100);
            /// Taking Two Paramerters (The Element (Any Type)  , The Count) 


        }
    }

}
