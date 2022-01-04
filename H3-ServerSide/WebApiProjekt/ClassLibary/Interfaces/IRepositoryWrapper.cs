using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibary.Interfaces
{
    public interface IRepositoryWrapper
    {
        ISchoolRepository SchoolRepositoryWrapper { get; }

        IEmployeeRepository EmployeeRepositoryWrapper { get; }

        IEUDStudentRepository EUDStudentRepositoryWrapper { get; }

        IHTXStudentRepository HTXStudentRepositoryWrapper { get; }
        ICourseRepository CourseRepositoryWrapper { get; }
        IPersonRepository PersonRepositoryWrapper { get; }
        IStudentRepository StudentRepositoryWrapper { get; }
        void Save();

    }
}
