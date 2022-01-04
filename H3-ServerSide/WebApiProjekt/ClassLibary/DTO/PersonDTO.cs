using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using ClassLibary.Models;

namespace ClassLibary.DTO
{
    public class PersonForSaveDto
    {
        [Required(ErrorMessage = "You should provide a First Name value.")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You should provide a Last Name value.")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public int SchoolId { get; set; }
    }

    //public class PersonForSaveWithSchoolIdDto : PersonForSaveDto
    //{
    //    public virtual int SchoolID { get; set; }
    //}

    public class PersonForUpdateDto : PersonForSaveDto
    {
        public int PersonId { get; set; }
    }

    public class PersonDtoNoSchoolInfo : PersonForUpdateDto
    {
        // Klasen her er "kun" mdtaget for navngivningens skyld. 
        // Klassen PersonForUpdateDto kunne selvfølgelig være anvendt
        // i stedet for !!! 
    }

    public class PersonDto : PersonForUpdateDto
    {
        public SchoolDtoNoPersonInfo School { get; set; }
    }
}
