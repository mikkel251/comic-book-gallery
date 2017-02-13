using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The amazing spider-man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "Lorem ipsum dolor sit amet,sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat,  At vero eos et accusam et justo duo dolores et ea rebum.  Lorem ipsum dolor sit amet,  no sea takimata sanctus est Lorem ipsum dolor sit amet.  Stet clita kasd gubergren,  no sea takimata sanctus est Lorem ipsum dolor sit amet.  no sea takimata sanctus est Lorem ipsum dolor sit amet.  no sea takimata sanctus est Lorem ipsum dolor sit amet.  sed diam voluptua. ";
            ViewBag.Artist = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors:Edgar Delgardo",
                "Letters: Chris Eliopoulos"
            };



            return View();
        }
    }
}