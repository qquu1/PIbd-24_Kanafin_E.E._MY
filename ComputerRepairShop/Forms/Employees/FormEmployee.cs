using System.ComponentModel;
using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;
using ComputerRepairShop.Repositories;

namespace ComputerRepairShop.Forms.Employees
{
    public partial class FormEmployee : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private int? _employeeId;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? Id
        {
            get => _employeeId;
            set
            {
                if (value is null) return;

                try
                {
                    var employee = _employeeRepository.ReadEmployeeById(value.Value);
                    if (employee == null) throw new InvalidDataException(nameof(employee));

                    textBoxFirstName.Text = employee.FirstName;
                    textBoxLastName.Text = employee.LastName;
                    comboBoxPost.SelectedItem = employee.EmployeePost;
                    _employeeId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormEmployee(IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            StartPosition = FormStartPosition.CenterParent;
            comboBoxPost.DataSource = Enum.GetValues(typeof(EmployeePost));
            comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                    comboBoxPost.SelectedIndex < 1)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_employeeId.HasValue)
                    _employeeRepository.UpdateEmployee(CreateEmployee(_employeeId.Value));
                else
                    _employeeRepository.CreateEmployee(CreateEmployee(0));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Employee CreateEmployee(int id) => Employee.CreateEntity(
            id, textBoxFirstName.Text, textBoxLastName.Text,
            (EmployeePost)comboBoxPost.SelectedItem!);
    }
}