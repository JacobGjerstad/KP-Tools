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
    public static class WeaponDb
    {
        public async static Task<List<Weapon>> GetAllWeapons(StatContext context)
        {
            List<Weapon> weapons = await context.Weapons
                                          .OrderBy(w => w.WeaponId)
                                          .ToListAsync();
            return weapons;
        }

        public async static Task<Weapon> Add(Weapon w, StatContext context)
        {
            await context.AddAsync(w);
            await context.SaveChangesAsync();

            return w;
        }

        public async static Task<Weapon> Edit(Weapon w, StatContext context)
        {
            await context.AddAsync(w);
            context.Entry(w).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return w;
        }

        /// <summary>
        /// Returns a single weapon or null if no match
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        public async static Task<Weapon> GetWeaponById(int id, StatContext context)
        {
            Weapon w = await (from weapon in context.Weapons
                              where weapon.WeaponId == id
                              select weapon).SingleOrDefaultAsync();

            return w;
        }

        public async static Task<Weapon> GetWeaponByName(string name, StatContext context)
        {
            Weapon w = await (from weapon in context.Weapons
                              where weapon.WeaponName == name
                              select weapon).SingleOrDefaultAsync();

            return w;
        }

        public async static Task Delete(int id, StatContext context)
        {
            Weapon w = await GetWeaponById(id, context);

            if(w != null)
            {
                await context.AddAsync(w);
                context.Entry(w).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }
    }
}
