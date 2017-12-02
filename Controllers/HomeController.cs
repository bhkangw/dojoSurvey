using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstAsp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Errors = new List<string>();
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            ViewBag.Errors = new List<string>();

            if(name == null)
            {
                ViewBag.Errors.Add("Name cannot be empty");
            }

            if(comment == null)
            {
                comment = "";
            }

            if(ViewBag.Errors.Count > 0)
            {
                // TempData["errors"] = ViewBag.Errors;
                return View("Index");
            }

            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;

            return View();
        }

    }
}