using ComputerRepairShop.Forms;
using ComputerRepairShop.Repositories;
using ComputerRepairShop.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace ComputerRepairShop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormMain>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClientRepository, ClientRepository>(new TransientLifetimeManager());
            container.RegisterType<IDeviceRepository, DeviceRepository>(new TransientLifetimeManager());
            container.RegisterType<IEmployeeRepository, EmployeeRepository>(new TransientLifetimeManager());
            container.RegisterType<ISparePartRepository, SparePartRepository>(new TransientLifetimeManager());
            container.RegisterType<IRepairOrderRepository, RepairOrderRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}