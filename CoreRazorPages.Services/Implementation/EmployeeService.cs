using CoreRazorPages.Models;
using CoreRazorPages.Repository;
using CoreRazorPages.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRazorPages.Services.Implementation
{
    public class EmployeeService : IEmployee
    {
        public readonly IRepository<Employee> _employeeRepo;
        private readonly IRepository<Department> _departmentRepo;

        public EmployeeService(IRepository<Employee> employeeRepo, IRepository<Department> departmentRepo)
        {
            this._employeeRepo = employeeRepo;
            this._departmentRepo = departmentRepo;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return this._employeeRepo.GetAll();
        }

        public Employee? GetEmployeeById(int id)
        {
            return _employeeRepo.Get(id);
        }
    }
}
