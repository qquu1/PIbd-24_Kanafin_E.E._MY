using ComputerRepairShop.Entities;

namespace ComputerRepairShop.Repositories
{
    public interface ISparePartRepository
    {
        IEnumerable<SparePart> ReadSpareParts();
        SparePart ReadSparePartById(int id);
        void CreateSparePart(SparePart sparePart);
        void UpdateSparePart(SparePart sparePart);
        void DeleteSparePart(int id);
    }
}