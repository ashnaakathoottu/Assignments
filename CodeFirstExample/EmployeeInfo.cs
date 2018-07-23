
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CodeFirstExample
{
    //POCO Classes
    //Plain Old CLR Objects
    class EmployeeInfo
    {
        [Key]// makes primary key
        public int EmpID { get; set; }
        [Required]// makes not null
        public string Name { get; set; }
        [Required]
        public string Dept { get; set; }
        [Required]
        [Range(minimum:10000,maximum:50000,ErrorMessage ="Salary Between")]
        public double Salary { get; set; }

    }
}
