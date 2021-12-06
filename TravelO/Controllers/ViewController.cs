using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelO.Data;

namespace TravelO.Controllers
{
    public class ViewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewController(ApplicationDbContext context)
        {
            _context = context; //assign incoming db connection so we can use it in any method in this controller
        }
        public IActionResult Index()
        {
            var provinces = _context.Provinces.OrderBy(p => p.Name).ToList();
            return View(provinces);
        }

        //GET: /View/ViewByProvince/5
        public IActionResult ViewByProvince(int id)
        {
            //get places in selected provinces
            var places = _context.Places.Where(p => p.ProvinceID == id)
                .OrderBy(p => p.Name).ToList();
            

            // get name of selected category
            var province = _context.Provinces.Find(id);
            ViewBag.Province = province.Name;

            return View(places);
        }

    }
}
