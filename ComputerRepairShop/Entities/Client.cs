namespace ComputerRepairShop.Entities
{
    public class Client
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;

        public static Client CreateEntity(int id, string firstName, string lastName, string phone)
        {
            return new Client
            {
                Id = id,
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                Phone = phone ?? string.Empty
            };
        }
    }
}