using LMS_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_PROJECT.DataAccessLayer;
using AutoMapper;

namespace LMS_PROJECT.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        

        public EmployeeRepo (DataAccessLayer_LMS dataAccessLayer_LMS)
            {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
        }

        public  List<EmployeeDBModel> AllEmployees()
        {
            var ar = dataAccessLayer_LMS.Employees.ToList();

            return ar;
        }
    }
}
