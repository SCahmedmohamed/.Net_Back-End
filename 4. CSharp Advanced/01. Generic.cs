using System.Data;

namespace CS_Advanced
{


    #region Generic Functions
    //class Helper
    //{
    //    #region Non-Generic Swap
    //    //public static void SWAP(ref int x, ref int y)
    //    //{
    //    //    // This function To Swap Between 2 Integers Only
    //    //    int temp = x;
    //    //    x = y;
    //    //    y = temp;
    //    //}
    //    //public static void SWAP(ref double x, ref double y)
    //    //{
    //    //    // This function To Swap Between 2 Doubles Only
    //    //    double temp = x;
    //    //    x = y;
    //    //    y = temp;
    //    //}

    //    #endregion

    //    #region Generic Swap

    //    public static void SWAP<T>(ref T x, ref T y) /// where T : Class
                                                       /// Where T : IComparable
                                                       
    //    {
    //        // <T> It's Meaning All DataTypes
    //        // This Function Will Swap All DataTypes

    //        T temp = x;
    //        x = y;
    //        y = temp;
    //    }

    //    #endregion

    //} 

    #region Linear Search

    class Healper<T> where T : class
    {

        public static int ArraySearch(T[] Arr, T target) 
        {
            if(Arr is not null)
            {
                for(int i = 0; i < Arr.Length; i++)
                {
                    
                    if (Arr[i] == target) return i;
                    /// It Will Give You Exception 
                    /// Because Generic Maybe Class or Struct 
                    /// And Default Struct Didnt Implment "==" 
                    /// You Have 2 Options :
                    /// 1. Write " where T : class "
                    /// Or
                    /// 2. Go And Implment == in Struct 


                    if (Arr[i].Equals(target)) return i;
                    /// But Here : "Equals" Is Implmented in Class and Struck

                }
            }
            return -1;
        }
    }

    #endregion

    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {

            #region Generic SWAP Ex01
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


            #endregion

            
        }
    }
}
