namespace ComputerRepairShop.Forms.Devices
{
    partial class FormDevice
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelClient;
        private Label labelDeviceType;
        private Label labelModel;
        private Label labelSerialNumber;
        private ComboBox comboBoxClient;
        private ComboBox comboBoxDeviceType;
        private TextBox textBoxModel;
        private TextBox textBoxSerialNumber;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelClient = new Label();
            this.labelDeviceType = new Label();
            this.labelModel = new Label();
            this.labelSerialNumber = new Label();
            this.comboBoxClient = new ComboBox();
            this.comboBoxDeviceType = new ComboBox();
            this.textBoxModel = new TextBox();
            this.textBoxSerialNumber = new TextBox();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.SuspendLayout();

            this.labelClient.AutoSize = true;
            this.labelClient.Location = new Point(15, 20);
            this.labelClient.Text = "Клиент:";

            this.comboBoxClient.Location = new Point(150, 17);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new Size(240, 23);

            this.labelDeviceType.AutoSize = true;
            this.labelDeviceType.Location = new Point(15, 55);
            this.labelDeviceType.Text = "Тип устройства:";

            this.comboBoxDeviceType.Location = new Point(150, 52);
            this.comboBoxDeviceType.Name = "comboBoxDeviceType";
            this.comboBoxDeviceType.Size = new Size(240, 23);

            this.labelModel.AutoSize = true;
            this.labelModel.Location = new Point(15, 90);
            this.labelModel.Text = "Модель:";

            this.textBoxModel.Location = new Point(150, 87);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new Size(240, 23);

            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new Point(15, 125);
            this.labelSerialNumber.Text = "Серийный номер:";

            this.textBoxSerialNumber.Location = new Point(150, 122);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new Size(240, 23);

            this.buttonSave.Location = new Point(150, 165);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(110, 30);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new Point(280, 165);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(110, 30);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(420, 215);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelDeviceType);
            this.Controls.Add(this.comboBoxDeviceType);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelSerialNumber);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormDevice";
            this.Text = "Устройство";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}