using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibary.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; }

        public virtual ICollection<HTXStudent> HTXStudents { get; set; }
        = new List<HTXStudent>();
    }
}