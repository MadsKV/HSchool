using ClassLibary.Context;
using ClassLibary.DataManager;
using ClassLibary.Interfaces;
using ClassLibary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibary.DataManager
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        private readonly DatabaseContext _context;

        public EmployeeRepository(DatabaseContext context) : base(context)
        {
            if (null == context)
            {
                throw new ArgumentNullException(nameof(context));
            }
            this.RepositoryContext.ChangeTracker.LazyLoadingEnabled = false;
        }
    }
}
