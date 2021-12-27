using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibary.Models
{
    public class Student: Person
    {
        public int StartEducationYear { get; set; }
    }
}
