using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>This is a description</p>";
            ViewBag.AuthorProps = new string[] {
                "Stringy",
                "Bingy",
                "Hangry",
                "Bindy",
                "Windy"
            };
            return View();
        }
    }
}