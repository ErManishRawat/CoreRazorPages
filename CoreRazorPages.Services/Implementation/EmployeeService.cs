using CoreRazorPages.Models;
using CoreRazorPages.Models.ViewModel;
using CoreRazorPages.Repository;
using CoreRazorPages.Services.Interface;
using Microsoft.EntityFrameworkCore;


namespace CoreRazorPages.Services.Implementation
{
    public class EmployeeService : IEmployee
    {
        public readonly IRepository<EmployeeViewModel> _employeeRepo;
        private readonly IRepository<Department> _departmentRepo;

        public EmployeeService(IRepository<EmployeeViewModel> employeeRepo, IRepository<Department> departmentRepo)
        {
            this._employeeRepo = employeeRepo;
            this._departmentRepo = departmentRepo;
        }

        public IEnumerable<EmployeeViewModel> GetAllEmployee()
        {
            return (IEnumerable<EmployeeViewModel>)this._employeeRepo.GetAll("spGetAllEmployees").ToList();
            //return (IEnumerable<EmployeeViewModel>)(from employee in this._employeeRepo.GetAll()
            //                                        join department in this._departmentRepo.GetAll() on employee.DepartmentId equals department.Id
            //                                        select new EmployeeViewModel
            //                                        {
            //                                            Id = employee.Id,
            //                                            Name = employee.Name,
            //                                            Gender = employee.Gender,
            //                                            Salary = employee.Salary,
            //                                            Department = department.DepartmentName,
            //                                            Location = department.Location,
            //                                            DeartmentHead = department.DepartmentHead
            //                                        }).ToList();
        }

        public EmployeeViewModel? GetEmployeeById(int id)
        {
            return _employeeRepo.GetById(id);
        }
    }
}
