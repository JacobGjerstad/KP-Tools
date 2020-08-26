using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KP_Tools.Models;
using KP_Tools.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

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
            WeaponStatViewModel model = new WeaponStatViewModel();


            List<Stat> statResult = (from s in _context.Stats select s).ToList();
            // Get stats from DB
            model.WeaponStats = statResult; // all weapon stats
            model.AllWeapons = await WeaponDb.GetAllWeapons(_context);


            return View(model);
        }

        //[HttpGet]
        //public async Task<IActionResult> Index(WeaponStatViewModel userSelectedItems)
        //{


        //    List<Stat> statResult = (from s in _context.Stats select s).ToList();
        //    // Get stats from DB
        //    userSelectedItems.WeaponStats = statResult; // all weapon stats
        //    userSelectedItems.AllWeapons = await WeaponDb.GetAllWeapons(_context);


        //    return View(userSelectedItems);
        //}

        [HttpPost]
        //[ActionName("ApplyWeapon")]
        public async Task<IActionResult> Index(WeaponStatViewModel model, IFormCollection form)
        {
            List<Stat> statResult = (from s in _context.Stats select s).ToList();
            // Get stats from DB
            model.WeaponStats = statResult; // all weapon stats
            model.AllWeapons = await WeaponDb.GetAllWeapons(_context);

            string firstWeap = Request.Form["firstWeapon"];
            string secondWeap = Request.Form["secondWeapon"];

            if (firstWeap != null && firstWeap != "" && secondWeap != null && secondWeap != "" && firstWeap != secondWeap)
            {
                int firstWeapSelected = int.Parse(firstWeap);
                model.ChosenWeapon1 = await WeaponDb.GetWeaponById(firstWeapSelected, _context);

                int secondWeapSelected = int.Parse(secondWeap);
                model.ChosenWeapon2 = await WeaponDb.GetWeaponById(secondWeapSelected, _context);

                // ViewData["userMsg"] = model.ChosenWeapon1.WeaponName + " and " + model.ChosenWeapon2.WeaponName;
            }
            else
            {
                ViewData["userMsg"] = "Please select two different weapons before applying";
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ShowAll()
        {
            List<Weapon> weapons = await WeaponDb.GetAllWeapons(_context);

            return View(weapons);
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

                TempData["Message"] = "Weapon added successfully";
                return RedirectToAction(nameof(ShowAll));
            }

            return View(w);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Weapon w = await WeaponDb.GetWeaponById(id, _context);

            if(w == null)
            {
                return NotFound();
            }

            return View(w);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Weapon w)
        {
            if (ModelState.IsValid)
            {
                await WeaponDb.Edit(w, _context);
                TempData["Message"] = w.WeaponName + " updated successfully";
                return RedirectToAction(nameof(ShowAll));
            }

            return View(w);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Weapon w = await WeaponDb.GetWeaponById(id, _context);

            if(w == null)
            {
                return NotFound();
            }

            return View(w);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await WeaponDb.Delete(id, _context);
            TempData["Message"] = "Weapon deleted successfully";
            return RedirectToAction(nameof(ShowAll));
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
