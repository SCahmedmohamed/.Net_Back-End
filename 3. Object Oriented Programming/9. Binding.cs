using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{

    class TypeA
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

        public TypeA(int A)
        {
            this.A = A;
        }

    }


    class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int A, int B) : base(A)
        {
            this.B = B;
        }

        // Static Binding Using "new" KeyWord
        public new void Fun01()
        {
            Console.WriteLine("It's Fun02 :)");
        }
        // Dynamic Binding Using "override" KeyWord
        public override void Fun02()
        {
            Console.WriteLine($"A: {A} \n B: {B}");
        }
    }

    



    internal class Program
    {


        static void Main(string[] args)
        {
            
            

            #region What Is Binding
            // Binding : Refernce From Parent --> Object From Child


            TypeA type = new TypeB(1, 2);
            // You Will See The Inherited Function And Attributes 


            type.A = 10;
            /// type.B = 20; // Invilad : You Cant See {B} in Child 

            type.Fun01();
            /// Static Binding [Early Binding] :
            /// Compiler Will Bind Function Call Based on Reference Type Not Object Type At Compilation Time
            /// Fun01 is overrided By "new" So You Will Run Fun01() From TypeA (The Parent)

            type.Fun02();
            /// Dynamic Binding[Late Binding] :
            /// CLR Will Bind Function Call Based On Object Type Not Reference Type At Runtime 
            /// Fun02 is Overrided By "override" So You Will Run Fun02() From TypeB (Child) The Last One Did override 
            #endregion

            #region Not Binding

            /// Ainmal = Dog ------> Binding "Dog is An Animal"
            /// Employee = FullTimeEmployee -----> Binding "FullTimeEmployee is An Employee

            /// Dog = (Dog) Animal ------> Explicit Casting "Not All Animals are Dogs"
            /// FullTimeEmployee = (FullTimeEmployee) Employee -----> Explicit Casting "Not All Employees Are FullTimeEmployee 

            #endregion


            


        }
    }

}
