using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKendo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Grid()
        {
            return View();
        }

        public ActionResult GridDetail()
        {
            return View();
        }

    }
}