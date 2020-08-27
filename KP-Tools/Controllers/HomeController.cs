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
            ViewData["userMsg"] = "Apply button applies both weapons and all selected stats.";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(WeaponStatViewModel model, IFormCollection form)
        {
            List<Stat> statResult = (from s in _context.Stats select s).ToList();
            // Get stats from DB
            model.WeaponStats = statResult; // all weapon stats
            model.AllWeapons = await WeaponDb.GetAllWeapons(_context);

            string firstWeap = Request.Form["firstWeapon"];
            string secondWeap = Request.Form["secondWeapon"];
            model.SelectedStats = await getSelectedStats(form);

            if (firstWeap != null && firstWeap != "" && secondWeap != null && secondWeap != "" && firstWeap != secondWeap)
            {
                int firstWeapSelected = int.Parse(firstWeap);
                model.ChosenWeapon1 = await WeaponDb.GetWeaponById(firstWeapSelected, _context);

                int secondWeapSelected = int.Parse(secondWeap);
                model.ChosenWeapon2 = await WeaponDb.GetWeaponById(secondWeapSelected, _context);

                if (model.SelectedStats.Count() != 0)
                {
                    model.ChosenWeapon1 = addSelectedStats(model.SelectedStats, model.ChosenWeapon1);
                    model.ChosenWeapon2 = addSelectedStats(model.SelectedStats, model.ChosenWeapon2);
                }

                // ViewData["userMsg"] = model.ChosenWeapon1.WeaponName + " and " + model.ChosenWeapon2.WeaponName;
            }
            else
            {
                ViewData["userMsg"] = "Please select two different weapons before applying";
            }

            return View(model);
        }

        private Weapon addSelectedStats(List<Stat> selectedStats, Weapon chosenWeapon)
        {
            Weapon userWeap = chosenWeapon;

            foreach (Stat stat in selectedStats)
            {
                int currStat = stat.StatId;
                switch (currStat)
                {
                    case 1:
                        userWeap.WeaponPhysicalCritRate += stat.StatValue;
                        break;
                    case 2:
                        userWeap.WeaponRageGeneration += stat.StatValue;
                        break;
                    case 3:
                        userWeap.WeaponManaRecovery += stat.StatValue;
                        break;
                    case 4:
                        userWeap.WeaponMana += stat.StatValue;
                        break;
                    case 5:
                        userWeap.WeaponStaminaRecovery += stat.StatValue;
                        break;
                    case 6:
                        userWeap.WeaponStamina += stat.StatValue;
                        break;
                    case 7:
                        userWeap.WeaponHpRecovery += stat.StatValue;
                        break;
                    case 8:
                        userWeap.WeaponHp += stat.StatValue;
                        break;
                    case 9:
                        userWeap.WeaponMagicalCritRate += stat.StatValue;
                        break;
                    case 10:
                        userWeap.WeaponActionSpeed += stat.StatValue;
                        break;
                    case 11:
                        userWeap.WeaponCastingSpeed += stat.StatValue;
                        break;
                    case 12:
                        userWeap.WeaponMovementSpeed += stat.StatValue;
                        break;
                    default:
                        break;
                }
            }
            return userWeap;
        }

        private async Task<List<Stat>> getSelectedStats(IFormCollection form)
        {
            string firstWeapSkinStat = Request.Form["weaponSkinStatOne"];
            string secondWeapSkinStat = Request.Form["weaponSkinStatTwo"];
            string firstTopPieceStat = Request.Form["topPieceStatOne"];
            string secondTopPieceStat = Request.Form["topPieceStatTwo"];
            string firstBottomPieceStat = Request.Form["bottomPieceStatOne"];
            string secondBottomPieceStat = Request.Form["bottomPieceStatTwo"];
            string firstUndergarmentStat = Request.Form["undergarmentsStatOne"];
            string secondUndergarmentStat = Request.Form["undergarmentsStatTwo"];
            string firstRightHandStat = Request.Form["rightHandStatOne"];
            string secondRightHandStat = Request.Form["rightHandStatTwo"];
            string firstLeftHandStat = Request.Form["leftHandStatOne"];
            string secondLeftHandStat = Request.Form["leftHandStatTwo"];
            string firstShoesStat = Request.Form["shoesStatOne"];
            string secondShoesStat = Request.Form["shoesStatTwo"];
            string firstHairTopStat = Request.Form["hairTopStatOne"];
            string secondHairTopStat = Request.Form["hairTopStatTwo"];
            string firstHairBottomStat = Request.Form["hairBottomStatOne"];
            string secondHairBottomStat = Request.Form["hairBottomStatTwo"];
            string firstFaceTopStat = Request.Form["faceTopStatOne"];
            string secondFaceTopStat = Request.Form["faceTopStatTwo"];
            string firstFaceBottomStat = Request.Form["faceBottomStatOne"];
            string secondFaceBottomStat = Request.Form["faceBottomStatTwo"];
            string firstNeckStat = Request.Form["neckStatOne"];
            string secondNeckStat = Request.Form["neckStatTwo"];
            string firstBackStat = Request.Form["backStatOne"];
            string secondBackStat = Request.Form["backStatTwo"];
            string firstBeltStat = Request.Form["beltStatOne"];
            string secondBeltStat = Request.Form["beltStatTwo"];

            var userStats = new List<string>() 
            {
                firstWeapSkinStat,
                secondWeapSkinStat,
                firstTopPieceStat,
                secondTopPieceStat,
                firstBottomPieceStat,
                secondBottomPieceStat,
                firstUndergarmentStat,
                secondUndergarmentStat,
                firstRightHandStat,
                secondRightHandStat,
                firstLeftHandStat,
                secondLeftHandStat,
                firstShoesStat,
                secondShoesStat,
                firstHairTopStat,
                secondHairTopStat,
                firstHairBottomStat,
                secondHairBottomStat,
                firstFaceTopStat,
                secondFaceTopStat,
                firstFaceBottomStat,
                secondFaceBottomStat,
                firstNeckStat,
                secondNeckStat,
                firstBackStat,
                secondBackStat,
                firstBeltStat,
                secondBeltStat
            };
            var userStatValues = new List<int>();
            var selectedStats = new List<Stat>();

            foreach (string stat in userStats)
            {
                int statVal = isStatSelected(stat);
                userStatValues.Add(statVal);
            }

            foreach (int stat in userStatValues)
            {
                if(stat != 0)
                {
                    Stat userStat = await StatDb.GetStatById(stat, _context);
                    selectedStats.Add(userStat);
                }
            }

            return selectedStats;
        }
        public int isStatSelected(string userSelectedStat)
        {
            if (userSelectedStat != null && userSelectedStat != "")
            {
                int statSelected = int.Parse(userSelectedStat);
                return statSelected;
            }
            return 0;
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
