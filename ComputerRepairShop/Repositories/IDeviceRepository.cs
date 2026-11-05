using ComputerRepairShop.Entities;

namespace ComputerRepairShop.Repositories
{
    public interface IDeviceRepository
    {
        IEnumerable<Device> ReadDevices();
        Device ReadDeviceById(int id);
        void CreateDevice(Device device);
        void UpdateDevice(Device device);
        void DeleteDevice(int id);
    }
}