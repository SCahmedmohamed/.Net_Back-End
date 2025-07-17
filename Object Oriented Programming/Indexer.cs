using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{





    #region Indexer

    struct PhoneBook
    {
        string[] Names;
        long[] Numbers;
        int size;

        public PhoneBook(int size)
        {
            this.size = size;
            Names = new string[size];
            Numbers = new long[size];
        }

        public void AddNumber(int index , string name , long number)
        {
            if(Names is not null && Numbers is not null)
            {
                if(index  < Numbers.Length && index >= 0)
                {
                    Names[index] = name;
                    Numbers[index] = number;
                }
            }
        }

        // We Need To Know The Perosn's Name From The Phone Number 
        // Or Know The Numbeer From The Person's Name
        // There're 2 Ways : [1] Getter Setter 
        //                   [2] Indexer

        #region Getter Setter 

        public string GetName(long number)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == number) return Names[i];
            }
            return "Error";
        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == name) return Numbers[i];
            }
            return -1;
        }


        #endregion

        #region Indexer
        // Indexer : Is a Special Property : 1.Named Always with Keyword "this"
        //                                   2. And Take Parameters


        // You Can Add More Than 1 Inxders (Indexer Overloading)
        // with different Parameters or types of Paremters 

        public long this[string name]
        {
            get
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == name) return Numbers[i];
                }
                return -1;
            }

            set
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == name) Numbers[i] = value; return;
                }
                
            }
        }

        #endregion

    }

    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {

            #region Indexer Ex
            PhoneBook PB = new PhoneBook(4);

            PB.AddNumber(0, "Ahmed", 01020215136);
            PB.AddNumber(1, "Mohamed", 01020215135);
            PB.AddNumber(2, "Ibrahim", 01020215134);
            PB.AddNumber(3, "Ali", 01020215133);

            Console.WriteLine(PB.GetName(01020215135));
            Console.WriteLine(PB["Ahmed"]);
            #endregion

        }
    }
}
