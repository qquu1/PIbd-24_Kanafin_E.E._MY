using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Entities
{
    public class RepairOrder
    {
        public int Id { get; private set; }
        public int DeviceId { get; private set; }
        public int EmployeeId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public RepairStatus RepairStatus { get; private set; }
        public decimal TotalCost { get; private set; }
        public IEnumerable<OrderSparePart> OrderSpareParts { get; private set; } = [];

        public static RepairOrder CreateOperation(int id, int deviceId, int employeeId,
            RepairStatus status, decimal totalCost, IEnumerable<OrderSparePart> parts)
        {
            return new RepairOrder
            {
                Id = id,
                DeviceId = deviceId,
                EmployeeId = employeeId,
                OrderDate = DateTime.Now,
                RepairStatus = status,
                TotalCost = totalCost,
                OrderSpareParts = parts ?? []
            };
        }
    }
}