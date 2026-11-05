using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Repositories
{
    public interface IRepairOrderRepository
    {
        IEnumerable<RepairOrder> ReadRepairOrders(DateTime? dateFrom = null, DateTime? dateTo = null,
            int? employeeId = null, RepairStatus? status = null);
        void CreateRepairOrder(RepairOrder order);
        void DeleteRepairOrder(int id);
    }
}