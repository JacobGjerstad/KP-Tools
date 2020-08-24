using System;
using System.Collections.Generic;

namespace KP_Tools.Models
{
    public class WeaponStatViewModel
    {
        public Weapon ChosenWeapon1 { get; set; }

        public Weapon ChosenWeapon2 { get; set; }

        public List<Stat> SelectedStats { get; set; }

        public List<Stat> WeaponStats { get; set; }

        public List<Weapon> AllWeapons { get; set; }
    }
}