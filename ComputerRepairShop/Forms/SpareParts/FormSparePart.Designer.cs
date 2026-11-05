namespace ComputerRepairShop.Forms.SpareParts
{
    partial class FormSparePart
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelName;
        private Label labelPrice;
        private Label labelCategory;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownPrice;
        private CheckedListBox checkedListBoxCategory;
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
            this.labelPrice = new Label();
            this.labelCategory = new Label();
            this.textBoxName = new TextBox();
            this.numericUpDownPrice = new NumericUpDown();
            this.checkedListBoxCategory = new CheckedListBox();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownPrice).BeginInit();
            this.SuspendLayout();

            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(15, 20);
            this.labelName.Text = "Название:";

            this.textBoxName.Location = new Point(150, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(240, 23);

            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new Point(15, 55);
            this.labelPrice.Text = "Цена:";

            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new Point(150, 52);
            this.numericUpDownPrice.Maximum = 1000000;
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new Size(240, 23);

            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new Point(15, 90);
            this.labelCategory.Text = "Категории:";

            this.checkedListBoxCategory.CheckOnClick = true;
            this.checkedListBoxCategory.Location = new Point(150, 87);
            this.checkedListBoxCategory.Name = "checkedListBoxCategory";
            this.checkedListBoxCategory.Size = new Size(240, 94);

            this.buttonSave.Location = new Point(150, 195);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(110, 30);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new Point(280, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(110, 30);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(420, 245);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.checkedListBoxCategory);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormSparePart";
            this.Text = "Запчасть";
            ((System.ComponentModel.ISupportInitialize)this.numericUpDownPrice).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}