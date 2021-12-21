using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibary.Models
{
    public class School
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string CityName { get; set; }

        [Required]
        [MaxLength(200)]
        public string CityDescription { get; set; }
        
        [ForeignKey("CountryID")]
        public int CountryID { get; set; }

        public virtual Employee Country { get; set; }
    }
}
