using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Sider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the best.</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
        }
    }
}
