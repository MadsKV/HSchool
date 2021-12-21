using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using ClassLibary.Models;

namespace ClassLibary.DTO
{
    public class CourseForSaveDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string CityName { get; set; }

        [MaxLength(200)]
        public string CityDescription { get; set; }
    }

    public class CourseForSaveWithCountryDto : CityForSaveDto
    {
        public virtual int CountryID { get; set; }
    }

    public class CourseForUpdateDto : CityForSaveWithCountryDto
    {
        public int CityId { get; set; }
    }

    public class CourseDTO : CityForUpdateDto
    {
        public CountryDtoNoCity Country { get; set; }
    }

    public class CityDtoNoCountry : CityForUpdateDto
    {

    }
}
