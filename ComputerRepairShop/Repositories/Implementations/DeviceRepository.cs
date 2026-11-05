using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class DeviceRepository : IDeviceRepository
    {
        public void CreateDevice(Device device) { }
        public void DeleteDevice(int id) { }
        public Device ReadDeviceById(int id) => Device.CreateEntity(0, 0, DeviceType.None, string.Empty, string.Empty);
        public IEnumerable<Device> ReadDevices() => [];
        public void UpdateDevice(Device device) { }
    }
}