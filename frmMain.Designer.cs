namespace LINQToSQL
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTerritoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.territoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDemographicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesByHireDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersAndDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersAndDetailsEntityRefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTopFiveOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderValueByOrderIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storedProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesByYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenMostExpensiveProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMultilFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteManyFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertOrUpdateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getProductByCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handlelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportingUserDefinedFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.readToolStripMenuItem,
            this.writeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.queriesToolStripMenuItem,
            this.storedProceduresToolStripMenuItem});
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.shippersToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.employeeTerritoryToolStripMenuItem,
            this.territoryToolStripMenuItem,
            this.regionToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.customerDemoToolStripMenuItem,
            this.customerDemographicToolStripMenuItem,
            this.orderDetailsToolStripMenuItem,
            this.productToolStripMenuItem,
            this.supplierProductToolStripMenuItem,
            this.categoToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // shippersToolStripMenuItem
            // 
            this.shippersToolStripMenuItem.Name = "shippersToolStripMenuItem";
            this.shippersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.shippersToolStripMenuItem.Text = "Shippers";
            this.shippersToolStripMenuItem.Click += new System.EventHandler(this.shippersToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // employeeTerritoryToolStripMenuItem
            // 
            this.employeeTerritoryToolStripMenuItem.Name = "employeeTerritoryToolStripMenuItem";
            this.employeeTerritoryToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.employeeTerritoryToolStripMenuItem.Text = "Employee Territory";
            this.employeeTerritoryToolStripMenuItem.Click += new System.EventHandler(this.employeeTerritoryToolStripMenuItem_Click);
            // 
            // territoryToolStripMenuItem
            // 
            this.territoryToolStripMenuItem.Name = "territoryToolStripMenuItem";
            this.territoryToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.territoryToolStripMenuItem.Text = "Territory";
            this.territoryToolStripMenuItem.Click += new System.EventHandler(this.territoryToolStripMenuItem_Click);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.regionToolStripMenuItem.Text = "Region";
            this.regionToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // customerDemoToolStripMenuItem
            // 
            this.customerDemoToolStripMenuItem.Name = "customerDemoToolStripMenuItem";
            this.customerDemoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.customerDemoToolStripMenuItem.Text = "Customer Demo";
            this.customerDemoToolStripMenuItem.Click += new System.EventHandler(this.customerDemoToolStripMenuItem_Click);
            // 
            // customerDemographicToolStripMenuItem
            // 
            this.customerDemographicToolStripMenuItem.Name = "customerDemographicToolStripMenuItem";
            this.customerDemographicToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.customerDemographicToolStripMenuItem.Text = "Customer Demographic";
            this.customerDemographicToolStripMenuItem.Click += new System.EventHandler(this.customerDemographicToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // supplierProductToolStripMenuItem
            // 
            this.supplierProductToolStripMenuItem.Name = "supplierProductToolStripMenuItem";
            this.supplierProductToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.supplierProductToolStripMenuItem.Text = "Supplier";
            this.supplierProductToolStripMenuItem.Click += new System.EventHandler(this.supplierProductToolStripMenuItem_Click);
            // 
            // categoToolStripMenuItem
            // 
            this.categoToolStripMenuItem.Name = "categoToolStripMenuItem";
            this.categoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.categoToolStripMenuItem.Text = "Category";
            this.categoToolStripMenuItem.Click += new System.EventHandler(this.categoToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listsToolStripMenuItem,
            this.singleValuesToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesByHireDateToolStripMenuItem,
            this.ordersByIdToolStripMenuItem,
            this.ordersAndDetailsToolStripMenuItem,
            this.ordersAndDetailsEntityRefToolStripMenuItem,
            this.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem,
            this.getTopFiveOrdersToolStripMenuItem});
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listsToolStripMenuItem.Text = "Lists";
            // 
            // employeesByHireDateToolStripMenuItem
            // 
            this.employeesByHireDateToolStripMenuItem.Name = "employeesByHireDateToolStripMenuItem";
            this.employeesByHireDateToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.employeesByHireDateToolStripMenuItem.Text = "Employees By Hire Date";
            this.employeesByHireDateToolStripMenuItem.Click += new System.EventHandler(this.employeesByHireDateToolStripMenuItem_Click);
            // 
            // ordersByIdToolStripMenuItem
            // 
            this.ordersByIdToolStripMenuItem.Name = "ordersByIdToolStripMenuItem";
            this.ordersByIdToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ordersByIdToolStripMenuItem.Text = "Orders By ID";
            this.ordersByIdToolStripMenuItem.Click += new System.EventHandler(this.ordersByIdToolStripMenuItem_Click);
            // 
            // ordersAndDetailsToolStripMenuItem
            // 
            this.ordersAndDetailsToolStripMenuItem.Name = "ordersAndDetailsToolStripMenuItem";
            this.ordersAndDetailsToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ordersAndDetailsToolStripMenuItem.Text = "Orders and Details";
            this.ordersAndDetailsToolStripMenuItem.Click += new System.EventHandler(this.ordersAndDetailsToolStripMenuItem_Click);
            // 
            // ordersAndDetailsEntityRefToolStripMenuItem
            // 
            this.ordersAndDetailsEntityRefToolStripMenuItem.Name = "ordersAndDetailsEntityRefToolStripMenuItem";
            this.ordersAndDetailsEntityRefToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ordersAndDetailsEntityRefToolStripMenuItem.Text = "Orders and Details (Entity Set)";
            this.ordersAndDetailsEntityRefToolStripMenuItem.Click += new System.EventHandler(this.ordersAndDetailsEntityRefToolStripMenuItem_Click);
            // 
            // ordersAndDetailsByOrderIDEntityRefToolStripMenuItem
            // 
            this.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Name = "ordersAndDetailsByOrderIDEntityRefToolStripMenuItem";
            this.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Text = "Orders and Details By Order ID (Entity Set)";
            this.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Click += new System.EventHandler(this.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem_Click);
            // 
            // getTopFiveOrdersToolStripMenuItem
            // 
            this.getTopFiveOrdersToolStripMenuItem.Name = "getTopFiveOrdersToolStripMenuItem";
            this.getTopFiveOrdersToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.getTopFiveOrdersToolStripMenuItem.Text = "Get Top Five Orders";
            this.getTopFiveOrdersToolStripMenuItem.Click += new System.EventHandler(this.getTopFiveOrdersToolStripMenuItem_Click);
            // 
            // singleValuesToolStripMenuItem
            // 
            this.singleValuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeByIDToolStripMenuItem,
            this.orderByIDToolStripMenuItem,
            this.orderValueByOrderIDToolStripMenuItem,
            this.customerByIDToolStripMenuItem});
            this.singleValuesToolStripMenuItem.Name = "singleValuesToolStripMenuItem";
            this.singleValuesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.singleValuesToolStripMenuItem.Text = "Single Values";
            // 
            // employeeByIDToolStripMenuItem
            // 
            this.employeeByIDToolStripMenuItem.Name = "employeeByIDToolStripMenuItem";
            this.employeeByIDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.employeeByIDToolStripMenuItem.Text = "Employee By ID";
            this.employeeByIDToolStripMenuItem.Click += new System.EventHandler(this.employeeByIDToolStripMenuItem_Click);
            // 
            // orderByIDToolStripMenuItem
            // 
            this.orderByIDToolStripMenuItem.Name = "orderByIDToolStripMenuItem";
            this.orderByIDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.orderByIDToolStripMenuItem.Text = "Order By ID";
            this.orderByIDToolStripMenuItem.Click += new System.EventHandler(this.orderByIDToolStripMenuItem_Click);
            // 
            // orderValueByOrderIDToolStripMenuItem
            // 
            this.orderValueByOrderIDToolStripMenuItem.Name = "orderValueByOrderIDToolStripMenuItem";
            this.orderValueByOrderIDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.orderValueByOrderIDToolStripMenuItem.Text = "Order Value By Order ID";
            this.orderValueByOrderIDToolStripMenuItem.Click += new System.EventHandler(this.orderValueByOrderIDToolStripMenuItem_Click);
            // 
            // customerByIDToolStripMenuItem
            // 
            this.customerByIDToolStripMenuItem.Name = "customerByIDToolStripMenuItem";
            this.customerByIDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.customerByIDToolStripMenuItem.Text = "Customer By ID";
            this.customerByIDToolStripMenuItem.Click += new System.EventHandler(this.customerByIDToolStripMenuItem_Click);
            // 
            // storedProceduresToolStripMenuItem
            // 
            this.storedProceduresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesByYearToolStripMenuItem,
            this.tenMostExpensiveProductsToolStripMenuItem,
            this.getProductByCategoryToolStripMenuItem,
            this.handlelingToolStripMenuItem,
            this.supportingUserDefinedFunctionsToolStripMenuItem});
            this.storedProceduresToolStripMenuItem.Name = "storedProceduresToolStripMenuItem";
            this.storedProceduresToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.storedProceduresToolStripMenuItem.Text = "Stored Procedures";
            // 
            // salesByYearToolStripMenuItem
            // 
            this.salesByYearToolStripMenuItem.Name = "salesByYearToolStripMenuItem";
            this.salesByYearToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.salesByYearToolStripMenuItem.Text = "Sales By Year";
            this.salesByYearToolStripMenuItem.Click += new System.EventHandler(this.salesByYearToolStripMenuItem_Click);
            // 
            // tenMostExpensiveProductsToolStripMenuItem
            // 
            this.tenMostExpensiveProductsToolStripMenuItem.Name = "tenMostExpensiveProductsToolStripMenuItem";
            this.tenMostExpensiveProductsToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.tenMostExpensiveProductsToolStripMenuItem.Text = "Ten Most Expensive Products";
            this.tenMostExpensiveProductsToolStripMenuItem.Click += new System.EventHandler(this.tenMostExpensiveProductsToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertCustomerToolStripMenuItem,
            this.insertMultilFieldsToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem,
            this.deleteManyFieldsToolStripMenuItem,
            this.insertOrUpdateCustomerToolStripMenuItem});
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.writeToolStripMenuItem.Text = "Insert/Update/Delete";
            // 
            // insertCustomerToolStripMenuItem
            // 
            this.insertCustomerToolStripMenuItem.Name = "insertCustomerToolStripMenuItem";
            this.insertCustomerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insertCustomerToolStripMenuItem.Text = "Insert Customer";
            this.insertCustomerToolStripMenuItem.Click += new System.EventHandler(this.insertCustomerToolStripMenuItem_Click);
            // 
            // insertMultilFieldsToolStripMenuItem
            // 
            this.insertMultilFieldsToolStripMenuItem.Name = "insertMultilFieldsToolStripMenuItem";
            this.insertMultilFieldsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insertMultilFieldsToolStripMenuItem.Text = "Insert many fields";
            this.insertMultilFieldsToolStripMenuItem.Click += new System.EventHandler(this.insertMultilFieldsToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // deleteManyFieldsToolStripMenuItem
            // 
            this.deleteManyFieldsToolStripMenuItem.Name = "deleteManyFieldsToolStripMenuItem";
            this.deleteManyFieldsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deleteManyFieldsToolStripMenuItem.Text = "Delete many fields";
            this.deleteManyFieldsToolStripMenuItem.Click += new System.EventHandler(this.deleteManyFieldsToolStripMenuItem_Click);
            // 
            // insertOrUpdateCustomerToolStripMenuItem
            // 
            this.insertOrUpdateCustomerToolStripMenuItem.Name = "insertOrUpdateCustomerToolStripMenuItem";
            this.insertOrUpdateCustomerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insertOrUpdateCustomerToolStripMenuItem.Text = "Insert or Update Customer";
            this.insertOrUpdateCustomerToolStripMenuItem.Click += new System.EventHandler(this.insertOrUpdateCustomerToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 293);
            this.dataGridView1.TabIndex = 1;
            // 
            // getProductByCategoryToolStripMenuItem
            // 
            this.getProductByCategoryToolStripMenuItem.Name = "getProductByCategoryToolStripMenuItem";
            this.getProductByCategoryToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.getProductByCategoryToolStripMenuItem.Text = "Get Product by Category";
            this.getProductByCategoryToolStripMenuItem.Click += new System.EventHandler(this.getProductByCategoryToolStripMenuItem_Click);
            // 
            // handlelingToolStripMenuItem
            // 
            this.handlelingToolStripMenuItem.Name = "handlelingToolStripMenuItem";
            this.handlelingToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.handlelingToolStripMenuItem.Text = "Handling SPROC Output Parameters ";
            this.handlelingToolStripMenuItem.Click += new System.EventHandler(this.handlelingToolStripMenuItem_Click);
            // 
            // supportingUserDefinedFunctionsToolStripMenuItem
            // 
            this.supportingUserDefinedFunctionsToolStripMenuItem.Name = "supportingUserDefinedFunctionsToolStripMenuItem";
            this.supportingUserDefinedFunctionsToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.supportingUserDefinedFunctionsToolStripMenuItem.Text = "Supporting User Defined Functions";
            this.supportingUserDefinedFunctionsToolStripMenuItem.Click += new System.EventHandler(this.supportingUserDefinedFunctionsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 317);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ To SQL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeTerritoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem territoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDemographicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesByHireDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersAndDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersAndDetailsEntityRefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersAndDetailsByOrderIDEntityRefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderValueByOrderIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTopFiveOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersByIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertOrUpdateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesByYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenMostExpensiveProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMultilFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteManyFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProductByCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handlelingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportingUserDefinedFunctionsToolStripMenuItem;
    }
}

