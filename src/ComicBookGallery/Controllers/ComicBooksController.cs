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
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();
        }
    }
}