namespace ComputerRepairShop.Entities;
//связь 
    public class OrderSparePart
    {
        public int Id { get; private set; }
        public int SparePartId { get; private set; }
        public int Count { get; private set; }

        public static OrderSparePart CreateElement(int id, int sparePartId, int count)
        {
            return new OrderSparePart
            {
                Id = id,
                SparePartId = sparePartId,
                Count = count
            };
        }
    }
