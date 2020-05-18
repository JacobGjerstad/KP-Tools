using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KP_Tools.Models;
using KP_Tools.Data;

namespace KP_Tools.Controllers
{
    public class HomeController : Controller
    {

        private readonly StatContext _context;
        
        public HomeController(StatContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Weapon> result = await WeaponDb.GetAllWeapons(_context);

            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Weapon w)
        {
            if (ModelState.IsValid)
            {
                await WeaponDb.Add(w, _context);

                // TempData["Message"] = $"{w.Title} added successfully";
                return RedirectToAction("");
            }

            return View(w);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
