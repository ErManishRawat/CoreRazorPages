using CoreRazorPages.Models;
using CoreRazorPages.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRazorPages.Services.Interface
{
    public interface IEmployee
    {
        IEnumerable<EmployeeViewModel> GetAllEmployee();
        EmployeeViewModel? GetEmployeeById(int id);
    }
}
