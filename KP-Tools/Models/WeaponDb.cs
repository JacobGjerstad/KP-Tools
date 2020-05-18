using KP_Tools.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Tools.Models
{
    /// <summary>
    /// Contains DB helper methods for
    /// <see cref="Models.Weapon"/>
    /// </summary>
    public class WeaponDb
    {
        public async static Task<List<Weapon>> GetAllWeapons(StatContext context)
        {
            List<Weapon> weapons = await context.Weapons
                                          .OrderBy(w => w.WeaponId)
                                          .ToListAsync();
            return weapons;
        }
    }
}
