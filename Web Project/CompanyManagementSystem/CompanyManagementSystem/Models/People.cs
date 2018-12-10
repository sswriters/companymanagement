using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class People
    {
        [Key]
        public string name { get; set; }
        public string pass { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string role { get; set; }
        public string projects { get; set; }
    }
}
