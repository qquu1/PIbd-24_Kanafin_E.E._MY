using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class RepairOrderRepository : IRepairOrderRepository
    {
        public IEnumerable<RepairOrder> ReadRepairOrders(DateTime? dateFrom = null, DateTime? dateTo = null,
            int? employeeId = null, RepairStatus? status = null) => [];

        public void CreateRepairOrder(RepairOrder order) { }

        public void DeleteRepairOrder(int id) { }
    }
}