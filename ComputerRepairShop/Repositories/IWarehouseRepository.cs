using ComputerRepairShop.Entities;

namespace ComputerRepairShop.Repositories
{
    public interface IWarehouseRepository
    {
        IEnumerable<Warehouse> ReadWarehouses();
        Warehouse ReadWarehouseById(int id);
        void CreateWarehouse(Warehouse warehouse);
        void UpdateWarehouse(Warehouse warehouse);
        void DeleteWarehouse(int id);
    }
}