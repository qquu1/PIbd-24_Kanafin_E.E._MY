using ComputerRepairShop.Repositories;
using Unity;

namespace ComputerRepairShop.Forms.Warehouses
{
    public partial class FormWarehouses : Form
    {
        private readonly IUnityContainer _container;
        private readonly IWarehouseRepository _warehouseRepository;

        public FormWarehouses(IUnityContainer container, IWarehouseRepository warehouseRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _warehouseRepository = warehouseRepository ?? throw new ArgumentNullException(nameof(warehouseRepository));
            StartPosition = FormStartPosition.CenterParent;
        }

        private void FormWarehouses_Load(object sender, EventArgs e)
        {
            try { LoadList(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormWarehouse>().ShowDialog(); LoadList(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            try
            {
                var form = _container.Resolve<FormWarehouse>();
                form.Id = findId;
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try { _warehouseRepository.DeleteWarehouse(findId); LoadList(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList() => dataGridViewData.DataSource = _warehouseRepository.ReadWarehouses();

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}