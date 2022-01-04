using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using ClassLibary.Models;

namespace ClassLibary.DTO
{
    public class StudentForSaveDto : PersonForSaveDto
    {
        [Required]
        public int StartEducationYear { get; set; }
    }

    public class StudentForUpdateDto : StudentForSaveDto
    {
        public int PersonId { get; set; }
    }

    public class StudentDtoNoPersonInfo : StudentForUpdateDto
    {
        // Klasen her er "kun" medtaget for navngivningens skyld. 
        // Klassen StudentForUpdateDto kunne selvfølgelig være anvendt
        // i stedet for !!! 
    }

    public class StudentDto : StudentForUpdateDto
    {
        public SchoolDtoNoPersonInfo School { get; set; }
    }
}
