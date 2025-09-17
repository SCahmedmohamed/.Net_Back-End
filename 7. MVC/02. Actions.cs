using Microsoft.AspNetCore.Mvc;

namespace ActionReturns
{
    //[StatuesCode]
    /// 100-199 Infromational
    /// 200-299 Successful
    /// 300-399 Redirection
    /// 400-499 Client Error
    /// 500-599 Server Error

    //[ContentType]
    /// Text/html : Taking The Fromat Of Text In Html
    /// object/pdf : Download SomeThing
     
     
     
    public class EmployeeController : Controller
    {
        // Actions : public non-Static Method
        // All Actions Inherite From ActionResult
        //public ContentResult GetEmp(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Emp With Id {id}",
        //        ContentType = "Text/html",
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}
        //public RedirectResult AddEmp(int id)
        //{
        //    var redirectResult = new RedirectResult( "https://www.Google.com/" );
        //    return redirectResult;
        //}
        /// I Want To Make This 2 Functions in one 


        // You Have To Use The ParentClass As The Type --> ActionResult
        // Or Use The InterFace --> IActionResult  ***Recommened***
        public IActionResult GetEmp(int id)
        {
            if(id == 1)
            {
                return new ContentResult()
                {
                    Content = $"Get Emp With Id {id}",
                    ContentType = "Text/html",
                    StatusCode = 200
                };
            } else if(id == 2)
            {
                return new RedirectResult("https://google.com/");
                
            }
            else
            {
                return new RedirectToActionResult("GetEmp","Employee",new { id = 1});
            }
        }
        // Syntax Sugar :::
        // You Can Remove Action And It WIll Be normal Function
        public IActionResult AddEmp(int id)
        {
            if (id == 1)
            {
                return Content($"Get Emp With Id {id}", "Text/html" );
                
            }
            else if (id == 2)
            {
                return  Redirect("https://google.com/");

            }
            else
            {
                return  RedirectToAction("GetEmp", "Employee", new { id = 1 });
            }
        }

        /// You Dont Have To Write This Long Name In Url 
        /// You Can Use Attruibute
        [ActionName("EmpDetails")]
        // Now You Can Use /EmpDetails/id
        //Not /KnowDetailsOfEmployeeByHisId/id
        public ActionResult KnowDetailsOfEmployeeByHisId(int id)
        {
            return Content("Hello");
        }

    }

    // Action Parameter Binding :
    // 1. Form
    // 2. Segment
    // 3. Query Params
    // 4. Files
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapControllerRoute
                (
                name: default,
                pattern: "{controller}/{action}/{id}"
                );


            app.Run();
        }
    }
}
