using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LMS_PROJECT.Models;

namespace LMS_PROJECT.DataAccessLayer
{
    public class DataAccessLayer_LMS:DbContext
    {
        public DataAccessLayer_LMS(DbContextOptions<DataAccessLayer_LMS>options):base(options)
        {

        }
        public DbSet<EmployeeDBModel> Employees { get; set; }
    }
}
