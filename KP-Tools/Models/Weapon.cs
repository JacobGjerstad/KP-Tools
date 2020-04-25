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
        /// Name of the weapon
        /// </summary>
        [MaxLength(30)]
        [Required]
        public string WeaponName { get; set; }

        /// <summary>
        /// The type of weapon (breaker/slayer)
        /// </summary>
        [MaxLength(15)]
        [Required]
        public string WeaponType { get; set; }

        /// <summary>
        /// The property of the weapon (physical/magical)
        /// </summary>
        [Required]
        [MaxLength(15)]
        public string WeaponProperty { get; set; }

        /// <summary>
        /// The total hp (hit points) the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 50000.00)]
        public double WeaponHp { get; set; }

        /// <summary>
        /// The total hp recovery the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 2000.00)]
        public double WeaponHpRecovery { get; set; }

        /// <summary>
        /// The total stamina the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 1000.00)]
        public double WeaponStamina { get; set; }

        /// <summary>
        /// The total stamina recovery the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 2000.00)]
        public double WeaponStaminaRecovery { get; set; }

        /// <summary>
        /// The total mana the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 5000.00)]
        public double WeaponMana { get; set; }

        /// <summary>
        /// The total mana recovery the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 5000.00)]
        public double WeaponManaRecovery { get; set; }

        /// <summary>
        /// The total rage generation the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 5000.00)]
        public double WeaponRageGeneration { get; set; }

        /// <summary>
        /// The total physical attack the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 5000.00)]
        public double WeaponPhysicalAttack { get; set; }

        /// <summary>
        /// The total magic attack the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponMagicAttack { get; set; }

        /// <summary>
        /// The total physical crit rate the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponPhysicalCritRate { get; set; }

        /// <summary>
        /// The total magic crit rate the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponMagicalCritRate { get; set; }

        /// <summary>
        /// The total action speed the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponActionSpeed { get; set; }

        /// <summary>
        /// The total casting speed the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponCastingSpeed { get; set; }

        /// <summary>
        /// The total movement speed the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponMovementSpeed { get; set; }

        /// <summary>
        /// The total action endurance the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponActionEndurance { get; set; }

        /// <summary>
        /// The total spell endurance the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponSpellEndurance { get; set; }

        /// <summary>
        /// The total physical defense the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponPhysicalDefense { get; set; }

        /// <summary>
        /// The total magic defense the user has with this weapon
        /// </summary>
        [Required]
        [Range(0.00, 10000.00)]
        public double WeaponMagicDefense { get; set; }

        public ICollection<StatWeapon> StatWeapons { get; set; }
    }
}
