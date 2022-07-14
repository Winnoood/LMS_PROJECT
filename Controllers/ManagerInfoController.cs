using AutoMapper;
using LMS_PROJECT.Models;
using LMS_PROJECT.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_PROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerInfoController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;
        private readonly IMapper mapper;

        public ManagerInfoController(IEmployeeRepo employeeRepo, IMapper mapper)
        {
            this.employeeRepo = employeeRepo;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<ManagerModel>> ManagerDetails()
        {
            var data = employeeRepo.AllManagers();
            var v = mapper.Map<List<ManagerModel>>(data);
            return v;
        }

    }
}
