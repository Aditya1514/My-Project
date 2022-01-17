using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Models
{
    public class CustomBlinder :IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext modelBindingContext)
        {
            int StudentId = Convert.ToInt32  (controllerContext.HttpContext.Request.Form["StudentId"]);
            string StudentName = controllerContext.HttpContext.Request.Form["StudentName"];
            string Doorno = controllerContext.HttpContext.Request.Form["Doorno"];
            string street = controllerContext.HttpContext.Request.Form["street"];
            string City = controllerContext.HttpContext.Request.Form["City"];

            return new Student()
            {
                StudentId = StudentId,
                StudentName = StudentName,
                StudentAddress = Doorno + "," + street + "," + City
            };

        }
    }
}