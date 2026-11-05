using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public void CreateEmployee(Employee employee) { }
        public void DeleteEmployee(int id) { }
        public Employee ReadEmployeeById(int id) => Employee.CreateEntity(0, string.Empty, string.Empty, EmployeePost.None);
        public IEnumerable<Employee> ReadEmployees() => [];
        public void UpdateEmployee(Employee employee) { }
    }
}