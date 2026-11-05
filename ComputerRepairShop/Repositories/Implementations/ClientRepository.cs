using ComputerRepairShop.Entities;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class ClientRepository : IClientRepository
    {
        public void CreateClient(Client client) { }
        public void DeleteClient(int id) { }
        public Client ReadClientById(int id) => Client.CreateEntity(0, string.Empty, string.Empty, string.Empty);
        public IEnumerable<Client> ReadClients() => [];
        public void UpdateClient(Client client) { }
    }
}