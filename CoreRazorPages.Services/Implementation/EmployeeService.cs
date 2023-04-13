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
        public readonly ApplicaionDbContext _ApplicaionDbContext;
        public EmployeeService(ApplicaionDbContext applicaionDbContext)
        {
            this._ApplicaionDbContext = applicaionDbContext;
        }

        public List<Employee> GetAllEmployee()
        {
            return this._ApplicaionDbContext.Employees.ToList();
        }

        public Employee? GetEmployeeById(int? id)
        {
            return _ApplicaionDbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
