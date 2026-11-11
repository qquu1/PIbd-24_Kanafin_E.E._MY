using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Entities
{
    public class Device
    {
        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public DeviceType DeviceType { get; private set; }
        public string Model { get; private set; } = string.Empty;
        public string SerialNumber { get; private set; } = string.Empty;

        public static Device CreateEntity(int id, int clientId, DeviceType deviceType,
            string model, string serialNumber)
        {
            return new Device
            {
                Id = id,
                ClientId = clientId,
                DeviceType = deviceType,
                Model = model ?? string.Empty,
                SerialNumber = serialNumber ?? string.Empty
            };
        }
    }
}
