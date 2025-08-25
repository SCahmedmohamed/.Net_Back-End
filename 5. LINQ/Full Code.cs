using System.Reflection; 
using System.Runtime.Intrinsics.X86; 
using System; 
using System.Xml.Linq;
using static LINQ.ListGenerator;
using System.Collections;
namespace LINQ 
{ 
     
    #region Extension Method Ex
    //internal static class IntExtensionMethods
    //{
    //    public static int Reverse(this int Number) // To Make This Method : Extension method
    //                                               // 1. You Need To Add this
    //                                               // 2. And The Class Must Be Static
    //    {
    //        int ReversedNumber = 0;
    //        int Remainder;
    //        while (Number > 0)
    //        {
    //            Remainder = Number % 10;
    //            ReversedNumber = ReversedNumber * 10 + Remainder;
    //            Number /= 10;
    //        }

    //        return ReversedNumber;
    //    }
    //} 
    #endregion 
 
    #region Eample For All

    class Product
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


        public override string ToString()
            => $"ProductID: {ProductID}, ProductName: {ProductName}, Category: {Category}, UnitPrice: {UnitPrice:c}, UnitsInStock: {UnitsInStock}";

    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }
        public Customer(string customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Orders = new Order[10];
        }
        public Customer()
        {

        }
        public override string ToString()
            => $"{CustomerID}, {CustomerName}, {Address}, {City}, {Region}, {PostalCode}, {Country}, {Phone}, {Fax}";
    }
    class Order
    {

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }
        public Order()
        {

        }

        public override string ToString()
            => $"Order Id: {OrderID}, Date: {OrderDate.ToShortDateString()}, Total: {Total}";
    }
    internal static class ListGenerator
    {
        public static List<Product> ProductList { get; set; }
        public static List<Customer> CustomerList { get; set; }

        static ListGenerator()
        {
            ProductList = new List<Product>()
            {
                new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
                            UnitPrice = 18.00M, UnitsInStock = 100},
                    new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                        UnitPrice = 19.0000M, UnitsInStock = 17 },
                      new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
                        UnitPrice = 10.0000M, UnitsInStock = 13 },
                      new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                        UnitPrice = 22.0000M, UnitsInStock = 53 },
                      new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                        UnitPrice = 21.3500M, UnitsInStock = 0 },
                      new Product{ ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                        UnitPrice = 25.0000M, UnitsInStock = 120 },
                      new Product{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                        UnitPrice = 30.0000M, UnitsInStock = 15 },
                      new Product{ ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                        UnitPrice = 40.0000M, UnitsInStock = 6 },
                      new Product{ ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry",
                        UnitPrice = 97.0000M, UnitsInStock = 29 },
                      new Product{ ProductID = 10, ProductName = "Ikura", Category = "Seafood",
                        UnitPrice = 31.0000M, UnitsInStock = 31 },
                      new Product{ ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products",
                        UnitPrice = 21.0000M, UnitsInStock = 22 },
                      new Product{ ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                        UnitPrice = 38.0000M, UnitsInStock = 86 },
                      new Product() { ProductID = 13, ProductName = "Konbu", Category = "Seafood",
                        UnitPrice = 6.0000M, UnitsInStock = 24 },
                      new Product() { ProductID = 14, ProductName = "Tofu", Category = "Produce",
                        UnitPrice = 23.2500M, UnitsInStock = 35 },
                      new Product() { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments",
                        UnitPrice = 15.5000M, UnitsInStock = 39 },
                      new Product() { ProductID = 16, ProductName = "Pavlova", Category = "Confections",
                        UnitPrice = 17.4500M, UnitsInStock = 29 },
                      new Product() { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry",
                        UnitPrice = 39.0000M, UnitsInStock = 0 },
                      new Product() { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood",
                        UnitPrice = 62.5000M, UnitsInStock = 42 },
                      new Product() { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                        UnitPrice = 9.2000M, UnitsInStock = 25 },
                      new Product() { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                        UnitPrice = 81.0000M, UnitsInStock = 40 },
                      new Product() { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections",
                        UnitPrice = 10.0000M, UnitsInStock = 3 },
                      new Product() { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals",
                        UnitPrice = 21.0000M, UnitsInStock = 104 },
                      new Product() { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals",
                        UnitPrice = 9.0000M, UnitsInStock = 61 },
                      new Product() { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages",
                        UnitPrice = 4.5000M, UnitsInStock = 20 },
                      new Product() { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections",
                        UnitPrice = 14.0000M, UnitsInStock = 76 },
                      new Product() { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections",
                        UnitPrice = 31.2300M, UnitsInStock = 15 },
                      new Product() { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections",
                        UnitPrice = 43.9000M, UnitsInStock = 49 },
                      new Product() { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce",
                        UnitPrice = 45.6000M, UnitsInStock = 26 },
                      new Product() { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                        UnitPrice = 123.7900M, UnitsInStock = 0 },
                      new Product() { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood",
                        UnitPrice = 25.8900M, UnitsInStock = 10 },
                      new Product() { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                        UnitPrice = 12.5000M, UnitsInStock = 0 },
                      new Product() { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                        UnitPrice = 32.0000M, UnitsInStock = 9 },
                      new Product() { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products",
                        UnitPrice = 2.5000M, UnitsInStock = 112 },
                      new Product() { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 111 },
                      new Product() { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 20 },
                      new Product() { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood",
                        UnitPrice = 19.0000M, UnitsInStock = 112 },
                      new Product() { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood",
                        UnitPrice = 26.0000M, UnitsInStock = 11 },
                      new Product() { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages",
                        UnitPrice = 263.5000M, UnitsInStock = 17 },
                      new Product() { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 69 },
                      new Product() { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood",
                        UnitPrice = 18.4000M, UnitsInStock = 123 },
                      new Product() { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                        UnitPrice = 9.6500M, UnitsInStock = 85 },
                      new Product() { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                        UnitPrice = 14.0000M, UnitsInStock = 26 },
                      new Product() { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages",
                        UnitPrice = 46.0000M, UnitsInStock = 17 },
                      new Product() { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments",
                        UnitPrice = 19.4500M, UnitsInStock = 27 },
                      new Product() { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood",
                        UnitPrice = 9.5000M, UnitsInStock = 5 },
                      new Product() { ProductID = 46, ProductName = "Spegesild", Category = "Seafood",
                        UnitPrice = 12.0000M, UnitsInStock = 95 },
                      new Product() { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections",
                        UnitPrice = 9.5000M, UnitsInStock = 36 },
                      new Product() { ProductID = 48, ProductName = "Chocolade", Category = "Confections",
                        UnitPrice = 12.7500M, UnitsInStock = 15 },
                      new Product() { ProductID = 49, ProductName = "Maxilaku", Category = "Confections",
                        UnitPrice = 20.0000M, UnitsInStock = 10 },
                      new Product() { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections",
                        UnitPrice = 16.2500M, UnitsInStock = 65 },
                      new Product() { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce",
                        UnitPrice = 53.0000M, UnitsInStock = 20 },
                      new Product() { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals",
                        UnitPrice = 7.0000M, UnitsInStock = 38 },
                      new Product() { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry",
                        UnitPrice = 32.8000M, UnitsInStock = 0 },
                      new Product() { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry",
                        UnitPrice = 7.4500M, UnitsInStock = 21 },
                      new Product() { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry",
                        UnitPrice = 24.0000M, UnitsInStock = 115 },
                      new Product() { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                        UnitPrice = 38.0000M, UnitsInStock = 21 },
                      new Product() { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals",
                        UnitPrice = 19.5000M, UnitsInStock = 36 },
                      new Product() { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood",
                        UnitPrice = 13.2500M, UnitsInStock = 62 },
                      new Product() { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                        UnitPrice = 55.0000M, UnitsInStock = 79 },
                      new Product() { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                        UnitPrice = 34.0000M, UnitsInStock = 19 },
                      new Product() { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments",
                        UnitPrice = 28.5000M, UnitsInStock = 113 },
                      new Product() { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections",
                        UnitPrice = 49.3000M, UnitsInStock = 17 },
                      new Product() { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments",
                        UnitPrice = 43.9000M, UnitsInStock = 24 },
                      new Product() { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals",
                        UnitPrice = 33.2500M, UnitsInStock = 22 },
                      new Product() { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                        UnitPrice = 21.0500M, UnitsInStock = 76 },
                      new Product() { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                        UnitPrice = 17.0000M, UnitsInStock = 4 },
                      new Product() { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 52 },
                      new Product() { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections",
                        UnitPrice = 12.5000M, UnitsInStock = 6 },
                      new Product() { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products",
                        UnitPrice = 36.0000M, UnitsInStock = 26 },
                      new Product() { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages",
                        UnitPrice = 15.0000M, UnitsInStock = 15 },
                      new Product() { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products",
                        UnitPrice = 21.5000M, UnitsInStock = 26 },
                      new Product() { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                        UnitPrice = 34.8000M, UnitsInStock = 14 },
                      new Product() { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood",
                        UnitPrice = 15.0000M, UnitsInStock = 101 },
                      new Product() { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce",
                        UnitPrice = 10.0000M, UnitsInStock = 4 },
                      new Product() { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages",
                        UnitPrice = 7.7500M, UnitsInStock = 125 },
                      new Product() { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 57 },
                      new Product() { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                        UnitPrice = 13.0000M, UnitsInStock = 32 }
            };

            CustomerList = (from e in XDocument.Load("Customers.xml").Root.Elements("customer")
                            select new Customer()
                            {
                                CustomerID = (string)e.Element("id"),
                                CustomerName = (string)e.Element("name"),
                                Address = (string)e.Element("address"),
                                City = (string)e.Element("city"),
                                Region = (string)e.Element("region"),
                                PostalCode = (string)e.Element("postalcode"),
                                Country = (string)e.Element("country"),
                                Phone = (string)e.Element("phone"),
                                Fax = (string)e.Element("fax"),
                                Orders = (
                                     from o in e.Elements("orders").Elements("order")
                                     select new Order
                                     {
                                         OrderID = (int)o.Element("id"),
                                         OrderDate = (DateTime)o.Element("orderdate"),
                                         Total = (decimal)o.Element("total")
                                     }).ToArray()
                            }).ToList();
        }
    }

    #endregion

    internal class Program
    {
         static void Main(string[] args)
         {

            #region Implicitly-Typed Local Variable

            /// Implicityle Typed : Mean Complier Will Detect The Type Of The Variable
            /// By 2 CS KeyWords :
            ///                    1. var
            ///                    2. dynamic

            #region Var

            //// var : is a C# Keyword [C# 3.0 Feature]

            //var name = "ahmed";
            ///// Compiler Can Detect The Type Of Variable Based On Initial Value 
            ///// He Is Type Safe !!! 

            ///// Must Be Initialized
            //// var Number;  Invaild

            ///// Cant Be Initialized With Null At First Time 
            //name = null; // Vaild
            //// var H = null; // Invaild

            ///// After Initialization , You Can't Change The Varialbe DataType
            ////name = 5; // Invaild



            #endregion

            #region Dynamic

            //// dynamic : is a C# Keyword [C# 4.0 Feature]

            //dynamic date = "Ahmed";
            ///// Compiler Will Escape Type Checking At Compilation Time
            ///// CLR Will Resolve The Actual Type Of A Dynamic Variable At RunTime And Will Be Changged Based On The Assigned Value
            ///// Didnt Have To Initialized The Variable
            ///// Can Be Initialized With Null
            ///// You Can Change The its DataType
            ///// He Is Not Type Safe !!!!!

            //date = 5; // Valid
            //date = true; // Valid

            //// When We Use It ? 
            //// Use Dynamic When You Need To Create A Varialbe That Support All DataTypes

            #endregion



            #endregion

            #region Anonymous Type

            //// For Example : 
            //// When You Create Class Employee That Have Properties (ID , Name , Salary)
            //// And This Class Will Use It For 1 time Or 2 Times Only 
            //// Then You Haven't Need To Creat This Class
            //// Best Case Here To Create Anonymous Type

            //var employee = new { ID = 1, Name = "Ahmed", Salary = 30000.00 };
            //Console.WriteLine(employee.ID);
            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.Salary);

            //// The Object That Will Be Created From "AnonymousType" => Is an Immutable Object [Cant Be Changed]
            //// employee.ID = 20; Invaild
            //// If You Want To Change Property You Have To Create New Object Or :
            ///// employee = new { ID = 20, Name = "Ahmed", Salary = 30000.00 };
            //employee = employee with { ID = 20 }; // Syntax Sugar   

            //Console.WriteLine(employee.GetType().Name); // AnonymousType0`3 -> (0 fro ,3 for  properties)
            //Console.WriteLine(employee.ToString()); // { ID = 1, Name = "Ahmed", Salary = 30000.00 }

            //// The Same AnonymouseType As Long As :
            //// 1. The Same Properties Naming (Case Sensetive]
            //// 2. The Same Properties Order

            #endregion

            #region Extension Method

            ///// Extension Method Is A Static Method That Allows You To Add New Methods
            ///// To Exiting Class ( Even You Don't Have The Source Code )
            ///// Without Modifying Original Class Or using Inheritance

            //// For Example : We Need To Add Method "Reverse" To Int32

            //int Number = 987654321;

            //int ReversedNumber = Number.Reverse();
            //Console.WriteLine(ReversedNumber);

            ///// If You Need To Add Extension Method To Many Class 
            ///// You Can Do It By Using Class That The Classes Inherite Form Him


            #endregion

            #region LINQ

            //// LINQ : Stands For Language-Intergrated Query
            ////      : +40 Extension Methods For Built-Interface "Enumerable"
            ////      : Named as "LINQ Operators" Existed In Class "Enumerable"
            ////      : Categorized into 13 Categories

            //// Use LINQ Operators Against Data(Stored In Sequence) , Regardless Data Store(File , Database Provite)
            //// Sequence : is An Object From Class Implements Interface "Enumerable"  Like List , Hashset , ArrayList , Others
            //// 1. Local Sequence   L2O (LinQ To Object)     
            //// 2. Remote Sequence  L2EF(LinQ To EntityFramework) 


            #region LINQ Syntax

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// 1. Fluent Syntax
            //// Write C#
            //// 1.1 You Can Call "LINQ Operator" As => Static Method Through "Enumerable" Class **Not Recommended**
            //var OddNumber = Enumerable.Where(Numbers, p => p % 2 != 0);

            //// 1.2 You Can Call "LINQ Operator" As => Extension Method  ** Recommended ** 
            //OddNumber = Numbers.Where(p => p % 2 != 0);

            //// 2. Query Syntax : Query Expression (Like: SQLServer Style)

            //OddNumber = from N in Numbers
            //            where N % 2 != 0
            //            select N;

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

            #region Filteration (Restrication) Operators - Where

            //List<int> Array = new List<int>() { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 , 17 };

            #region First OverLoad 
            ///// Taking Func Of One Parameter

            //// Fluent Syntax
            //var Result = Array.Where(P => P % 2 == 0); // You Can Add More Conditions By using "&&"
            //foreach (var item in Result) Console.WriteLine(item);

            //// Query Syntax
            //Result = from N in Array
            //         where N % 2 == 0// You Can Add More Conditions By using "&&"
            //         select N;
            //foreach (var item in Result) Console.WriteLine(item);


            #endregion

            #region Second OverLoad

            ///// Taking Func Of Two Parameters

            //var Result02 = Array.Where((P, I) => I < 10 && P % 2 == 0);
            ///// Get The Even Number In The First 10 indexs
            //foreach (var item in Result02) Console.WriteLine(item);

            #endregion

            #endregion

            #region Tranformation (Projection) Operators - Select | SelctMany

            #region Select
            ///// 1st Overload Taking Func Of One Parameter

            //// Flunet Syntax
            //var Result = ProductList.Select(P => P.ProductName);

            //// Query Syntax
            //Result = from N in ProductList
            //         select N.ProductName;

            ///// 2nd Overload Taking Func Of Two Parameters (Indexed Select)
            ///// Only Valid With Flunt Syntax , You Can't Use Index In Query Syntax
            //// Fluent Syntax
            //var Result2 = ProductList.Select((p, i) => new {Index = i , Pname = p.ProductName });


            #endregion

            #region Select Many
            ///// 1st Overload 

            ////var Result3 = CustomerList.Select(P => P.Orders);
            ////foreach(var item in Result3) Console.WriteLine(item); // Here Will Output The NameSpace Not The Value 
            //                                                        // Why ? Because Orders Is Array , Every Customer Have Many Orders
            //// Flunet Syntax
            ///// Here You Should Use SelcetMany
            //var Result3 = CustomerList.SelectMany(P => P.Orders);
            //foreach(var item in Result3) Console.WriteLine(item); // Here Will Print The Values

            //// Query Syntax 
            //Result3 = from C in CustomerList
            //          from O in C.Orders
            //          select O;


            ///// 2nd Overload
            ///// Taking Two Func : Func of One Parameter
            /////                 : Func Of Two Parameter  -Output-

            //// Flunet Syntax
            //var Result4 = CustomerList.SelectMany(p => p.Orders, (Customer, Order) => new { Customer, Order });
            //// Here We Get All Customers With Their All Orders
            //foreach (var item in Result4) Console.WriteLine($"{item.Customer.CustomerName} :: {item.Order}");

            //// Query Syntax
            //var Result5 = from C in CustomerList
            //              from O in C.Orders
            //              select new {Customer = C , Order = O};

            #endregion

            #endregion

            #region Ordering Operators

            #region Order-OrderBy

            //// Flunet Syntax

            //// var Result01 = ProductList.Order(); // ordering Product Accending . Based On : IComparable
            //// Must Implement IComparable InterFace

            ////var Reuslt01 = ProductList.OrderDescending();// ordering Product Descending . Based On : IComparable
            //// Must Implement IComparable InterFace

            //var Result01 = ProductList.OrderBy(p => p.UnitsInStock); // Ordering Product Accending Based On UnitsInStock
            //                                                         // You dont Need To Implemet IComparable 


            //var Result02 = ProductList.OrderByDescending(p => p.UnitsInStock); //  Ordering Product Descending Based On UnitsInStock
            //                                                                   // You dont Need To Implemet IComparable 

            //// Query Syntax

            //Result01 = from P in ProductList
            //           orderby P.UnitsInStock
            //           select P;

            //Result02 = from P in ProductList
            //           orderby P.UnitsInStock descending
            //           select P;


            ///// If There Are Products With The Same UnitsInStock 
            ///// You Cant use OrderBy After OrderBy
            ///// Like : var Res = ProductList.OrderBy(P => P.UnitsInStock).OrderBy(P=>P.UnitPrice);
            ///// Because The Second OrderBy Will Cancel The First One
            ///// Here You Can Use ".ThenBy" in Fluent Syntax


            //var Result03 = ProductList.OrderBy(P => P.UnitsInStock).ThenBy/*Desc ending*/(P => P.UnitPrice);

            ///// In Query Syntax use ","

            //var Result04 = from P in ProductList
            //               orderby P.UnitsInStock /*descending*/ , P.UnitPrice /*descending*/
            //               select P;

            #endregion

            #region Reverse

            //var Result05 = ProductList.Where(P => P.UnitsInStock == 0).Reverse();
            ///// Reversing The Order 

            #endregion

            #endregion

            #region Element Operator  
            // Vaild Only With Fluent Syntax

            #region First - Last - Default
            ///// Immediate Execution

            //var Res01 = ProductList.First(); // Get First Element At Sequence
            //var Res02 = ProductList.Last(); // Get Last Element At Sequence
            //Console.WriteLine(Res01);
            //Console.WriteLine(Res02);


            ///// NOTE : If There Is No Element At List (Empty List) That Will Throw Execption 
            ////List<int> ints = new List<int>() ;
            ////var res = ints.First();
            ////Console.WriteLine(res); // System.InvalidOperationException

            //// Here The Best Case :[ FirstOrDefault() , LastOrDefault() ] => Recommened 

            /////=+ First OverLoad +=

            //Res01 = ProductList.FirstOrDefault();
            //// Get The Frist Element At Sequence
            //// If List Empty : Return Deafult Value [In This Example The List Return Null]
            //// Or Any Thing You Want By Using The Overload
            //Res02 = ProductList.LastOrDefault();
            //// Get The Last Element At Sequence
            //// If List Empty : Return Deafult Value [In This Example The List Return Null]
            //// Or Any Thing You Want By Using The Overload


            /////=+ Second OverLoad += 

            //Res01 = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //// First Element Match This Condition Or Return Null [Because It is A List]

            ///// And You Can Customize The Default Value

            #endregion

            #region ElementAt - Default

            //var Result = ProductList.ElementAt(0);
            ///// get The Element At index 0 -> First element 
            //Result = ProductList.ElementAt(77);
            ///// No Element At Index 77 --> Throw Execption [ System.ArgumentOutOfRangeException: Index was out of range ]

            ///// Best Case Here To Use -> ElementAtOrDefault

            //Result = ProductList.ElementAtOrDefault(77);
            ///// Here It's Safe And Return Null 
            #endregion

            #region Single

            ///// There're 3 Cases :
            /////     1. List Is Empty [To Control Use SingleOrDefault]
            /////     2. List Have Only 1 Element
            /////     3. List Have More Than 1 Element [ WIll Throw Execption In All Cases ]

            //// 1st Overload
            //var Result02 = ProductList.Single();
            ///// Single => Check If The List Have Only One Element Or Not 
            ///// ProductList Have 77 Elements So => That Will Throw Execption
            ///// Then Use The Default 

            //Result02 = ProductList.SingleOrDefault();

            //// 2st Overload

            //Result02 = ProductList.SingleOrDefault(p => p.ProductID == 1);
            ///// Check If There Is A element Matching This Condition Or Not

            ///// There's Many OverLoad 
            ///// Like : Checking If 1 Element Matching The Condition Or Not




            #endregion



            #endregion

            #region Aggregate Operators

            #region Count

            //// 1st OverLoad (ParamerterLess)
            //// To Get the Number Of Elements In Any List

            //var Result01 = ProductList.Count(); // LINQ Operator
            //Result01 = ProductList.Count; // List Property


            //// 2nd OverLoad
            ///// To Get The Number Of Elements That Matching The Condition
            ///// Taking Func of One Parameter

            //Result01 = ProductList.Count(p=>p.UnitsInStock == 0);

            #endregion

            #region Max & Min - MaxBy & MinBy

            //// var Result02 = ProductList.Max();// Throw Execption 
            //                                    // At Least One Object Must Implement IComparable
            //                                    // Product Must Be Implement InterFace IComparable


            // // Or You Dont Have To Implement The IComparable
            // // By Using The OverLoads Of Max OR Min

            // var Result02 = ProductList.Max(p => p.UnitsInStock);
            // // Will Get The Max Product Have UnitsInStock


            // var Result03 = ProductList.MaxBy(p=> p.UnitsInStock);
            // /// Will Get The Element That Have The Max UnitsInStock

            #endregion

            #region Sum - Avarage

            //var Result04 = ProductList.Sum(p => p.UnitsInStock);
            //// Will Get The Sum Of All UnitsInStock Of All Elements

            //var Result05 = ProductList.Average(p => p.UnitPrice);
            //// Get The Avarage Of UnitPrice By (Sum / Count)

            #endregion

            #region Aggregate

            //string[] Names = { "Ahmed", "Mohamed", "Ibrahim", "Ali" };

            //var Result06 = Names.Aggregate((str1, str2) => $"{str1} {str2}"); // = Ahmed Mohamed Ibrahim ALi

            /////You have a sequence of elements (like an array or list).
            /////You want to combine them into one single result.



            #endregion

            #endregion

            #region Casting Operators -Immediate Execution-

            #region To

            //// ToList() => Takes The Elements From The Given Source And Return It in A New List
            //// ToArray() => Takes The Elements From The Given Source And Return It in A New Array
            //// ToDictionary() => Takes The Elements From The Given Source And Return It in A New Dictionary
            //// ToHashSet() => Takes The Elements From The Given Source And Return It in A New Set


            //List<Product> products =  ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //// Long => The Same DataType Of Id (Primary Key)
            //// Product => The Same Element DataType
            //Dictionary<long, Product> Res02 = ProductList.Where(p => p.UnitsInStock == 0)
            //                                             .ToDictionary(p=>p.ProductID); // The PrimaryKey

            //foreach (var item in Res02)
            //    Console.WriteLine($"{item.Key} , {item.Value}");


            #endregion

            #region OfType

            ///// Used To Return The Elements Of Specific Type And Other Elements Will Be Ignored 

            //ArrayList arrayList = new ArrayList()
            //{
            //    "Ahmed",
            //    "Mohamed",
            //    "Ibrahim",
            //    true,
            //    false,
            //    1,
            //    5,
            //    9,
            //    4.5,
            //    3.9
            //};

            //dynamic Res = arrayList.OfType<string>(); // Will Take String Elements Only
            //Res = arrayList.OfType<double>(); // Will Take Double Elements Only  

            #endregion

            #endregion

            #region Generation Operators
            ///// Vaild Only With Fluent Syntax
            ///// The Only Way To Call Them Is An Static Methods From Class Enumerable

            //Enumerable.Range(1, 10);
            ///// Taking Two Paramerters (The Start , And Count)

            //Enumerable.Repeat("ahmed", 100);
            ///// Taking Two Paramerters (The Element (Any Type)  , The Count) 


            #endregion

            #region Set Operators

            //int[] arr1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int[] arr2 = {6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result01 = arr1.Union(arr2);
            //// Returns Unique Elements That Appear In Either Sequence 
            //// Without Duplication (Repeating)

            //var Result02 = arr1.Concat(arr2);
            //// Return All Elements Of The 2 Sequences 
            //// With Duplication (Repeating)

            //var Result03 = Result02.Distinct();
            //// Remove The Duplication (Repeating)


            //var Result04 = arr1.Intersect(arr2);
            //// Returns Elements Common To Both Sequences (Like AND).


            //var Result05 = arr1.Except(arr2);
            //// Returns Elements In The First Sequence That Don’t Appear In The Second One.

            //foreach ( var i in Result04)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Quentifier Operators     
            ///// Return Boolean

            //ProductList.Any();
            //// If The Sequence Constains At Least One Element Return True

            //ProductList.Any(p=> p.UnitPrice >40);
            //// If The Sequence Constains At Leaset One Element Match This Condition Return True

            //ProductList.All(p => p.UnitPrice > 0);
            //// If All Elements in Sequence Match This Condition Return True

            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(0, 100);

            //Seq01.SequenceEqual(Seq02);
            //// If All Element In First Sequence Equal The Second One Return True

            #endregion

            #region Zipping Operator

            ///// Produces A Sequance With Elements From The Two Or Three Specific Sequances

            //string[] Names = { "Ahmed", "Mohamed", "Ibrahim", "Ali" };
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //char[] Chars = { 'A', 'B', 'C', 'D', 'E' };

            //var Result = Names.Zip(Numbers,Chars);

            //foreach (var item in Result) Console.WriteLine(item);
            //// (Ahmed, 1, A)
            //// (Mohamed, 2, B)
            //// (Ibrahim, 3, C)
            //// (Ali, 4, D)

            ///// To Customize The Output

            //var Result02 = Names.Zip(Numbers,(Names,Numbers) => new {index = Numbers , Name = Names});


            //foreach (var item in Result02) Console.WriteLine(item);

            #endregion

            #region Grouping Operator

            //// Fluent Syntax
            //var Result = ProductList.GroupBy(P => P.Category);

            //// Query Syntax
            // Result = from P in ProductList
            //             group P by P.Category;

            ///// IMPORTANT NODE :
            ///// In Query Syntax The Query Ends With Select Or Group
            ///// After Using Select Or Group You Cant Use Any Operator 
            ///// Here You Have To Use into


            ////Ex : You Need To Get Products In Stock Groupped By Category That Contains More Than 10 Products
            //Result = from P in ProductList
            //         where P.UnitsInStock > 0
            //         group P by P.Category
            //         //where p.Count() > 10 Invaild
            //         into S
            //         where S.Count() > 10
            //         select S;


            //// Result => IEnumerable<IGrouping> ** Like 2D Array **
            //foreach(var Category in Result)
            //    foreach(var item in Category)
            //        Console.WriteLine(item);

            #endregion

            #region Partitioning Operators

            //ProductList.Take(10);
            ///// Take 10 Elements From First Only 

            //ProductList.TakeLast(10);
            ///// Take 10 Elements From Last Only

            ////--------------------------------------\\

            //ProductList.Skip(10);
            ///// Skip 10 Elements From First Only 

            //ProductList.SkipLast(10);
            ///// Skip 10 Elements From Last Only

            ////--------------------------------------\\

            //ProductList.TakeWhile(p => p.UnitsInStock > 1);
            ///// Will Take Element Until Return False
            ///// The Taking Will End When UnitsInStock == 0

            //ProductList.SkipWhile(p => p.UnitsInStock > 1);
            ///// Will Skip Element Until Return False
            ///// The Skipping Will End When UnitsInStock == 0


            #endregion


        }
    } 
}
