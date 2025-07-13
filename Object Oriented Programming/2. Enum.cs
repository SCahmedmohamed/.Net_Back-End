using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{



    #region Enum
    
    enum Day /*: byte */ // You Can Change The DataType
    {
        ///       Default 
        Saturday, // = 0
        Sunday ,  // = 1
        Monday,   // = 2
        Tuseday,  // = 3
        Wednesday,// = 4
        Thursday, // = 5
        Friday    // = 6


    }


    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Enum

            #region What's Enum 
            // An enum is a special value type that allows 
            // you to define a set of named constants
            // It enhances code readability and reduces the use of magic numbers 
            #endregion

            #region Values

            // The Default : Start by 0 
            // If not specified, values start from 0 and increment by 1.

            Day day = Day.Monday;
            Console.WriteLine(day); // output : Monday
            Console.WriteLine((int)day); // output : 2

            int num = 3;
            Day day1 = (Day)num;
            Console.WriteLine(day1); // output : TuesDay


            #endregion

            #region Parsing

            Day day2 = (Day)Enum.Parse(typeof(Day), Console.ReadLine(), true);
            /// To Parse From String To Enum
            /// {Enum_name} {Enum_Varuable} = (Enum_name) Enum.Parse(Typeof({Enum_Name}) , Console.ReadLine() , true);
            /// true : for IgnoreCase --> (A) == (a)
            bool flag = Enum.TryParse(Console.ReadLine(), out day);


            #endregion









            #endregion





        }
    }
}
