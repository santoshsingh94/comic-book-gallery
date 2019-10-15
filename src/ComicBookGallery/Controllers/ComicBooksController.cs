using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of doctor octopus life and his one, last , great act of revange!" +
                        "Even if Spider ma  n survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {                   
                    new Artist(){Name ="Dan Slott",Role="Script"},
                    new Artist(){Name ="Humberto Ramos",Role="Pencils"},
                    new Artist(){Name ="Victor Olazaba",Role="Inks"},
                    new Artist(){Name ="Edger Delgado",Role="Colors"},
                    new Artist(){Name ="Chris Eliopoulos",Role="Letters"},
                }
            };
            return View(comicBook);     //making strongly typed views
        }
    }
}