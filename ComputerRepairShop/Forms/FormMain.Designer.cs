namespace ComputerRepairShop.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuDirectories;
        private ToolStripMenuItem menuClients;
        private ToolStripMenuItem menuDevices;
        private ToolStripMenuItem menuEmployees;
        private ToolStripMenuItem menuSpareParts;
        private ToolStripMenuItem menuWarehouses;
        private ToolStripMenuItem menuOperations;
        private ToolStripMenuItem menuRepairOrders;
        private ToolStripMenuItem menuReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStripMain = new MenuStrip();
            menuDirectories = new ToolStripMenuItem();
            menuClients = new ToolStripMenuItem();
            menuDevices = new ToolStripMenuItem();
            menuEmployees = new ToolStripMenuItem();
            menuSpareParts = new ToolStripMenuItem();
            menuWarehouses = new ToolStripMenuItem();
            menuOperations = new ToolStripMenuItem();
            menuRepairOrders = new ToolStripMenuItem();
            menuReports = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuDirectories, menuOperations, menuReports });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new Padding(7, 3, 0, 3);
            menuStripMain.Size = new Size(914, 30);
            menuStripMain.TabIndex = 0;
            // 
            // menuDirectories
            // 
            menuDirectories.DropDownItems.AddRange(new ToolStripItem[] { menuClients, menuDevices, menuEmployees, menuSpareParts, menuWarehouses });
            menuDirectories.Name = "menuDirectories";
            menuDirectories.Size = new Size(117, 24);
            menuDirectories.Text = "Справочники";
            // 
            // menuClients
            // 
            menuClients.Name = "menuClients";
            menuClients.Size = new Size(170, 26);
            menuClients.Text = "Клиенты";
            menuClients.Click += ClientsToolStripMenuItem_Click;
            // 
            // menuDevices
            // 
            menuDevices.Name = "menuDevices";
            menuDevices.Size = new Size(170, 26);
            menuDevices.Text = "Устройства";
            menuDevices.Click += DevicesToolStripMenuItem_Click;
            // 
            // menuEmployees
            // 
            menuEmployees.Name = "menuEmployees";
            menuEmployees.Size = new Size(170, 26);
            menuEmployees.Text = "Работники";
            menuEmployees.Click += EmployeesToolStripMenuItem_Click;
            // 
            // menuSpareParts
            // 
            menuSpareParts.Name = "menuSpareParts";
            menuSpareParts.Size = new Size(170, 26);
            menuSpareParts.Text = "Запчасти";
            menuSpareParts.Click += SparePartsToolStripMenuItem_Click;
            // 
            // menuWarehouses
            // 
            menuWarehouses.Name = "menuWarehouses";
            menuWarehouses.Size = new Size(170, 26);
            menuWarehouses.Text = "Склады";
            menuWarehouses.Click += WarehousesToolStripMenuItem_Click;
            // 
            // menuOperations
            // 
            menuOperations.DropDownItems.AddRange(new ToolStripItem[] { menuRepairOrders });
            menuOperations.Name = "menuOperations";
            menuOperations.Size = new Size(95, 24);
            menuOperations.Text = "Операции";
            // 
            // menuRepairOrders
            // 
            menuRepairOrders.Name = "menuRepairOrders";
            menuRepairOrders.Size = new Size(218, 26);
            menuRepairOrders.Text = "Заказы на ремонт";
            menuRepairOrders.Click += RepairOrdersToolStripMenuItem_Click;
            // 
            // menuReports
            // 
            menuReports.Name = "menuReports";
            menuReports.Size = new Size(73, 24);
            menuReports.Text = "Отчеты";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Учет в фирме по ремонту компьютерной техники";
            Load += FormMain_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}