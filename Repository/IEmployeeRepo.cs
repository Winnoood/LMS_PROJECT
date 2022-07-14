using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_PROJECT.Models;

namespace LMS_PROJECT.Repository
{
    public interface IEmployeeRepo
    {
        List<EmployeeDBModel> AllEmployees();
        List<ManagerDBModel> AllManagers();
    }
}
