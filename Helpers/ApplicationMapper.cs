using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_PROJECT.Models;

namespace LMS_PROJECT.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<EmployeeModel, EmployeeDBModel>().ReverseMap();
            CreateMap<ManagerModel, ManagerDBModel>().ReverseMap();
        }
    }
}
