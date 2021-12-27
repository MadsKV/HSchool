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
        public int SchoolId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string SchoolName { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
        = new List<Person>();
    }
}
