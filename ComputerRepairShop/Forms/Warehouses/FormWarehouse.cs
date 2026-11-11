using ComputerRepairShop.Entities;
using ComputerRepairShop.Repositories;
using System.ComponentModel;
using System.Windows.Forms;

namespace ComputerRepairShop.Forms.Warehouses
{
    public partial class FormWarehouse : Form
    {
        private readonly IWarehouseRepository _warehouseRepository;
        private int? _warehouseId;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? Id
        {
            get => _warehouseId;
            set
            {
                if (value is null) return;
                try
                {
                    var warehouse = _warehouseRepository.ReadWarehouseById(value.Value);
                    if (warehouse == null) throw new InvalidDataException(nameof(warehouse));

                    textBoxName.Text = warehouse.Name;
                    textBoxAddress.Text = warehouse.Address;
                    numericUpDownCapacity.Value = warehouse.Capacity;
                    numericUpDownOccupied.Value = warehouse.OccupiedPlaces;
                    _warehouseId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormWarehouse(IWarehouseRepository warehouseRepository)
        {
            InitializeComponent();
            _warehouseRepository = warehouseRepository ?? throw new ArgumentNullException(nameof(warehouseRepository));
            StartPosition = FormStartPosition.CenterParent;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                    numericUpDownCapacity.Value <= 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (numericUpDownOccupied.Value > numericUpDownCapacity.Value)
                {
                    throw new Exception("Занятых мест не может быть больше общего количества");
                }

                if (_warehouseId.HasValue)
                    _warehouseRepository.UpdateWarehouse(CreateWarehouse(_warehouseId.Value));
                else
                    _warehouseRepository.CreateWarehouse(CreateWarehouse(0));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Warehouse CreateWarehouse(int id) => Warehouse.CreateEntity(
            id,
            textBoxName.Text,
            textBoxAddress.Text,
            (int)numericUpDownCapacity.Value,
            (int)numericUpDownOccupied.Value);
    }
}