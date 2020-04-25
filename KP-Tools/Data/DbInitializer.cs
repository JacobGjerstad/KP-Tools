using KP_Tools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Tools.Data
{
    public class DbInitializer
    {
        public static void Initialize(StatContext context)
        {
            context.Database.EnsureCreated();

            if (context.Weapons.Any())
            {
                return;
            }

            var weapons = new Weapon[]
            {
                new Weapon{WeaponType="Breaker", WeaponProperty="Physical", WeaponHp=18000, WeaponHpRecovery=720, WeaponStamina=175, WeaponStaminaRecovery=24.0, WeaponMana=250, WeaponManaRecovery=2.50, WeaponRageGeneration=12.5, WeaponPhysicalAttack=506, WeaponMagicAttack=0, WeaponPhysicalCritRate=25.00, WeaponMagicalCritRate=17.50, WeaponActionSpeed=100.00, WeaponCastingSpeed=87.50, WeaponMovementSpeed=120.0, WeaponActionEndurance=395.71, WeaponSpellEndurance=278.57, WeaponPhysicalDefense=46.25, WeaponMagicDefense=33.75, WeaponName="Sword"},
                new Weapon{WeaponType="Slayer", WeaponProperty="Magical", WeaponHp=18000, WeaponHpRecovery=840, WeaponStamina=150, WeaponStaminaRecovery=13.5, WeaponMana=375, WeaponManaRecovery=4.00, WeaponRageGeneration=12.5, WeaponPhysicalAttack=0, WeaponMagicAttack=807, WeaponPhysicalCritRate=21.25, WeaponMagicalCritRate=32.50, WeaponActionSpeed=93.75, WeaponCastingSpeed=112.50, WeaponMovementSpeed=95.0, WeaponActionEndurance=104.28, WeaponSpellEndurance=278.57, WeaponPhysicalDefense=22.91, WeaponMagicDefense=31.25, WeaponName="Staff"},
                new Weapon{WeaponType="Slayer", WeaponProperty="Physical", WeaponHp=18000, WeaponHpRecovery=840, WeaponStamina=162, WeaponStaminaRecovery=16.5, WeaponMana=275, WeaponManaRecovery=3.00, WeaponRageGeneration=12.5, WeaponPhysicalAttack=712, WeaponMagicAttack=0, WeaponPhysicalCritRate=42.50, WeaponMagicalCritRate=17.50, WeaponActionSpeed=112.50, WeaponCastingSpeed=87.50, WeaponMovementSpeed=115.0, WeaponActionEndurance=118.57, WeaponSpellEndurance=164.28, WeaponPhysicalDefense=31.25, WeaponMagicDefense=29.16, WeaponName="Bow"},
                new Weapon{WeaponType="Slayer", WeaponProperty="Physical", WeaponHp=18000, WeaponHpRecovery=720, WeaponStamina=150, WeaponStaminaRecovery=18.0, WeaponMana=250, WeaponManaRecovery=2.50, WeaponRageGeneration=12.5, WeaponPhysicalAttack=706, WeaponMagicAttack=0, WeaponPhysicalCritRate=42.50, WeaponMagicalCritRate=17.50, WeaponActionSpeed=112.50, WeaponCastingSpeed=87.50, WeaponMovementSpeed=125.5, WeaponActionEndurance=125.71, WeaponSpellEndurance=125.71, WeaponPhysicalDefense=30.83, WeaponMagicDefense=26.66, WeaponName="Dual Sword"},
                new Weapon{WeaponType="Breaker", WeaponProperty="Physical", WeaponHp=18000, WeaponHpRecovery=720, WeaponStamina=162, WeaponStaminaRecovery=21.0, WeaponMana=250, WeaponManaRecovery=2.50, WeaponRageGeneration=12.5, WeaponPhysicalAttack=475, WeaponMagicAttack=0, WeaponPhysicalCritRate=35.75, WeaponMagicalCritRate=17.50, WeaponActionSpeed=106.25, WeaponCastingSpeed=87.50, WeaponMovementSpeed=125.00, WeaponActionEndurance=350.00, WeaponSpellEndurance=350.00, WeaponPhysicalDefense=46.25, WeaponMagicDefense=36.87, WeaponName="Fist"},
                new Weapon{WeaponType="Breaker", WeaponProperty="Magical", WeaponHp=18000, WeaponHpRecovery=960, WeaponStamina=175, WeaponStaminaRecovery=15.0, WeaponMana=350, WeaponManaRecovery=4.00, WeaponRageGeneration=12.5, WeaponPhysicalAttack=0, WeaponMagicAttack=506, WeaponPhysicalCritRate=25.00, WeaponMagicalCritRate=25.00, WeaponActionSpeed=100.00, WeaponCastingSpeed=100.00, WeaponMovementSpeed=100.0, WeaponActionEndurance=278.57, WeaponSpellEndurance=278.57, WeaponPhysicalDefense=41.25, WeaponMagicDefense=47.50, WeaponName="Hammer"},
                new Weapon{WeaponType="Slayer", WeaponProperty="Magical", WeaponHp=18000, WeaponHpRecovery=840, WeaponStamina=150, WeaponStaminaRecovery=15.5, WeaponMana=350, WeaponManaRecovery=3.75, WeaponRageGeneration=12.5, WeaponPhysicalAttack=0, WeaponMagicAttack=712, WeaponPhysicalCritRate=25.00, WeaponMagicalCritRate=28.75, WeaponActionSpeed=100.00, WeaponCastingSpeed=106.25, WeaponMovementSpeed=100.0, WeaponActionEndurance=104.28, WeaponSpellEndurance=104.28, WeaponPhysicalDefense=25.00, WeaponMagicDefense=31.25, WeaponName="Cannon"},
                new Weapon{WeaponType="Breaker", WeaponProperty="Magical", WeaponHp=18000, WeaponHpRecovery=840, WeaponStamina=150, WeaponStaminaRecovery=13.5, WeaponMana=350, WeaponManaRecovery=3.75, WeaponRageGeneration=12.5, WeaponPhysicalAttack=0, WeaponMagicAttack=475, WeaponPhysicalCritRate=25.00, WeaponMagicalCritRate=28.75, WeaponActionSpeed=100.00, WeaponCastingSpeed=106.25, WeaponMovementSpeed=100.0, WeaponActionEndurance=260.71, WeaponSpellEndurance=377.85, WeaponPhysicalDefense=37.50, WeaponMagicDefense=46.87, WeaponName="Scythe"}
            };
            foreach(Weapon w in weapons)
            {
                context.Weapons.Add(w);
            }
            context.SaveChanges();

            var stats = new Stat[]
            {
                new Stat{StatType="Max HP", StatValue=500},
                new Stat{StatType="HP Recovery", StatValue=2.0},
                new Stat{StatType="Max Stamina", StatValue=2.0},
                new Stat{StatType="Stamina Recovery", StatValue=1.0},
                new Stat{StatType="Max Mana", StatValue=2.0},
                new Stat{StatType="Mana Recovery", StatValue=1.0},
                new Stat{StatType="Rage Generation", StatValue=1.0},
                new Stat{StatType="Physical Crit Rate", StatValue=1.5},
                new Stat{StatType="Magical Crit Rate", StatValue=1.5},
                new Stat{StatType="Action Speed", StatValue=1.0},
                new Stat{StatType="Casting Speed", StatValue=1.0},
                new Stat{StatType="Movement Speed", StatValue=2.0}
            };
            foreach (Stat s in stats)
            {
                context.Stats.Add(s);
            }
            context.SaveChanges();

            var statweapons = new StatWeapon[]
            {
                new StatWeapon{WeaponId=1, StatId=1}, new StatWeapon{WeaponId=1, StatId=2}, new StatWeapon{WeaponId=1, StatId=3}, new StatWeapon{WeaponId=1, StatId=4},new StatWeapon{WeaponId=1, StatId=5},new StatWeapon{WeaponId=1, StatId=6},new StatWeapon{WeaponId=1, StatId=7},new StatWeapon{WeaponId=1, StatId=8},new StatWeapon{WeaponId=1, StatId=9},new StatWeapon{WeaponId=1, StatId=10},new StatWeapon{WeaponId=1, StatId=11},new StatWeapon{WeaponId=1, StatId=12},
                new StatWeapon{WeaponId=2, StatId=1}, new StatWeapon{WeaponId=2, StatId=2}, new StatWeapon{WeaponId=2, StatId=3}, new StatWeapon{WeaponId=2, StatId=4},new StatWeapon{WeaponId=2, StatId=5},new StatWeapon{WeaponId=2, StatId=6},new StatWeapon{WeaponId=2, StatId=7},new StatWeapon{WeaponId=2, StatId=8},new StatWeapon{WeaponId=2, StatId=9},new StatWeapon{WeaponId=2, StatId=10},new StatWeapon{WeaponId=2, StatId=11},new StatWeapon{WeaponId=2, StatId=12},
                new StatWeapon{WeaponId=3, StatId=1}, new StatWeapon{WeaponId=3, StatId=2}, new StatWeapon{WeaponId=3, StatId=3}, new StatWeapon{WeaponId=3, StatId=4},new StatWeapon{WeaponId=3, StatId=5},new StatWeapon{WeaponId=3, StatId=6},new StatWeapon{WeaponId=3, StatId=7},new StatWeapon{WeaponId=3, StatId=8},new StatWeapon{WeaponId=3, StatId=9},new StatWeapon{WeaponId=3, StatId=10},new StatWeapon{WeaponId=3, StatId=11},new StatWeapon{WeaponId=3, StatId=12},
                new StatWeapon{WeaponId=4, StatId=1}, new StatWeapon{WeaponId=4, StatId=2}, new StatWeapon{WeaponId=4, StatId=3}, new StatWeapon{WeaponId=4, StatId=4},new StatWeapon{WeaponId=4, StatId=5},new StatWeapon{WeaponId=4, StatId=6},new StatWeapon{WeaponId=4, StatId=7},new StatWeapon{WeaponId=4, StatId=8},new StatWeapon{WeaponId=4, StatId=9},new StatWeapon{WeaponId=4, StatId=10},new StatWeapon{WeaponId=4, StatId=11},new StatWeapon{WeaponId=4, StatId=12},
                new StatWeapon{WeaponId=5, StatId=1}, new StatWeapon{WeaponId=5, StatId=2}, new StatWeapon{WeaponId=5, StatId=3}, new StatWeapon{WeaponId=5, StatId=4},new StatWeapon{WeaponId=5, StatId=5},new StatWeapon{WeaponId=5, StatId=6},new StatWeapon{WeaponId=5, StatId=7},new StatWeapon{WeaponId=5, StatId=8},new StatWeapon{WeaponId=5, StatId=9},new StatWeapon{WeaponId=5, StatId=10},new StatWeapon{WeaponId=5, StatId=11},new StatWeapon{WeaponId=5, StatId=12},
                new StatWeapon{WeaponId=6, StatId=1}, new StatWeapon{WeaponId=6, StatId=2}, new StatWeapon{WeaponId=6, StatId=3}, new StatWeapon{WeaponId=6, StatId=4},new StatWeapon{WeaponId=6, StatId=5},new StatWeapon{WeaponId=6, StatId=6},new StatWeapon{WeaponId=6, StatId=7},new StatWeapon{WeaponId=6, StatId=8},new StatWeapon{WeaponId=6, StatId=9},new StatWeapon{WeaponId=6, StatId=10},new StatWeapon{WeaponId=6, StatId=11},new StatWeapon{WeaponId=6, StatId=12},
            };
            foreach (StatWeapon sw in statweapons)
            {
                context.StatWeapons.Add(sw);
            }
            context.SaveChanges();
        }
    }
}
