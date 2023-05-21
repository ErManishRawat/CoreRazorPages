using CoreRazorPages.Models;
using CoreRazorPages.Models.ViewModel;
using CoreRazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreRazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployee _employeeRepo;
        private readonly IDepartmentService _deptRepo;

        public List<EmployeeViewModel>? Employees { get; set; }
        public IndexModel(IEmployee employeeRepositoy, IDepartmentService deptRepo)
        {
            this._employeeRepo = employeeRepositoy;
            this._deptRepo = deptRepo;
        }

        public void OnGet()
        {

            Employees = (from employee in _employeeRepo.GetAllEmployee()
                         join department in _deptRepo.GetAllDepartment() on employee.DepartmentId equals department.Id
                         select new EmployeeViewModel
                         {
                             Id = employee.Id,
                             Name = employee.Name,
                             Gender = employee.Gender,
                             Salary = employee.Salary,
                             Department = department.DepartmentName,
                             Location = department.Location,
                             DeartmentHead = department.DepartmentHead
                         }).ToList();

        }
    }
}
