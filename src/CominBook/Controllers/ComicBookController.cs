using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CominBook.Controllers
{
    public class ComicBookController :Controller 

    {
        public ActionResult Detail()
        {
            

                ViewBag.Title = "Super Mario 64";
                Viewbag.Description = "Super Mario 64 is a 1996 platform video game developed and published by Nintendo for the Nintendo 64.";
                Viewbag.Characters = new string[]
                {
        "Mario",
        "Princess Peach",
        "Bowser",
        "Toad",
        "Yoshi"
                };
                return View();

        }
    }
}