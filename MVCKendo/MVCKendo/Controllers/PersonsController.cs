using System.Net;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.DAL;
using Domain;
using Domain.ViewModels;
using Domain.Context;
using Kendo.Mvc.Extensions;

namespace MVCKendo.Controllers
{
    public class PersonsController : Controller
    {

        [HttpPost]
        public ActionResult DetailTable_Data(int id, [DataSourceRequest] DataSourceRequest request)
        {
            using (var dal = new PetsDal())
            {
                var data = dal.Get(id);
                var result = data.ToDataSourceResult(request);
                return Json(result);
            }
        }

        [HttpPost]
        public ActionResult DetailTable_Create([DataSourceRequest] DataSourceRequest request, PetVW pet, int id)
        {
            if (ModelState.IsValid)
            {
                pet.PersonId = id;
                using (var dal = new PetsDal())
                {
                    dal.Create(pet);
                }
            }
            return Json(new[] { pet }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Get_Data([DataSourceRequest]DataSourceRequest request)
        {
            using (var dal = new PersonDAL())
            {
                var data = dal.GetData();
                DataSourceResult result = data.ToDataSourceResult(request);
                return Json(result);
            }
        }

        [HttpPost]
        public ActionResult Person_Create([DataSourceRequest]DataSourceRequest request, PersonVM person)
        {
            if (ModelState.IsValid)
            {
                using (var dal = new PersonDAL())
                {
                    dal.AddData(person);
                }
            }
            return Json(new[] { person }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Person_Update([DataSourceRequest]DataSourceRequest request, PersonVM person)
        {
            if(ModelState.IsValid)
            {
                using (var dal = new PersonDAL())
                {
                    dal.EditData(person);
                }
            }
            return Json(new[] { person }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Person_Delete([DataSourceRequest]DataSourceRequest request, PersonVM person)
        {
            if (ModelState.IsValid)
            {
                using(var dal = new PersonDAL())
                {
                    dal.DeleteData(person);
                }
            }
            return Json(new[] { person }.ToDataSourceResult(request, ModelState));
        }

       
    }
}