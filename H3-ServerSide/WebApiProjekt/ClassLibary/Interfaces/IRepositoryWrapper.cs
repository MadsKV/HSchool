using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibary.Interfaces
{
    public interface IRepositoryWrapper
    {
        ICourseRepository CityRepositoryWrapper { get; }
                
        IEmployeeRepository CountryRepositoryWrapper { get; }
                
        void Save();

    }
}
