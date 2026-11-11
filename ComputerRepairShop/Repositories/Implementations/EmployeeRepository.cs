using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> ReadEmployees() => [];
        public Employee ReadEmployeeById(int id) =>
            Employee.CreateEntity(0, string.Empty, string.Empty, EmployeePost.None);
        public void CreateEmployee(Employee employee) { }
        public void UpdateEmployee(Employee employee) { }
        public void DeleteEmployee(int id) { }
    }
}