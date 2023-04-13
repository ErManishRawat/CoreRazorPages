using System;
using System.Collections.Generic;

namespace CoreRazorPages.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        public int Id { get; set; }
        public string? DepartmentName { get; set; }
        public string? Location { get; set; }
        public string? DepartmentHead { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
