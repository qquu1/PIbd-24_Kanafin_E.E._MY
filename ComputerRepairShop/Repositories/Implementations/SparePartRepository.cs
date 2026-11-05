using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class SparePartRepository : ISparePartRepository
    {
        public void CreateSparePart(SparePart sparePart) { }
        public void DeleteSparePart(int id) { }
        public SparePart ReadSparePartById(int id) => SparePart.CreateEntity(0, string.Empty, 0, PartCategory.None);
        public IEnumerable<SparePart> ReadSpareParts() => [];
        public void UpdateSparePart(SparePart sparePart) { }
    }
}