using System.ComponentModel;
using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;
using ComputerRepairShop.Repositories;

namespace ComputerRepairShop.Forms.Devices
{
    public partial class FormDevice : Form
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IClientRepository _clientRepository;
        private int? _deviceId;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? Id
        {
            get => _deviceId;
            set
            {
                if (value is null) return;

                try
                {
                    var device = _deviceRepository.ReadDeviceById(value.Value);
                    if (device == null) throw new InvalidDataException(nameof(device));

                    comboBoxClient.SelectedValue = device.ClientId;
                    comboBoxDeviceType.SelectedItem = device.DeviceType;
                    textBoxModel.Text = device.Model;
                    textBoxSerialNumber.Text = device.SerialNumber;
                    _deviceId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormDevice(IDeviceRepository deviceRepository, IClientRepository clientRepository)
        {
            InitializeComponent();
            _deviceRepository = deviceRepository ?? throw new ArgumentNullException(nameof(deviceRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            StartPosition = FormStartPosition.CenterParent;

            comboBoxClient.DataSource = _clientRepository.ReadClients();
            comboBoxClient.DisplayMember = "LastName";
            comboBoxClient.ValueMember = "Id";
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxDeviceType.DataSource = Enum.GetValues(typeof(DeviceType));
            comboBoxDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClient.SelectedIndex < 0 ||
                    comboBoxDeviceType.SelectedIndex < 1 ||
                    string.IsNullOrWhiteSpace(textBoxModel.Text) ||
                    string.IsNullOrWhiteSpace(textBoxSerialNumber.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_deviceId.HasValue)
                    _deviceRepository.UpdateDevice(CreateDevice(_deviceId.Value));
                else
                    _deviceRepository.CreateDevice(CreateDevice(0));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Device CreateDevice(int id) => Device.CreateEntity(
            id,
            (int)comboBoxClient.SelectedValue!,
            (DeviceType)comboBoxDeviceType.SelectedItem!,
            textBoxModel.Text,
            textBoxSerialNumber.Text);
    }
}