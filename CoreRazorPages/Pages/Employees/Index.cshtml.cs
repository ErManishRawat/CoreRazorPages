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

        public IEnumerable<EmployeeViewModel>? Employees { get; set; }
        public IndexModel(IEmployee employeeRepositoy, IDepartmentService deptRepo)
        {
            this._employeeRepo = employeeRepositoy;
            this._deptRepo = deptRepo;
        }

        public void OnGet()
        {

            Employees = (IEnumerable<EmployeeViewModel>?)_employeeRepo.GetAllEmployee();

        }
    }
}
