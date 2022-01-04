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
        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; }
    }

    public class CourseForUpdateDto : CourseForSaveDto
    {
        public int CourseID { get; set; }
    }

    public class CourseDtoNoPersonInfo : CourseForUpdateDto
    {
        // Klasen her er "kun" mdtaget for navngivningens skyld. 
        // Klassen CourseForUpdateDto kunne selvfølgelig være anvendt
        // i stedet for !!! 
    }

    public class CourseDto : CourseForUpdateDto
    {
        //public List<PersonDtoNoSchoolInfo> Persons { get; set; }
        public List<HTXStudentDtoNoCourseInfo> HTXStudents { get; set; }
    }
}
