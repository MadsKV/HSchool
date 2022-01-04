using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibary.DTO
{
    public class EmployeeForSaveDto : PersonForSaveDto
    {
        [Required]
        public int Salary { get; set; }
    }

    public class EmployeeForUpdateDto : EmployeeForSaveDto
    {
        public int PersonId { get; set; }
    }

    public class EmployeeDtoNoPersonInfo : EmployeeForUpdateDto
    {
        // Klasen her er "kun" medtaget for navngivningens skyld. 
        // Klassen EmployeeForUpdateDto kunne selvfølgelig være anvendt
        // i stedet for !!! 
    }

    public class EmployeeDto : EmployeeForUpdateDto
    {
        public SchoolDtoNoPersonInfo School { get; set; }
    }
}
