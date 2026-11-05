using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Entities
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public EmployeePost EmployeePost { get; private set; }

        public static Employee CreateEntity(int id, string firstName, string lastName, EmployeePost post)
        {
            return new Employee
            {
                Id = id,
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                EmployeePost = post
            };
        }
    }
}