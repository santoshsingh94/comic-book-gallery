using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller 
    {
        public ActionResult Details()
        {
            // action result type provided by Mvc.
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");     //If today is Tuesday then jump automaticaly to home page.
            }
            return Content("Hello from the comic book");          //Content result is an action result type provided by Mvc.
            
        }
    }
}