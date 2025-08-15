namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Implicityle Typed : Mean Complier Will Detect The Type Of The Variable
            /// By 2 CS KeyWords :
            ///                    1. var
            ///                    2. dynamic

            #region Var

            // var : is a C# Keyword [C# 3.0 Feature]

            var name = "ahmed";
            /// Compiler Can Detect The Type Of Variable Based On Initial Value 
            /// He Is Type Safe !!! 
            
            /// Must Be Initialized
            // var Number;  Invaild
            
            /// Cant Be Initialized With Null At First Time 
            name = null; // Vaild
            // var H = null; // Invaild

            /// After Initialization , You Can't Change The Varialbe DataType
            //name = 5; // Invaild



            #endregion

            #region Dynamic

            // dynamic : is a C# Keyword [C# 4.0 Feature]

            dynamic date = "Ahmed";
            /// Compiler Will Escape Type Checking At Compilation Time
            /// CLR Will Resolve The Actual Type Of A Dynamic Variable At RunTime And Will Be Changged Based On The Assigned Value
            /// Didnt Have To Initialized The Variable
            /// Can Be Initialized With Null
            /// You Can Change The its DataType
            /// He Is Not Type Safe !!!!!
            
            date = 5; // Valid
            date = true; // Valid

            // When We Use It ? 
            // Use Dynamic When You Need To Create A Varialbe That Support All DataTypes

            #endregion





        }
    }
}
