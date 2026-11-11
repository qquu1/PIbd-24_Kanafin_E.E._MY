using ComputerRepairShop.Forms.Clients;
using ComputerRepairShop.Forms.Devices;
using ComputerRepairShop.Forms.Employees;
using ComputerRepairShop.Forms.Orders;
using ComputerRepairShop.Forms.SpareParts;
using ComputerRepairShop.Forms.Warehouses;
using Unity;

namespace ComputerRepairShop.Forms
{
    public partial class FormMain : Form
    {
        private readonly IUnityContainer _container;

        public FormMain(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
            => SafeOpen(() => _container.Resolve<FormClients>().ShowDialog());

        private void DevicesToolStripMenuItem_Click(object sender, EventArgs e)
            => SafeOpen(() => _container.Resolve<FormDevices>().ShowDialog());

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
            => SafeOpen(() => _container.Resolve<FormEmployees>().ShowDialog());

        private void SparePartsToolStripMenuItem_Click(object sender, EventArgs e)
            => SafeOpen(() => _container.Resolve<FormSpareParts>().ShowDialog());

        private void WarehousesToolStripMenuItem_Click(object sender, EventArgs e)
            => SafeOpen(() => _container.Resolve<FormWarehouses>().ShowDialog());

        private void RepairOrdersToolStripMenuItem_Click(object sender, EventArgs e)
            => SafeOpen(() => _container.Resolve<FormRepairOrders>().ShowDialog());

        private static void SafeOpen(Action action)
        {
            try { action(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}