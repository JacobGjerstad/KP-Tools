using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Tools.Models
{
    /// <summary>
    /// Single stat with stat value
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// Unique stat id
        /// </summary>
        [Key]
        public int StatId { get; set; }

        /// <summary>
        /// The type of stat (Max HP, Max stamina, etc)
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string StatType { get; set; }

        /// <summary>
        /// The value that the stat gives
        /// </summary>
        [Required]
        [Range(0.00, 1000.00)]
        public double StatValue { get; set; }

        public ICollection<StatWeapon> StatWeapons { get; set; }
    }
}
