using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{





    #region Class

    class Car
    {
        #region Attributes
        int id; // 4 Bytes
        string model; // 4 Bytes
        double speed; // 8 Bytes
        #endregion

        #region Properties
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        #endregion


        public Car(/*int id , string model , double speed*/)
        {
            /// Allowed to initialize some, all, or none of the fields.	
            //this.id = id;
            //this.model = model;
            //this.speed = speed;
        }
        public override string ToString()
        {
            return $"CarID : {id} \n CarModel: {model} \n CarSpeed : {speed}";
        }

    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Class

            Car c1;
            /// Declare For Reference From Type "Car" , Refering To Null
            /// Can Refer To An Object From Type "Car" OR Object From Type Another Class Inheriting from "Car"
            /// CLR Will Allocate 4 Bytes For The Reference 'c1' At STACK
            /// CLR Will Allocate 0 Bytes At HEAP
            

            c1 = new Car();
            /// new :
            /// 1. Allocate Required Number Of Bytes For Object At Heakp [16 Bytes] 
            /// 2. Initialize The Allocated Bytes With the Object Default Value of its DataType
            /// 3. Call User-Defined Constructor [if Exits]
            /// 4. Assign The Address of The Allocated Object At Heap To The Reference 'C1'


            #region Constructor

            /// If No User-Defined Constructor Exists , Compiler Will Always Generate Empty Parameterless Constructor [Do Nothing]
            /// If You Define Constructor , Compiler Will No Longer Generate Empty Parameterless Constructor
            /// You Also Can Many User-Defined Cosntsructors
            ///
            #endregion


            #endregion


        }
    }

}
