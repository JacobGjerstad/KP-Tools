using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Tools.Models
{
    /// <summary>
    /// Represents a single weapon
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// Unique id for the weapon
        /// </summary>
        [Key]
        public int WeaponId { get; set; }

        /// <summary>
        /// The type of weapon (breaker/slayer)
        /// </summary>
        public string WeaponType { get; set; }

        /// <summary>
        /// The property of the weapon (physical/magical)
        /// </summary>
        public string WeaponProperty { get; set; }

        /// <summary>
        /// The total hp (hit points) the user has with this weapon
        /// </summary>
        public int WeaponHp { get; set; }

        /// <summary>
        /// The total hp recovery the user has with this weapon
        /// </summary>
        public int WeaponHpRecovery { get; set; }

        /// <summary>
        /// The total stamina the user has with this weapon
        /// </summary>
        public int WeaponStamina { get; set; }

        /// <summary>
        /// The total stamina recovery the user has with this weapon
        /// </summary>
        public int WeaponStaminaRecovery { get; set; }

        /// <summary>
        /// The total mana the user has with this weapon
        /// </summary>
        public int WeaponMana { get; set; }

        /// <summary>
        /// The total mana recovery the user has with this weapon
        /// </summary>
        public int WeaponManaRecovery { get; set; }

        /// <summary>
        /// The total rage generation the user has with this weapon
        /// </summary>
        public int WeaponRageGeneration { get; set; }

        /// <summary>
        /// The total physical attack the user has with this weapon
        /// </summary>
        public int WeaponPhysicalAttack { get; set; }

        /// <summary>
        /// The total magic attack the user has with this weapon
        /// </summary>
        public int WeaponMagicAttack { get; set; }

        /// <summary>
        /// The total physical crit rate the user has with this weapon
        /// </summary>
        public int WeaponPhysicalCritRate { get; set; }

        /// <summary>
        /// The total magic crit rate the user has with this weapon
        /// </summary>
        public int WeaponMagicalCritRate { get; set; }

        /// <summary>
        /// The total action speed the user has with this weapon
        /// </summary>
        public int WeaponActionSpeed { get; set; }

        /// <summary>
        /// The total casting speed the user has with this weapon
        /// </summary>
        public int WeaponCastingSpeed { get; set; }

        /// <summary>
        /// The total movement speed the user has with this weapon
        /// </summary>
        public int WeaponMovementSpeed { get; set; }

        /// <summary>
        /// The total action endurance the user has with this weapon
        /// </summary>
        public int WeaponActionEndurance { get; set; }

        /// <summary>
        /// The total spell endurance the user has with this weapon
        /// </summary>
        public int WeaponSpellEndurance { get; set; }

        /// <summary>
        /// The total physical defense the user has with this weapon
        /// </summary>
        public int WeaponPhysicalDefense { get; set; }

        /// <summary>
        /// The total magic defense the user has with this weapon
        /// </summary>
        public int WeaponMagicDefense { get; set; }

    }
}
