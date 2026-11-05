namespace ComputerRepairShop.Forms.Employees
{
    partial class FormEmployee
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelPost;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private ComboBox comboBoxPost;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelFirstName = new Label();
            this.labelLastName = new Label();
            this.labelPost = new Label();
            this.textBoxFirstName = new TextBox();
            this.textBoxLastName = new TextBox();
            this.comboBoxPost = new ComboBox();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.SuspendLayout();

            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new Point(15, 20);
            this.labelFirstName.Text = "Имя:";

            this.textBoxFirstName.Location = new Point(130, 17);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new Size(240, 23);

            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new Point(15, 55);
            this.labelLastName.Text = "Фамилия:";

            this.textBoxLastName.Location = new Point(130, 52);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new Size(240, 23);

            this.labelPost.AutoSize = true;
            this.labelPost.Location = new Point(15, 90);
            this.labelPost.Text = "Должность:";

            this.comboBoxPost.Location = new Point(130, 87);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new Size(240, 23);

            this.buttonSave.Location = new Point(130, 130);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(110, 30);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);

            this.buttonCancel.Location = new Point(260, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(110, 30);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 180);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormEmployee";
            this.Text = "Работник";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}