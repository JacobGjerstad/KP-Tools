using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Tools.Models
{
    public class StatWeapon
    {
        public int StatId { get; set; }

        public Stat Stat { get; set; }

        public int WeaponId { get; set; }

        public Weapon Weapon { get; set; }
    }
}
