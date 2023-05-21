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
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Department> _departmentRepository;

        public DepartmentService(IRepository<Department> departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _departmentRepository.GetAll();
        }

        public Department? GetDepartmentById(int id)
        {
            return _departmentRepository.Get(id);
        }
    }
}
