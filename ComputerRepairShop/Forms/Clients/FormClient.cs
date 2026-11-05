using System.ComponentModel;
using ComputerRepairShop.Entities;
using ComputerRepairShop.Repositories;

namespace ComputerRepairShop.Forms.Clients
{
    public partial class FormClient : Form
    {
        private readonly IClientRepository _clientRepository;
        private int? _clientId;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? Id
        {
            get => _clientId;
            set
            {
                if (value is null) return;

                try
                {
                    var client = _clientRepository.ReadClientById(value.Value);
                    if (client == null) throw new InvalidDataException(nameof(client));

                    textBoxFirstName.Text = client.FirstName;
                    textBoxLastName.Text = client.LastName;
                    textBoxPhone.Text = client.Phone;
                    _clientId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormClient(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            StartPosition = FormStartPosition.CenterParent;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPhone.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_clientId.HasValue)
                    _clientRepository.UpdateClient(CreateClient(_clientId.Value));
                else
                    _clientRepository.CreateClient(CreateClient(0));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Client CreateClient(int id) =>
            Client.CreateEntity(id, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhone.Text);
    }
}