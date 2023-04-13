using CoreRazorPages.Models;
using CoreRazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreRazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployee employeeRepo;
        public IEnumerable<Employee>? Employees { get; set; }
        public IndexModel(IEmployee employeeRepositoy)
        {
            this.employeeRepo = employeeRepositoy;
        }

        public void OnGet()
        {
            Employees = employeeRepo.GetAllEmployee();
        }
    }
}
