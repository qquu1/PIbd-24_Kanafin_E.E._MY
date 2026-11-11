namespace ComputerRepairShop.Forms.Warehouses
{
    partial class FormWarehouse
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelName;
        private Label labelAddress;
        private Label labelCapacity;
        private Label labelOccupied;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private NumericUpDown numericUpDownCapacity;
        private NumericUpDown numericUpDownOccupied;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelCapacity = new Label();
            this.labelOccupied = new Label();
            this.textBoxName = new TextBox();
            this.textBoxAddress = new TextBox();
            this.numericUpDownCapacity = new NumericUpDown();
            this.numericUpDownOccupied = new NumericUpDown();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownOccupied).BeginInit();
            this.SuspendLayout();

            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(15, 20);
            this.labelName.Text = "Название:";

            this.textBoxName.Location = new Point(160, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(240, 23);

            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new Point(15, 55);
            this.labelAddress.Text = "Адрес:";

            this.textBoxAddress.Location = new Point(160, 52);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(240, 23);

            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new Point(15, 90);
            this.labelCapacity.Text = "Всего мест:";

            this.numericUpDownCapacity.Location = new Point(160, 87);
            this.numericUpDownCapacity.Minimum = 1;
            this.numericUpDownCapacity.Maximum = 100000;
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new Size(240, 23);

            this.labelOccupied.AutoSize = true;
            this.labelOccupied.Location = new Point(15, 125);
            this.labelOccupied.Text = "Занято мест:";

            this.numericUpDownOccupied.Location = new Point(160, 122);
            this.numericUpDownOccupied.Minimum = 0;
            this.numericUpDownOccupied.Maximum = 100000;
            this.numericUpDownOccupied.Name = "numericUpDownOccupied";
            this.numericUpDownOccupied.Size = new Size(240, 23);

            this.buttonSave.Location = new Point(160, 165);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(110, 30);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new Point(290, 165);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(110, 30);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(420, 215);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.labelOccupied);
            this.Controls.Add(this.numericUpDownOccupied);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormWarehouse";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownOccupied).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}