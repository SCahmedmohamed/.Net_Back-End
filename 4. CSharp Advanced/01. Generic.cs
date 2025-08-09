namespace CS_Advanced
{


    class Helper
    {
        #region Non-Generic Swap
        //public static void SWAP(ref int x, ref int y)
        //{
        //    // This function To Swap Between 2 Integers Only
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void SWAP(ref double x, ref double y)
        //{
        //    // This function To Swap Between 2 Doubles Only
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}

        #endregion

        #region Generic Swap

        public static void SWAP<T>(ref T x, ref T y)
        {
            // <T> It's Meaning All DataTypes
            // This Function Will Swap All DataTypes

            T temp = x;
            x = y;
            y = temp;
        }

        #endregion

    } 



    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 5, y = 7;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            Console.WriteLine(">>>> SWAP <<<<");
            Helper.SWAP/*<int>*/(ref x, ref y);
            /// Compiler Can Detect The Type Of 'T' Based On The Type Of Method's Input Parameters
            /// In Case Generic Type 'T' is Declared On Method Level Not (Class , Struct , InterFace) Level
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            double a = 2.2, b = 4.4;
            // We Need To Overloading The Function if The Function Is non-Generic
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine(">>>> SWAP <<<<");
            Helper.SWAP(ref a, ref b);
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");





        }
    }
}
