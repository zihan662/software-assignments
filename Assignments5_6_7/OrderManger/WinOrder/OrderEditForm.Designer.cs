namespace WinForm
{
    partial class OrderEditForm
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
            this.components = new System.ComponentModel.Container();
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.textCustomer = new System.Windows.Forms.ComboBox();
            this.labeltime = new System.Windows.Forms.Label();
            this.creatTime = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.t_customer = new System.Windows.Forms.Label();
            this.t_Id = new System.Windows.Forms.Label();
            this.addOrderDetails = new System.Windows.Forms.Button();
            this.groupDetails = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.deleteOrderDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.bdsOrders = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.groupOrder.SuspendLayout();
            this.groupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupOrder
            // 
            this.groupOrder.Controls.Add(this.textCustomer);
            this.groupOrder.Controls.Add(this.labeltime);
            this.groupOrder.Controls.Add(this.creatTime);
            this.groupOrder.Controls.Add(this.txtId);
            this.groupOrder.Controls.Add(this.t_customer);
            this.groupOrder.Controls.Add(this.t_Id);
            this.groupOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupOrder.Location = new System.Drawing.Point(0, 0);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Size = new System.Drawing.Size(1133, 303);
            this.groupOrder.TabIndex = 0;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "订单";
            // 
            // textCustomer
            // 
            this.textCustomer.DataSource = this.bdsCustomers;
            this.textCustomer.DisplayMember = "Name";
            this.textCustomer.FormattingEnabled = true;
            this.textCustomer.Location = new System.Drawing.Point(115, 87);
            this.textCustomer.Name = "textCustomer";
            this.textCustomer.Size = new System.Drawing.Size(505, 29);
            this.textCustomer.TabIndex = 6;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Location = new System.Drawing.Point(146, 131);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(109, 21);
            this.labeltime.TabIndex = 5;
            this.labeltime.Text = "2020-4-10";
            // 
            // creatTime
            // 
            this.creatTime.AutoSize = true;
            this.creatTime.Location = new System.Drawing.Point(6, 131);
            this.creatTime.Name = "creatTime";
            this.creatTime.Size = new System.Drawing.Size(94, 21);
            this.creatTime.TabIndex = 4;
            this.creatTime.Text = "创建时间";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(505, 31);
            this.txtId.TabIndex = 2;
            // 
            // t_customer
            // 
            this.t_customer.AutoSize = true;
            this.t_customer.Location = new System.Drawing.Point(13, 87);
            this.t_customer.Name = "t_customer";
            this.t_customer.Size = new System.Drawing.Size(73, 21);
            this.t_customer.TabIndex = 1;
            this.t_customer.Text = "用户名";
            // 
            // t_Id
            // 
            this.t_Id.AutoSize = true;
            this.t_Id.Location = new System.Drawing.Point(13, 43);
            this.t_Id.Name = "t_Id";
            this.t_Id.Size = new System.Drawing.Size(73, 21);
            this.t_Id.TabIndex = 0;
            this.t_Id.Text = "订单号";
            // 
            // addOrderDetails
            // 
            this.addOrderDetails.Location = new System.Drawing.Point(12, 328);
            this.addOrderDetails.Name = "addOrderDetails";
            this.addOrderDetails.Size = new System.Drawing.Size(188, 45);
            this.addOrderDetails.TabIndex = 8;
            this.addOrderDetails.Text = "添加订单明细";
            this.addOrderDetails.UseVisualStyleBackColor = true;
            this.addOrderDetails.Click += new System.EventHandler(this.addOrderDetails_Click);
            // 
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.btnSave);
            this.groupDetails.Controls.Add(this.deleteOrderDetails);
            this.groupDetails.Controls.Add(this.dataGridView1);
            this.groupDetails.Controls.Add(this.addOrderDetails);
            this.groupDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupDetails.Location = new System.Drawing.Point(0, 161);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(1133, 385);
            this.groupDetails.TabIndex = 1;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "订单明细";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(905, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存订单";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // deleteOrderDetails
            // 
            this.deleteOrderDetails.Location = new System.Drawing.Point(240, 328);
            this.deleteOrderDetails.Name = "deleteOrderDetails";
            this.deleteOrderDetails.Size = new System.Drawing.Size(188, 45);
            this.deleteOrderDetails.TabIndex = 10;
            this.deleteOrderDetails.Text = "删除订单明细";
            this.deleteOrderDetails.UseVisualStyleBackColor = true;
            this.deleteOrderDetails.Click += new System.EventHandler(this.deleteOrderDetails_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdsDetails;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 291);
            this.dataGridView1.TabIndex = 9;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "产品名";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 175;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 175;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 175;
            // 
            // bdsDetails
            // 
            this.bdsDetails.DataMember = "Details";
            this.bdsDetails.DataSource = this.bdsOrders;
            // 
            // bdsOrders
            // 
            this.bdsOrders.DataSource = typeof(OrderLib.Order);
            // 
            // bdsCustomers
            // 
            this.bdsCustomers.DataSource = typeof(OrderLib.Customer);
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 546);
            this.Controls.Add(this.groupDetails);
            this.Controls.Add(this.groupOrder);
            this.Name = "OrderEditForm";
            this.Text = "OrderEditForm";
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            this.groupDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.Label t_customer;
        private System.Windows.Forms.Label t_Id;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button addOrderDetails;
        private System.Windows.Forms.GroupBox groupDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdsOrders;
        private System.Windows.Forms.BindingSource bdsDetails;
        private System.Windows.Forms.BindingSource bdsCustomers;
        private System.Windows.Forms.Label creatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.ComboBox textCustomer;
        private System.Windows.Forms.Button deleteOrderDetails;
        private System.Windows.Forms.Button btnSave;
    }
}