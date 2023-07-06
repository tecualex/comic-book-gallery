using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek==DayOfWeek.Friday)
            {
                return Redirect("/");
            }
            return Content("Heloo here!!");
        }
    }
}
