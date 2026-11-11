namespace ComputerRepairShop.Forms.Orders
{
    partial class FormRepairOrder
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelDevice;
        private Label labelEmployee;
        private Label labelStatus;
        private Label labelWarehouse;
        private Label labelDate;
        private Label labelTotalCost;
        private ComboBox comboBoxDevice;
        private ComboBox comboBoxEmployee;
        private ComboBox comboBoxWarehouse;
        private CheckedListBox checkedListBoxStatus;
        private DateTimePicker dateTimePickerOrderDate;
        private NumericUpDown numericUpDownTotalCost;
        private GroupBox groupBoxParts;
        private DataGridView dataGridViewSpareParts;
        private DataGridViewComboBoxColumn ColumnSparePart;
        private DataGridViewTextBoxColumn ColumnCount;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelDevice = new Label();
            this.labelEmployee = new Label();
            this.labelStatus = new Label();
            this.labelWarehouse = new Label();
            this.labelDate = new Label();
            this.labelTotalCost = new Label();
            this.comboBoxDevice = new ComboBox();
            this.comboBoxEmployee = new ComboBox();
            this.comboBoxWarehouse = new ComboBox();
            this.checkedListBoxStatus = new CheckedListBox();
            this.dateTimePickerOrderDate = new DateTimePicker();
            this.numericUpDownTotalCost = new NumericUpDown();
            this.groupBoxParts = new GroupBox();
            this.dataGridViewSpareParts = new DataGridView();
            this.ColumnSparePart = new DataGridViewComboBoxColumn();
            this.ColumnCount = new DataGridViewTextBoxColumn();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownTotalCost).BeginInit();
            this.groupBoxParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewSpareParts).BeginInit();
            this.SuspendLayout();

            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new Point(15, 20);
            this.labelDevice.Text = "Устройство:";

            this.comboBoxDevice.Location = new Point(150, 17);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new Size(300, 23);

            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new Point(15, 55);
            this.labelEmployee.Text = "Работник:";

            this.comboBoxEmployee.Location = new Point(150, 52);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new Size(300, 23);

            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new Point(15, 90);
            this.labelStatus.Text = "Статус:";

            this.checkedListBoxStatus.CheckOnClick = true;
            this.checkedListBoxStatus.Location = new Point(150, 87);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new Size(300, 94);

            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Location = new Point(15, 195);
            this.labelWarehouse.Text = "Склад:";

            this.comboBoxWarehouse.Location = new Point(150, 192);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new Size(300, 23);

            this.labelDate.AutoSize = true;
            this.labelDate.Location = new Point(15, 230);
            this.labelDate.Text = "Дата:";

            this.dateTimePickerOrderDate.Location = new Point(150, 227);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new Size(300, 23);

            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new Point(15, 265);
            this.labelTotalCost.Text = "Итоговая стоимость:";

            this.numericUpDownTotalCost.DecimalPlaces = 2;
            this.numericUpDownTotalCost.Location = new Point(150, 262);
            this.numericUpDownTotalCost.Maximum = 1000000;
            this.numericUpDownTotalCost.Name = "numericUpDownTotalCost";
            this.numericUpDownTotalCost.Size = new Size(300, 23);

            this.groupBoxParts.Controls.Add(this.dataGridViewSpareParts);
            this.groupBoxParts.Location = new Point(15, 300);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Size = new Size(560, 170);
            this.groupBoxParts.Text = "Запчасти";

            this.dataGridViewSpareParts.AllowUserToAddRows = true;
            this.dataGridViewSpareParts.AllowUserToDeleteRows = true;
            this.dataGridViewSpareParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSpareParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpareParts.Columns.AddRange(new DataGridViewColumn[] {
                this.ColumnSparePart, this.ColumnCount});
            this.dataGridViewSpareParts.Dock = DockStyle.Fill;
            this.dataGridViewSpareParts.Location = new Point(3, 19);
            this.dataGridViewSpareParts.MultiSelect = false;
            this.dataGridViewSpareParts.Name = "dataGridViewSpareParts";
            this.dataGridViewSpareParts.RowHeadersVisible = false;
            this.dataGridViewSpareParts.Size = new Size(554, 148);

            this.ColumnSparePart.HeaderText = "Запчасть";
            this.ColumnSparePart.Name = "ColumnSparePart";

            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.Name = "ColumnCount";

            this.buttonSave.Location = new Point(150, 480);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(110, 30);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new Point(280, 480);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(110, 30);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 530);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkedListBoxStatus);
            this.Controls.Add(this.labelWarehouse);
            this.Controls.Add(this.comboBoxWarehouse);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.numericUpDownTotalCost);
            this.Controls.Add(this.groupBoxParts);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormRepairOrder";
            this.Text = "Заказ на ремонт";
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownTotalCost).EndInit();
            this.groupBoxParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewSpareParts).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}