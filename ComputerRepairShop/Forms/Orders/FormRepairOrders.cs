using ComputerRepairShop.Repositories;
using Unity;

namespace ComputerRepairShop.Forms.Orders
{
    public partial class FormRepairOrders : Form
    {
        private readonly IUnityContainer _container;
        private readonly IRepairOrderRepository _repairOrderRepository;

        public FormRepairOrders(IUnityContainer container, IRepairOrderRepository repairOrderRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _repairOrderRepository = repairOrderRepository ?? throw new ArgumentNullException(nameof(repairOrderRepository));
            StartPosition = FormStartPosition.CenterParent;
        }

        private void FormRepairOrders_Load(object sender, EventArgs e)
        {
            try { LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormRepairOrder>().ShowDialog(); LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try { _repairOrderRepository.DeleteRepairOrder(findId); LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() => dataGridViewData.DataSource = _repairOrderRepository.ReadRepairOrders();

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}