using KevsKitchen.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KevsKitchen.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            //var name = HttpContext.Request.QueryString["name"];
            var model = new GreetingViewModel
            {
                Name = name ?? "no name",
                Message = ConfigurationManager.AppSettings["message"]
            };
            return View(model);
        }
    }
}