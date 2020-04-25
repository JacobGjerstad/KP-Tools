using KP_Tools.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Tools.Data
{
    public class StatContext : DbContext
    {
        public StatContext(DbContextOptions<StatContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatWeapon>().HasKey(sw => new { sw.StatId, sw.WeaponId });
            modelBuilder.Entity<StatWeapon>().HasOne(sw => sw.Stat)
                                             .WithMany(s => s.StatWeapons)
                                             .HasForeignKey(sw => sw.StatId);
            modelBuilder.Entity<StatWeapon>().HasOne(sw => sw.Weapon)
                                             .WithMany(w => w.StatWeapons)
                                             .HasForeignKey(sw => sw.WeaponId);
        }

        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<Stat> Stats { get; set; }

        public DbSet<StatWeapon> StatWeapons { get; set; }
    }
}
