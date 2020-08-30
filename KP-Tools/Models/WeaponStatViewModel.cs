using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Tools.Models
{
    public class WeaponStatViewModel
    {
        public Weapon ChosenWeapon1 { get; set; }

        public Weapon ChosenWeapon2 { get; set; }

        public List<Stat> SelectedStats { get; set; }

        public List<Stat> WeaponStats { get; set; }

        public List<Weapon> AllWeapons { get; set; }

        /// <summary>
        /// Creates select list to pupulate weapon dropdown
        /// </summary>
        public IEnumerable<SelectListItem> AllWeaponListItems()
        {
            return AllWeapons.Select(w => new SelectListItem()
            {
                Text = w.WeaponName,
                Value = w.WeaponId.ToString()
            });
        }

        /// <summary>
        /// Creates select list to populate stat dropdown
        /// </summary>
        public IEnumerable<SelectListItem> AllStatListItems()
        {
            return WeaponStats.Select(s => new SelectListItem()
            {
                Text = s.StatType,
                Value = s.StatId.ToString()
            });
        }
    }
}