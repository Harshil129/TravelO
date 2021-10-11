using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelO.Models;

namespace TravelO.Controllers
{
    public class ProvincesController : Controller
    {
        public IActionResult Index()
        {
            var provinces = new List<Province>();

            for(var i=1; i<7; i++)
            {
                provinces.Add(new Province() { ProvinceID = i, Name = "Province " + i.ToString() });
            }

            return View(provinces);
        }

        //Browse the provinces
        public IActionResult Browse(String province)
        {

            if(province == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.province = province;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
