namespace ComputerRepairShop.Entities
{
    public class Warehouse
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Address { get; private set; } = string.Empty;
        public int Capacity { get; private set; }
        public int OccupiedPlaces { get; private set; }

        public int AvailablePlaces => Capacity - OccupiedPlaces;

        public static Warehouse CreateEntity(int id, string name, string address,
            int capacity, int occupiedPlaces)
        {
            return new Warehouse
            {
                Id = id,
                Name = name ?? string.Empty,
                Address = address ?? string.Empty,
                Capacity = capacity,
                OccupiedPlaces = occupiedPlaces
            };
        }
    }
}