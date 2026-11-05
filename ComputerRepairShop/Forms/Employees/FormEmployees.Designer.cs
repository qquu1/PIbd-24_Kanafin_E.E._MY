namespace ComputerRepairShop.Forms.Employees
{
    partial class FormEmployees
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData;
        private Panel panelButtons;
        private Button buttonAdd;
        private Button buttonUpd;
        private Button buttonDel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewData = new DataGridView();
            this.panelButtons = new Panel();
            this.buttonAdd = new Button();
            this.buttonUpd = new Button();
            this.buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewData).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToResizeColumns = false;
            this.dataGridViewData.AllowUserToResizeRows = false;
            this.dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = DockStyle.Fill;
            this.dataGridViewData.Location = new Point(0, 0);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new Size(700, 450);
            this.dataGridViewData.TabIndex = 0;

            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonUpd);
            this.panelButtons.Controls.Add(this.buttonDel);
            this.panelButtons.Dock = DockStyle.Right;
            this.panelButtons.Location = new Point(700, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(100, 450);

            this.buttonAdd.Location = new Point(10, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(80, 30);
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new EventHandler(this.ButtonAdd_Click);

            this.buttonUpd.Location = new Point(10, 50);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new Size(80, 30);
            this.buttonUpd.Text = "✎";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new EventHandler(this.ButtonUpd_Click);

            this.buttonDel.Location = new Point(10, 90);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new Size(80, 30);
            this.buttonDel.Text = "🗑";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new EventHandler(this.ButtonDel_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormEmployees";
            this.Text = "Работники";
            this.Load += new EventHandler(this.FormEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewData).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}