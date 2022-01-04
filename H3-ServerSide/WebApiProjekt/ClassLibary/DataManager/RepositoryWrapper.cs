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

        private ISchoolRepository _schoolRepositoryWrapper;

        private IEmployeeRepository _employeeRepositoryWrapper;

        private IEUDStudentRepository _eUDStudentRepositoryWrapper;

        private IHTXStudentRepository _hTXStudentRepositoryWrapper;
        private ICourseRepository _courseRepositoryWrapper;
        private IPersonRepository _personRepositoryWrapper;
        private IStudentRepository _studentRepositoryWrapper;

        public RepositoryWrapper(DatabaseContext repositoryContext)
        {
            this._repoContext = repositoryContext;
        }

        public ISchoolRepository SchoolRepositoryWrapper
        {
            get
            {
                if (null == _schoolRepositoryWrapper)
                {
                    _schoolRepositoryWrapper = new SchoolRepository(_repoContext);
                }

                return (_schoolRepositoryWrapper);
            }
        }

        public IEmployeeRepository EmployeeRepositoryWrapper
        {
            get
            {
                if (null == _employeeRepositoryWrapper)
                {
                    _employeeRepositoryWrapper = new EmployeeRepository(_repoContext);
                }

                return (_employeeRepositoryWrapper);
            }
        }

        public IEUDStudentRepository EUDStudentRepositoryWrapper
        {
            get
            {
                if (null == _eUDStudentRepositoryWrapper)
                {
                    _eUDStudentRepositoryWrapper = new EUDStudentRepository(_repoContext);
                }

                return (_eUDStudentRepositoryWrapper);
            }
        }

        public IHTXStudentRepository HTXStudentRepositoryWrapper
        {
            get
            {
                if (null == _hTXStudentRepositoryWrapper)
                {
                    _hTXStudentRepositoryWrapper = new HTXStudentRepository(_repoContext);
                }

                return (_hTXStudentRepositoryWrapper);
            }
        }

        public ICourseRepository CourseRepositoryWrapper
        {
            get
            {
                if (null == _courseRepositoryWrapper)
                {
                    _courseRepositoryWrapper = new CourseRepository(_repoContext);
                }

                return (_courseRepositoryWrapper);
            }
        }

        public IPersonRepository PersonRepositoryWrapper
        {
            get
            {
                if (null == _personRepositoryWrapper)
                {
                    _personRepositoryWrapper = new PersonRepository(_repoContext);
                }

                return (_personRepositoryWrapper);
            }
        }

        public IStudentRepository StudentRepositoryWrapper
        {
            get
            {
                if (null == _studentRepositoryWrapper)
                {
                    _studentRepositoryWrapper = new StudentRepository(_repoContext);
                }

                return (_studentRepositoryWrapper);
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
