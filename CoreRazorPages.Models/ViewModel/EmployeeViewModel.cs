using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRazorPages.Models.ViewModel
{
    public class EmployeeViewModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int? Salary { get; set; }
        public string? Department { get; set; }
        public string? Location { get; set; }
        public string? DeartmentHead { get; set; }
    }
}
