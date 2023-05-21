using CoreRazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRazorPages.Services.Interface
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartment();
        Department? GetDepartmentById(int id);
    }
}
