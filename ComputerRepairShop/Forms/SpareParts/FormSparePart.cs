using System.ComponentModel;
using ComputerRepairShop.Entities;
using ComputerRepairShop.Entities.Enums;
using ComputerRepairShop.Repositories;

namespace ComputerRepairShop.Forms.SpareParts
{
    public partial class FormSparePart : Form
    {
        private readonly ISparePartRepository _sparePartRepository;
        private int? _sparePartId;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? Id
        {
            get => _sparePartId;
            set
            {
                if (value is null) return;

                try
                {
                    var part = _sparePartRepository.ReadSparePartById(value.Value);
                    if (part == null) throw new InvalidDataException(nameof(part));

                    foreach (PartCategory elem in Enum.GetValues(typeof(PartCategory)))
                    {
                        if ((elem & part.PartCategory) != 0)
                        {
                            checkedListBoxCategory.SetItemChecked(
                                checkedListBoxCategory.Items.IndexOf(elem), true);
                        }
                    }

                    textBoxName.Text = part.Name;
                    numericUpDownPrice.Value = part.Price;
                    _sparePartId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormSparePart(ISparePartRepository sparePartRepository)
        {
            InitializeComponent();
            _sparePartRepository = sparePartRepository ?? throw new ArgumentNullException(nameof(sparePartRepository));
            StartPosition = FormStartPosition.CenterParent;

            foreach (var elem in Enum.GetValues(typeof(PartCategory)))
            {
                checkedListBoxCategory.Items.Add(elem);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    checkedListBoxCategory.CheckedItems.Count == 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_sparePartId.HasValue)
                    _sparePartRepository.UpdateSparePart(CreateSparePart(_sparePartId.Value));
                else
                    _sparePartRepository.CreateSparePart(CreateSparePart(0));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private SparePart CreateSparePart(int id)
        {
            PartCategory category = PartCategory.None;
            foreach (var elem in checkedListBoxCategory.CheckedItems)
            {
                category |= (PartCategory)elem;
            }

            return SparePart.CreateEntity(id, textBoxName.Text,
                Convert.ToDecimal(numericUpDownPrice.Value), category);
        }
    }
}