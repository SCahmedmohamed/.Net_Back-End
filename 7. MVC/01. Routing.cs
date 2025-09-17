using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{

    /// Now Creating Contoller Class For Movie
    /// Must Be Public
    public class EmployeeController : Controller
    {
        /// Employee is The Controller
        // Here We Write Actions : Public non-Static Methods
        
        public String GetEmp(int id)
        {
            return $"Get The Employee With id :{id}";
        }public String AddEmp(int id)
        {
            return $"Add The Employee With id :{id}";
        }

    }



    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews(); // Register The Bult-in MVC Services

            var app = builder.Build();

            // To Write Routing There're 2 Ways
            //[1]
            ///app.MapGet("/", () => "Hello World!");
            ////// https://localhost:44334/ If You Go There Will See "Hello World!"
            ///app.MapGet("/{id}", () => "WellCome");
            ////// https://localhost:44334/{AnyNumber} If You Go There Will See "Wellcome"

            //-- OR --- Recommened
            ///Use app.MapControllerRoute(); 
            /// Its Take 2 Parameters ( name: , pattern: ) 
            app.MapControllerRoute(
                name: "Deafult",
                /// NOTE : ***Case Sencetive***
                //pattern: "Controller/action/id" // Static Segment : Must Write These Words In URL
                
                pattern: "{Controller}/{action}/{id}" // Variable Segment | Paremeter Sagment :
                // You Write Word Crosses To Controller 
                // You Write Word Crosses To Action 
                // You Write Word Crosses To id
                // Like /Movie/GetMovie/50
                
                /// You Can Give Deafult Value For Controller , Action and Id
                /// pattern: "{Controller=Employee}"
                /// Or Give Them Type By Using ( : )
                /// {id:int}
                /// Or Make It Nullalbe
                /// {id?}

                );
            //[2] 
            /// You Have To Register The Bult-in MVC Services

            //[3] 
            /// Create Controller Class
            /// This Class Must End With Controller Like ( EmployeeController )
            /// Then Inherite From Class Controller


            /// Now You Can Go To URL
            /// https://localhost:44334/Employee/GetEmp/50 
            /// https://localhost:44334/Employee/AddEmp/50 

            app.Run();
        }
    }
}
