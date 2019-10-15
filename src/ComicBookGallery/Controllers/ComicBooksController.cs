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
            ViewBag.SeriesTitle = "The Amazing Spider-man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of doctor octopus life and his one, last , great act of revange!" +
                        "Even if Spider ma  n survives...<strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script:Dan Slott",
                "Pencils : Humberto Ramos",
                "Inks :Victor Olazaba",
                "Colors : Edger Delgado",
                "Letters : Chris Eliopoulos"
            };
            return View();
        }
    }
}