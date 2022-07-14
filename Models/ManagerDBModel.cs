using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LMS_PROJECT.Models
{
    public class ManagerDBModel
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpMail { get; set; }
        public long EmpMobile { get; set; }
    }
}
