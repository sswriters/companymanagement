using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class Project
    {
        [Key]
        public string projectid { get; set; }
        public string projectname { get; set; }
        public string duedate { get; set; }
        public string status { get; set; }
        public string assigned_people { get; set; }
    }
}
