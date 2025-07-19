using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{


    #region Struct

    struct Point
    {
        public int X;
        public int Y;


        #region Default Constructor
        // By default at Struct , Compiler Will Generate Parameterless Constructor
        // This Constructor Initialize The Attributes of Struct With Default Value Of Attributes
        // int --> 0 , Double --> 0.0 , book --> false , char --> '\0' , string --> null
        // It Mean You Havent to Create This Constructor -->
        //
        /*public Point()
        {

            X = default;
            Y = default;
        }*/


        #endregion


        public Point(int _X , int _Y)
        {
            X = _X;
            Y = _Y;
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Struct

            #region What's The Differents Between Struck and Class
            /// |------------------------------------------------------------------------------------|
            /// |                   | Struct                         | Class                         |
            /// |-------------------|--------------------------------|-------------------------------|
            /// |Type               | Value Type                     | Reference Type                |
            /// |Memory Location    | Stack                          | Heap                          |
            /// |Passing            | By Value(Default)              | By Reference (Default)        |
            /// |Inheritance        | Doesn't Support                | Support                       |
            /// |Performance        | Faster due to stack allocation | Slower due to heap allocation |
            /// |Default Constructor| Automatically created          | Can be defined manually       |
            /// |Mutability	        | Usually immutable              | Mutable                       |
            /// |Common Use	        | For small data structures      | For complex or large objects  |
            /// |------------------------------------------------------------------------------------|






            #endregion

            #region Constructor

            /// Constructor Is Special Function why?:
            /// 1. Named Always With the Same Name Of Stuck Or Class
            /// 2. There's No Return 
            /// 3. Called automatically when using new
            /// 4. You can create multiple constructors using overloading
            /// 5. If you don’t define a constructor, C# provides a default constructor automatically 
            /// 6. If you define any constructor, the default one is not created automatically 
            /// 7. Constructors can call each other using this() keyword	



            #endregion

            #region About Create Struct
            Point p1;
            // Declare For Object From Type "Point"
            // CLR (Common Language Runtime) will Alocate 8 bytes UnInitialized at Stack

            p1 = new Point();
            // New is just Only For Consturctor Selecttion
            // That Will by Initialize The Attributes of the Object


            #endregion



            #endregion



        }
    }
}
