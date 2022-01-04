using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using ClassLibary.Models;

namespace ClassLibary.DTO
{
    public class EUDStudentForSaveDto : StudentForSaveDto
    {
        [Required]
        public Boolean HasContract { get; set; }
    }

    public class EUDStudentForUpdateDto : EUDStudentForSaveDto
    {
        public int PersonId { get; set; }
    }

    public class EUDStudentDtoNoSchoolInfo : EUDStudentForUpdateDto
    {
        // Klasen her er "kun" medtaget for navngivningens skyld. 
        // Klassen EUDStudentForUpdateDto kunne selvfølgelig være anvendt
        // i stedet for !!! 
    }

    public class EUDStudentDto : EUDStudentForUpdateDto
    {
        public SchoolDtoNoPersonInfo School { get; set; }
    }
}
