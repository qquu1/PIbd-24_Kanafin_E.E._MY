using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Entities
{
    public class SparePart
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public decimal Price { get; private set; }
        public PartCategory PartCategory { get; private set; }

        public static SparePart CreateEntity(int id, string name, decimal price, PartCategory category)
        {
            return new SparePart
            {
                Id = id,
                Name = name ?? string.Empty,
                Price = price,
                PartCategory = category
            };
        }
    }
}