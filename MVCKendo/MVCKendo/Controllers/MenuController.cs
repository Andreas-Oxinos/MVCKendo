using Domain.DAL;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKendo.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult GetMenuItems()
        {
            using (var dal = new MenuDal())
            {
                var model = dal.GetMenuItems();
                return PartialView("Menu/_Menu", model);
            }
        }
    
    }
}