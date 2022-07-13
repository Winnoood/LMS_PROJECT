using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_PROJECT.Repository;
using AutoMapper;
using LMS_PROJECT.Models;

namespace LMS_PROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplInfoController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;
        private readonly IMapper mapper;

        public EmplInfoController(IEmployeeRepo employeeRepo,IMapper mapper)
        {
            this.employeeRepo = employeeRepo;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<EmployeeModel>> EmpDetails()
        {
            var ar = employeeRepo.AllEmployees();
            var w = mapper.Map<List<EmployeeModel>>(ar);
            return w;
            
        }
    }
}
