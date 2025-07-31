using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
    
    static class Test
    {
        /// Is A Just Container For Static Members [Attribute , Method , property ,constructor] and Constands
        /// You Can't Create Object From This Class (Helper Class)
        /// No Inheritance For This Class

    }

    class Utility
    {
        public int X { get; set; }
        public int Y { get; set; }

        private static double pi; // You Can Make This {private static double pi = 3.14} Instead Of Creating Static Constructor
        // Compiler Will Initialize The Static Attribute With The Default Value Of Its Datatype = 0;
        // Class Member Property : Static Property

        public static double Pi
        {
            // Static Property Get and Set One Of These :
            // 1. Static Attribute
            // 2. Constant
            get { return Pi; }
            set { Pi = value; }
        }

        public Utility(int X , int Y)
        {
            // Constructor
            this.X = X;
            this.Y = Y;

        }


        // Object Member Method: Non-Static Method
        public int XplusY()
        {
            // To Use This Function You Should Create Object From This Class
            return X + Y;
        }


        // Class Member Method : Static Method
        public static double CmToInch(double c)
        {
            // The Result Of Calling This Method
            // Won't Differ By The Difference Of The Object State [Date(X,Y)]
            // Then Make This Function Static 

            // To Use This Function You Call It By CLass : Ulitity.CmToInch()
            return c / 2.54;
        }



        

        static Utility() 
        {
            /// Static Constructor [Maximum Only One Static Constructor Per Class]
            /// Can't Specifiy Access Modifiers Or Parameters For Static Constructor
            /// Will Be Executed Just One Time Per Class LifeTime Befroe The First Usage Of Class
            /// Usage Of Class :
            /// 1. Call Static Method Or Static Property
            /// 2. Create Object From This Class
            /// 3. Create Object From Anthor Class Interiting From This Class


            //Used For Initalizing The Static Attributes 
            Pi = 3.14;
        }

    }

    



    internal class Program
    {


        static void Main(string[] args)
        {
            Utility U01 = new Utility(5, 6);

            int res1 = U01.XplusY();
            double res2 = Utility.CmToInch(254); // res2 = 100

        }
    }

}
