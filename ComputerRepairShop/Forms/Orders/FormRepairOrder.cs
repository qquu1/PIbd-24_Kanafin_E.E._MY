using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;
using ComputerRepairShop.Repositories;

namespace ComputerRepairShop.Forms.Orders
{
    public partial class FormRepairOrder : Form
    {
        private readonly IRepairOrderRepository _repairOrderRepository;
        private readonly IWarehouseRepository _warehouseRepository;

        public FormRepairOrder(IRepairOrderRepository repairOrderRepository,
            IDeviceRepository deviceRepository,
            IEmployeeRepository employeeRepository,
            ISparePartRepository sparePartRepository,
            IWarehouseRepository warehouseRepository)
        {
            InitializeComponent();
            _repairOrderRepository = repairOrderRepository ?? throw new ArgumentNullException(nameof(repairOrderRepository));
            _warehouseRepository = warehouseRepository ?? throw new ArgumentNullException(nameof(warehouseRepository));
            StartPosition = FormStartPosition.CenterParent;

            comboBoxDevice.DataSource = deviceRepository.ReadDevices();
            comboBoxDevice.DisplayMember = "Model";
            comboBoxDevice.ValueMember = "Id";
            comboBoxDevice.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxEmployee.DataSource = employeeRepository.ReadEmployees();
            comboBoxEmployee.DisplayMember = "FirstName";
            comboBoxEmployee.ValueMember = "Id";
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;

            ColumnSparePart.DataSource = sparePartRepository.ReadSpareParts();
            ColumnSparePart.DisplayMember = "Name";
            ColumnSparePart.ValueMember = "Id";

            comboBoxWarehouse.DataSource = _warehouseRepository.ReadWarehouses();
            comboBoxWarehouse.DisplayMember = "Name";
            comboBoxWarehouse.ValueMember = "Id";
            comboBoxWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWarehouse.SelectedIndex = -1;

            dateTimePickerOrderDate.Enabled = false;

            foreach (var elem in Enum.GetValues(typeof(RepairStatus)))
            {
                checkedListBoxStatus.Items.Add(elem);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDevice.SelectedIndex < 0 ||
                    comboBoxEmployee.SelectedIndex < 0 ||
                    checkedListBoxStatus.CheckedItems.Count == 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                Warehouse? selectedWarehouse = null;
                if (comboBoxWarehouse.SelectedIndex >= 0)
                {
                    selectedWarehouse = _warehouseRepository.ReadWarehouseById(
                        (int)comboBoxWarehouse.SelectedValue!);

                    if (selectedWarehouse.AvailablePlaces <= 0)
                        throw new Exception("На выбранном складе нет свободных мест");
                }

                var status = RepairStatus.None;
                foreach (var elem in checkedListBoxStatus.CheckedItems)
                {
                    status |= (RepairStatus)elem;
                }

                _repairOrderRepository.CreateRepairOrder(RepairOrder.CreateOperation(
                    0,
                    (int)comboBoxDevice.SelectedValue!,
                    (int)comboBoxEmployee.SelectedValue!,
                    selectedWarehouse?.Id,
                    status,
                    Convert.ToDecimal(numericUpDownTotalCost.Value),
                    CreateListOrderSparePartsFromDataGrid()));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private List<OrderSparePart> CreateListOrderSparePartsFromDataGrid()
        {
            var list = new List<OrderSparePart>();
            foreach (DataGridViewRow row in dataGridViewSpareParts.Rows)
            {
                if (row.Cells["ColumnSparePart"].Value == null ||
                    row.Cells["ColumnCount"].Value == null)
                {
                    continue;
                }

                list.Add(OrderSparePart.CreateElement(0,
                    Convert.ToInt32(row.Cells["ColumnSparePart"].Value),
                    Convert.ToInt32(row.Cells["ColumnCount"].Value)));
            }

            return list;
        }
    }
}