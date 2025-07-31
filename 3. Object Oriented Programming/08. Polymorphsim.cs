using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{

    class Par
    {
        public int A { get; set; }
        public void Fun01()
        {
            Console.WriteLine("It's Fun01 :)");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"A : {A}");
        }

        public Par(int A)
        {
            this.A = A;
        }

    }

    class Chi : Par
    {
        public int B { get; set; }

        // There're 2 Ways To Do OverRiding
        // First You Use KeyWord "new"

        public new void Fun01() // New Version From Fun01 Method
        {
            Console.WriteLine("It's Fun02 :)");
        }

        // Second You Use KeyWord "override"
        // but The base Function (in Parent Class) Must By *Public* and *Virtual*
        public void Fun02()
        {
            Console.WriteLine($"A : {A} \n B : {B}");
        }




        public Chi(int A, int B) : base(A)
        {
            this.B = B;
        }
    }



    internal class Program
    {


        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        static double Sum(double x, double y)
        {
            return x + y;
        }
        static double Sum(int x, double y)
        {
            return x + y;
        }



        static void Main(string[] args)
        {

            #region Polymorphsim = ManyForms
            // Poly = Many
            // Morphsim = Forms


            /// That You Have Many Function With The Same Name ,
            /// But Every Function Do Different thing
            /// Like : Console.WriteLine();
            ///       1. void Console.WriteLine(bool Value) 
            ///       2. void Console.WriteLine(int Value) 
            ///       3. void Console.WriteLine(string Value) 
            ///       4. void Console.WriteLine(char Value) 
            ///       5. void Console.WriteLine(deciaml Value) 
            ///       6. void Console.WriteLine(double Value) 
            /// And Else (There're 18 froms from Console.WriteLine();)

            /// The Methods Must Be Differ by :
            /// 1. Number Of Parameters
            /// 2. Type Of Paremeters
            /// 3. Order Of Parameters

            /// You cannot overload methods only by changing the return type


            /// int res = Sum();
            /// Here There're 5 options








        }
    }

}
