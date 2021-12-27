using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibary.Models
{
    public class HTXStudent: Student
    {
        [ForeignKey("Course")]
        public int CourseId{ get; set; }

        public virtual Course Course { get; set; }
    }
}
