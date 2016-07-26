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
        public ResultAction Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");

            }
            return content("Hello this is the Comic BookStore");

        }
    }
}