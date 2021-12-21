using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibary.Context;
using ClassLibary.Interfaces;
using ClassLibary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibary.DataManager
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DatabaseContext context) : base(context)
        {
            if (null == context)
            {
                throw new ArgumentNullException(nameof(context));
            }
            this.RepositoryContext.ChangeTracker.LazyLoadingEnabled = false;
        }
    }
}
