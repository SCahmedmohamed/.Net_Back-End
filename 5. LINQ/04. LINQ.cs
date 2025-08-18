using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{



    internal class Program
    {


        static void Main(string[] args)
        {
            
            #region LINQ

            // LINQ : Stands For Language-Intergrated Query
            //      : +40 Extension Methods For Built-Interface "Enumerable"
            //      : Named as "LINQ Operators" Existed In Class "Enumerable"
            //      : Categorized into 13 Categories

            // Use LINQ Operators Against Data(Stored In Sequence) , Regardless Data Store(File , Database Provite)
            // Sequence : is An Object From Class Implements Interface "Enumerable"  Like List , Hashset , ArrayList , Others
            // 1. Local Sequence   L2O (LinQ To Object)     
            // 2. Remote Sequence  L2EF(LinQ To EntityFramework) 


            #region LINQ Syntax

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1. Fluent Syntax
            // Write C#
            // 1.1 You Can Call "LINQ Operator" As => Static Method Through "Enumerable" Class **Not Recommended**
            var OddNumber = Enumerable.Where(Numbers, p => p % 2 != 0);

            // 1.2 You Can Call "LINQ Operator" As => Extension Method  ** Recommended ** 
            OddNumber = Numbers.Where(p => p % 2 != 0);

            // 2. Query Syntax : Query Expression (Like: SQLServer Style)

            OddNumber = from N in Numbers
                        where N % 2 != 0
                        select N;

            #endregion

            #region Execution Ways 

            /// 1. Immediate Execution :
            /// The Query Is Executed As soon As It Is Defined , And Results Is Stored Immediately
            /// Like [ ToList() - ToArray() - Count() - Sum() - Max() , etc ]
            /// Memory Use : Higher (Stores Results)

            /// 2. Differed Execution :
            /// The Query Is Not Executed Immediately When You Define It 
            /// Instead, it’s executed only when you enumerate (iterate) over it (e.g., with foreach, ToList(), Count(), etc.).
            /// This means LINQ just stores the query definition, not the result.
            /// Memory Use : Low (Query Stored)


            // Use deferred execution when you want queries to reflect the latest data.

            // Use immediate execution when you want a snapshot of the data at that moment.


            #endregion

            #endregion



        }
    }

}
