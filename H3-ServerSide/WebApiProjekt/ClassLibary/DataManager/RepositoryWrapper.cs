using ClassLibary.Context;
using ClassLibary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibary.DataManager
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private DatabaseContext _repoContext;

        private ICourseRepository _cityRepositoryWrapper;
        private IEmployeeRepository _countryRepositoryWrapper;

        public RepositoryWrapper(DatabaseContext repositoryContext)
        {
            this._repoContext = repositoryContext;
        }

        public ICourseRepository CityRepositoryWrapper
        {
            get
            {
                if (null == _cityRepositoryWrapper)
                {
                    _cityRepositoryWrapper = new CourseRepository(_repoContext);
                }

                return (_cityRepositoryWrapper);
            }
        }
                
        public IEmployeeRepository CountryRepositoryWrapper
        {
            get
            {
                if (null == _countryRepositoryWrapper)
                {
                    _countryRepositoryWrapper = new EmployeeRepository(_repoContext);
                }

                return (_countryRepositoryWrapper);
            }
        }
                                
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
