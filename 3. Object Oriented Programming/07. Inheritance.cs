using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
    #region Inheritance

    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Parent(int X , int Y)
        {
            this.X = X;
            this.Y = Y;
        }


        public int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }

    class Child : Parent
    {
        // Child Inherited From Parent
        // He Get Parent funcations and Attributes :

        ///public int X { get; set; }
        ///public int Y { get; set; }
        ///public int Product()
        ///{
        ///    return X * Y;
        ///}
        ///public override string ToString()
        ///{
        ///    return $"({X},{Y})";
        ///}


        public int Z { get; set; }
        
        // Ctor In Child Class Chain to Parent(Base) Class
        public Child(int X, int Y , int Z) : base(X, Y) 
        {
            this.Z = Z;
        }


        public new int Product(int x, int y , int z) // New Vision
        {
            // Now You Hide Product Function From Parent 
            // And Now You Use this Function Instead Of Parent Function
            return x * y * z;
        }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }
    }


    #endregion
    internal class Program
    {

        static void Main(string[] args)
        {      
          
        }
    }

}
