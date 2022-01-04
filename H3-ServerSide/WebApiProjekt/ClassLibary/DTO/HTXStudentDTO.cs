using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using ClassLibary.Models;

namespace ClassLibary.DTO
{
    public class HTXStudentForSaveDto : StudentForSaveDto
    {
        [Required]
        public int CourseId { get; set; }
    }

    public class HTXStudentForUpdateDto : HTXStudentForSaveDto
    {
        public int PersonId { get; set; }
    }

    public class HTXStudentDtoNoSchoolInfo : HTXStudentForUpdateDto
    {
        // Klasen her er "kun" medtaget for navngivningens skyld. 
        // Klassen HTXStudentForUpdateDto kunne selvfølgelig være anvendt
        // i stedet for !!! 
    }

    public class HTXStudentDtoNoCourseInfo : HTXStudentForUpdateDto
    {
        public SchoolDtoNoPersonInfo School { get; set; }
    }

    public class HTXStudentDto : HTXStudentForUpdateDto
    {
        public SchoolDtoNoPersonInfo School { get; set; }
        public CourseDtoNoPersonInfo Course { get; set; }
    }
}
