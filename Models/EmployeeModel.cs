using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LMS_PROJECT.Models
{
    public class EmployeeModel
    {
        [Required]
        public int EmpId { get; set; }
        [Required]
        public string EmpPswd { get; set; }
        public string EmpName { get; set; }
        public string EmpMail { get; set; }
        public long EmpMobile { get; set; }
        public DateTime EmpDoj { get; set; }
        public string EmpDept { get; set; }



    }
}
