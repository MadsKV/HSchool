using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using ClassLibary.Models;

namespace ClassLibary.DTO
{
    public class SchoolForSaveDto
    {
        [Required]
        [MaxLength(50)]
        public string SchoolName { get; set; }
    }

    public class SchoolForUpdateDto : SchoolForSaveDto
    {
        public int SchoolId { get; set; }
    }

    public class SchoolDtoNoPersonInfo : SchoolForUpdateDto
    {
        // Klasen her er "kun" mdtaget for navngivningens skyld. 
        // Klassen SchoolForUpdateDto kunne selvfølgelig være anvendt
        // i stedet for !!! 
    }

    public class SchoolDto : SchoolForUpdateDto
    {
        public List<PersonDtoNoSchoolInfo> Persons { get; set; }
    }
}
