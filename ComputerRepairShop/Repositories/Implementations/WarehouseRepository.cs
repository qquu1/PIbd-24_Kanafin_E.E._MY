using ComputerRepairShop.Entities;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class WarehouseRepository : IWarehouseRepository
    {
        public IEnumerable<Warehouse> ReadWarehouses() => [];

        public Warehouse ReadWarehouseById(int id) =>
            Warehouse.CreateEntity(0, string.Empty, string.Empty, 0, 0);

        public void CreateWarehouse(Warehouse warehouse) { }

        public void UpdateWarehouse(Warehouse warehouse) { }

        public void DeleteWarehouse(int id) { }
    }
}