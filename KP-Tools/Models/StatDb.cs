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
    /// <see cref="Models.Stat"/>
    /// </summary>
    public static class StatDb
    {
        public async static Task<Stat> GetStatById(int id, StatContext context)
        {
            Stat s = await (from stat in context.Stats
                              where stat.StatId == id
                              select stat).SingleOrDefaultAsync();

            return s;
        }
    }
}
