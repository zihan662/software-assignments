namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.changeOrder = new System.Windows.Forms.Button();
            this.creatOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showAll = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.textProduct = new System.Windows.Forms.TextBox();
            this.textCustomer = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.radioMoney = new System.Windows.Forms.RadioButton();
            this.radioProduct = new System.Windows.Forms.RadioButton();
            this.radioCustomer = new System.Windows.Forms.RadioButton();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.queryOrder = new System.Windows.Forms.Button();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.dataGriddetails = new System.Windows.Forms.DataGridView();
            this.bdsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsOrders = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteOrder);
            this.groupBox1.Controls.Add(this.changeOrder);
            this.groupBox1.Controls.Add(this.creatOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1407, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orderinstruction";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deleteOrder
            // 
            this.deleteOrder.Location = new System.Drawing.Point(763, 47);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(215, 49);
            this.deleteOrder.TabIndex = 2;
            this.deleteOrder.Text = "删除订单";
            this.deleteOrder.UseVisualStyleBackColor = true;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // changeOrder
            // 
            this.changeOrder.Location = new System.Drawing.Point(412, 47);
            this.changeOrder.Name = "changeOrder";
            this.changeOrder.Size = new System.Drawing.Size(206, 48);
            this.changeOrder.TabIndex = 1;
            this.changeOrder.Text = "修改订单";
            this.changeOrder.UseVisualStyleBackColor = true;
            this.changeOrder.Click += new System.EventHandler(this.changeOrder_Click);
            // 
            // creatOrder
            // 
            this.creatOrder.Location = new System.Drawing.Point(78, 46);
            this.creatOrder.Name = "creatOrder";
            this.creatOrder.Size = new System.Drawing.Size(199, 49);
            this.creatOrder.TabIndex = 0;
            this.creatOrder.Text = "创建订单";
            this.creatOrder.UseVisualStyleBackColor = true;
            this.creatOrder.Click += new System.EventHandler(this.creatOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showAll);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.queryOrder);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1407, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find";
            // 
            // showAll
            // 
            this.showAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showAll.Location = new System.Drawing.Point(951, 141);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(453, 46);
            this.showAll.TabIndex = 3;
            this.showAll.Text = "显示所有订单";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(951, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(453, 56);
            this.button5.TabIndex = 2;
            this.button5.Text = "选择查询条件";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textMoney);
            this.groupBox3.Controls.Add(this.textProduct);
            this.groupBox3.Controls.Add(this.textCustomer);
            this.groupBox3.Controls.Add(this.textId);
            this.groupBox3.Controls.Add(this.radioMoney);
            this.groupBox3.Controls.Add(this.radioProduct);
            this.groupBox3.Controls.Add(this.radioCustomer);
            this.groupBox3.Controls.Add(this.radioId);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(948, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "items";
            // 
            // textMoney
            // 
            this.textMoney.Location = new System.Drawing.Point(715, 94);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(142, 31);
            this.textMoney.TabIndex = 7;
            this.textMoney.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textProduct
            // 
            this.textProduct.Location = new System.Drawing.Point(473, 94);
            this.textProduct.Name = "textProduct";
            this.textProduct.Size = new System.Drawing.Size(142, 31);
            this.textProduct.TabIndex = 6;
            this.textProduct.Enter += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textCustomer
            // 
            this.textCustomer.Location = new System.Drawing.Point(230, 94);
            this.textCustomer.Name = "textCustomer";
            this.textCustomer.Size = new System.Drawing.Size(142, 31);
            this.textCustomer.TabIndex = 5;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(10, 94);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(142, 31);
            this.textId.TabIndex = 4;
            // 
            // radioMoney
            // 
            this.radioMoney.AutoSize = true;
            this.radioMoney.Location = new System.Drawing.Point(715, 31);
            this.radioMoney.Name = "radioMoney";
            this.radioMoney.Size = new System.Drawing.Size(98, 25);
            this.radioMoney.TabIndex = 3;
            this.radioMoney.TabStop = true;
            this.radioMoney.Text = "总金额";
            this.radioMoney.UseVisualStyleBackColor = true;
            // 
            // radioProduct
            // 
            this.radioProduct.AutoSize = true;
            this.radioProduct.Location = new System.Drawing.Point(473, 30);
            this.radioProduct.Name = "radioProduct";
            this.radioProduct.Size = new System.Drawing.Size(98, 25);
            this.radioProduct.TabIndex = 2;
            this.radioProduct.TabStop = true;
            this.radioProduct.Text = "货物名";
            this.radioProduct.UseVisualStyleBackColor = true;
            // 
            // radioCustomer
            // 
            this.radioCustomer.AutoSize = true;
            this.radioCustomer.Location = new System.Drawing.Point(230, 30);
            this.radioCustomer.Name = "radioCustomer";
            this.radioCustomer.Size = new System.Drawing.Size(98, 25);
            this.radioCustomer.TabIndex = 1;
            this.radioCustomer.TabStop = true;
            this.radioCustomer.Text = "客户名";
            this.radioCustomer.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Location = new System.Drawing.Point(10, 31);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(98, 25);
            this.radioId.TabIndex = 0;
            this.radioId.TabStop = true;
            this.radioId.Text = "订单号";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // queryOrder
            // 
            this.queryOrder.Location = new System.Drawing.Point(957, 89);
            this.queryOrder.Name = "queryOrder";
            this.queryOrder.Size = new System.Drawing.Size(444, 42);
            this.queryOrder.TabIndex = 0;
            this.queryOrder.Text = "查询订单";
            this.queryOrder.UseVisualStyleBackColor = true;
            this.queryOrder.Click += new System.EventHandler(this.queryOrder_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AutoGenerateColumns = false;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridOrder.DataSource = this.bdsOrders;
            this.dataGridOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridOrder.Location = new System.Drawing.Point(0, 306);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.RowHeadersWidth = 72;
            this.dataGridOrder.RowTemplate.Height = 33;
            this.dataGridOrder.Size = new System.Drawing.Size(777, 532);
            this.dataGridOrder.TabIndex = 2;
            // 
            // dataGriddetails
            // 
            this.dataGriddetails.AutoGenerateColumns = false;
            this.dataGriddetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriddetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.Column1,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dataGriddetails.DataSource = this.bdsDetails;
            this.dataGriddetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGriddetails.Location = new System.Drawing.Point(781, 306);
            this.dataGriddetails.Name = "dataGriddetails";
            this.dataGriddetails.RowHeadersWidth = 72;
            this.dataGriddetails.RowTemplate.Height = 33;
            this.dataGriddetails.Size = new System.Drawing.Size(626, 532);
            this.dataGriddetails.TabIndex = 3;
            // 
            // bdsDetails
            // 
            this.bdsDetails.DataMember = "Details";
            this.bdsDetails.DataSource = this.bdsOrders;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(777, 306);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 532);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "产品单价";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // bdsOrders
            // 
            this.bdsOrders.DataSource = typeof(OrderLib.Order);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 175;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerDataGridViewTextBoxColumn.HeaderText = "客户名";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 175;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时间";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.Width = 175;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价格";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 175;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productDataGridViewTextBoxColumn.HeaderText = "产品名";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 175;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UnitPrice";
            this.Column1.HeaderText = "产品单价";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 175;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn1.Width = 175;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 838);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGriddetails);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button changeOrder;
        private System.Windows.Forms.Button creatOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button queryOrder;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioMoney;
        private System.Windows.Forms.RadioButton radioProduct;
        private System.Windows.Forms.RadioButton radioCustomer;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.TextBox textProduct;
        private System.Windows.Forms.TextBox textCustomer;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.DataGridView dataGriddetails;
        private System.Windows.Forms.BindingSource bdsOrders;
        private System.Windows.Forms.BindingSource bdsDetails;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

