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
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.addOrder = new System.Windows.Forms.Button();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.t_customer = new System.Windows.Forms.Label();
            this.t_Id = new System.Windows.Forms.Label();
            this.groupDetails = new System.Windows.Forms.GroupBox();
            this.addOrderDetails = new System.Windows.Forms.Button();
            this.txtPdnum = new System.Windows.Forms.TextBox();
            this.txtPdPrice = new System.Windows.Forms.TextBox();
            this.txtPdId = new System.Windows.Forms.TextBox();
            this.txtPdname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pdName = new System.Windows.Forms.Label();
            this.changeOrder = new System.Windows.Forms.Button();
            this.groupOrder.SuspendLayout();
            this.groupDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOrder
            // 
            this.groupOrder.Controls.Add(this.changeOrder);
            this.groupOrder.Controls.Add(this.addOrder);
            this.groupOrder.Controls.Add(this.txtcustomer);
            this.groupOrder.Controls.Add(this.txtId);
            this.groupOrder.Controls.Add(this.t_customer);
            this.groupOrder.Controls.Add(this.t_Id);
            this.groupOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupOrder.Location = new System.Drawing.Point(0, 0);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Size = new System.Drawing.Size(442, 303);
            this.groupOrder.TabIndex = 0;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "订单";
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(222, 167);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(188, 45);
            this.addOrder.TabIndex = 4;
            this.addOrder.Text = "添加订单";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(115, 109);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(218, 31);
            this.txtcustomer.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(218, 31);
            this.txtId.TabIndex = 2;
            // 
            // t_customer
            // 
            this.t_customer.AutoSize = true;
            this.t_customer.Location = new System.Drawing.Point(12, 120);
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
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.addOrderDetails);
            this.groupDetails.Controls.Add(this.txtPdnum);
            this.groupDetails.Controls.Add(this.txtPdPrice);
            this.groupDetails.Controls.Add(this.txtPdId);
            this.groupDetails.Controls.Add(this.txtPdname);
            this.groupDetails.Controls.Add(this.label4);
            this.groupDetails.Controls.Add(this.label3);
            this.groupDetails.Controls.Add(this.label2);
            this.groupDetails.Controls.Add(this.pdName);
            this.groupDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupDetails.Location = new System.Drawing.Point(0, 238);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(442, 308);
            this.groupDetails.TabIndex = 1;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "订单明细";
            // 
            // addOrderDetails
            // 
            this.addOrderDetails.Location = new System.Drawing.Point(222, 251);
            this.addOrderDetails.Name = "addOrderDetails";
            this.addOrderDetails.Size = new System.Drawing.Size(188, 45);
            this.addOrderDetails.TabIndex = 8;
            this.addOrderDetails.Text = "添加订单明细";
            this.addOrderDetails.UseVisualStyleBackColor = true;
            this.addOrderDetails.Click += new System.EventHandler(this.addOrderDetails_Click);
            // 
            // txtPdnum
            // 
            this.txtPdnum.Location = new System.Drawing.Point(222, 192);
            this.txtPdnum.Name = "txtPdnum";
            this.txtPdnum.Size = new System.Drawing.Size(143, 31);
            this.txtPdnum.TabIndex = 7;
            // 
            // txtPdPrice
            // 
            this.txtPdPrice.Location = new System.Drawing.Point(17, 192);
            this.txtPdPrice.Name = "txtPdPrice";
            this.txtPdPrice.Size = new System.Drawing.Size(143, 31);
            this.txtPdPrice.TabIndex = 6;
            // 
            // txtPdId
            // 
            this.txtPdId.Location = new System.Drawing.Point(222, 106);
            this.txtPdId.Name = "txtPdId";
            this.txtPdId.Size = new System.Drawing.Size(143, 31);
            this.txtPdId.TabIndex = 5;
            // 
            // txtPdname
            // 
            this.txtPdname.Location = new System.Drawing.Point(16, 106);
            this.txtPdname.Name = "txtPdname";
            this.txtPdname.Size = new System.Drawing.Size(143, 31);
            this.txtPdname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "产品单价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品编号";
            // 
            // pdName
            // 
            this.pdName.AutoSize = true;
            this.pdName.Location = new System.Drawing.Point(13, 58);
            this.pdName.Name = "pdName";
            this.pdName.Size = new System.Drawing.Size(73, 21);
            this.pdName.TabIndex = 0;
            this.pdName.Text = "产品名";
            // 
            // changeOrder
            // 
            this.changeOrder.Location = new System.Drawing.Point(17, 167);
            this.changeOrder.Name = "changeOrder";
            this.changeOrder.Size = new System.Drawing.Size(188, 45);
            this.changeOrder.TabIndex = 5;
            this.changeOrder.Text = "修改订单";
            this.changeOrder.UseVisualStyleBackColor = true;
            this.changeOrder.Click += new System.EventHandler(this.changeOrder_Click);
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 546);
            this.Controls.Add(this.groupDetails);
            this.Controls.Add(this.groupOrder);
            this.Name = "OrderEditForm";
            this.Text = "OrderEditForm";
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            this.groupDetails.ResumeLayout(false);
            this.groupDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.GroupBox groupDetails;
        private System.Windows.Forms.Label t_customer;
        private System.Windows.Forms.Label t_Id;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pdName;
        private System.Windows.Forms.TextBox txtPdnum;
        private System.Windows.Forms.TextBox txtPdPrice;
        private System.Windows.Forms.TextBox txtPdId;
        private System.Windows.Forms.TextBox txtPdname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addOrderDetails;
        private System.Windows.Forms.Button changeOrder;
    }
}