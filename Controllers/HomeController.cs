using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ch03FirstResponsiveWebAppAmbroson.Models;

namespace Ch03FirstResponsiveWebAppAmbroson.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.Age = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstResponsiveWebAppModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Name = "";
                ViewBag.Age = 0;
            }
            return View(model);
        }
    }
}
