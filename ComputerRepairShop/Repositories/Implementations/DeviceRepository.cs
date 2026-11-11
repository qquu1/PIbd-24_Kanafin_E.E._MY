using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;

namespace ComputerRepairShop.Repositories.Implementations
{
    internal class DeviceRepository : IDeviceRepository
    {
        public IEnumerable<Device> ReadDevices() => [];
        public Device ReadDeviceById(int id) =>
            Device.CreateEntity(0, 0, DeviceType.None, string.Empty, string.Empty);
        public void CreateDevice(Device device) { }
        public void UpdateDevice(Device device) { }
        public void DeleteDevice(int id) { }
    }
}