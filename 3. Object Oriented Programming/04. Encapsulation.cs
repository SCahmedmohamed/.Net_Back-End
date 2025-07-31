using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{


    #region Encapsulation


    // Encapsulation : Separate Data Definition from its use
    public class Person
    {
        //public int age; // Unsafe -> AnyOne Can Change it


        private int id;
        private int age;
        private string name;

        #region Getter Setter
        public int GetID()
        {
            return id;
        }
        public void SetID(int value)
        {
            id = value;
        }
        #endregion

        #region Property

        // Esay Use Like Attributes


        #region Full ProPerty
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                // You Can Add Condiation like:
                //if( value >= 18)
                age = value;
            }
        } 
        #endregion

        #region ReadOnly Property
        public string Name
        {
            get { return name; }
        } 
        #endregion

        #region Automatic Property

        // Compiler Will Generate Backing Field (Hidden Private Attribute)
        // Compiler Hide (private int salary)
        // And Make Property Salary
        // If You Use Constuckor You Should Use Salary in it
        public int Salary { get; set; } 
        #endregion

        // propfull : is A Code Sinppet For FullProperty
        // Prop : is A Code Sinppet For AutoMatic Property



        #endregion



    }



    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
