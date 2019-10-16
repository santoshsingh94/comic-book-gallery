using ComicBookGallery.Data;
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
        private ComicBookRepository _comicBookRepository = null;
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBook = _comicBookRepository.GetComicBooks();
            return View(comicBook);
        }

        public ActionResult Details(int? id)   //Nullable type parameter . So that if no argument passed then there should not be any error thrown.
        {
            if (id==null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);     //making strongly typed views
            
        }
    }
}