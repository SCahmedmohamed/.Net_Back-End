using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{
    

    // Operator OverLoading : Public Class Member Method
    class complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public static complex operator +(complex x, complex y)
        {
            return new complex
            {
                Real = x.Real + y.Real,
                Imag = x.Imag + y.Imag
            };
        } 
        public static complex operator -(complex x, complex y)
        {
            return new complex
            {
                Real = x.Real - y.Real,
                Imag = x.Imag - y.Imag
            };
        }

        public static explicit operator int(complex x)
        {
            return x?.Real ?? 0;
        }

    }


    internal class Program
    {


        static void Main(string[] args)
        {

            complex c01 = new complex() { Real = 5, Imag = 4 };   
            complex c02 = new complex() { Real = 3, Imag = 2 };

            complex c03 = default;

            /// c03 = c01 + c02; Invaild : There is no + Opearation Take 2 Complex Number
            /// You Should Create Function Opeator + in the Complex Class

            c03 = c01 + c02; // Now Is Vaild


            // And You Also Can Create {+ , - , > , < , == , <= , >= , != }
            /// Note : If You Create '>' Opeator You Should Create '<' Also
            /// Note : If You Create '=>' Opeator You Should Create '=<' Also
            /// Note : If You Create '!=' Opeator You Should Create '==' Also
            /// And Also You Can Create Explicit Casting Opeator
            /// and Create Implicit Casting but the better is Explicit

            int a = (int)c03;

        }
    }

}
