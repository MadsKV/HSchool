using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibary.Models
{
    public class Employee: Person
    {
        public int Sallery { get; set; }
    }
}
