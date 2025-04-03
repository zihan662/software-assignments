using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManger;
namespace WinForm
{
    public partial class Form1 : Form
    {
        private readonly OrderService orderService = new OrderService();
        private BindingSource orderBinding = new BindingSource();
        private BindingSource detailsBinding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            LoadData(null);
            InitColumns();
        }
        private void LoadData(List<Order> orders = null)
        {
            orderBinding.DataSource = orders ?? orderService.QueryAll();
            dataGridOrder.DataSource = orderBinding;
            detailsBinding.DataSource = orderBinding;
            detailsBinding.DataMember = "Details";
            dataGriddetails.DataSource = detailsBinding;
        }
        private void InitColumns()
        {
            dataGridOrder.AutoGenerateColumns = false;
            var columns = new[] {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "订单号" },
            new DataGridViewTextBoxColumn {
                DataPropertyName = "Customer.Name",
                HeaderText = "客户"
            },
            new DataGridViewTextBoxColumn {
                DataPropertyName = "TotalPrice",
                HeaderText = "总金额"
            }
        };
            dataGridOrder.Columns.AddRange(columns);

            dataGriddetails.AutoGenerateColumns = false;
            dataGriddetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "商品名称"
            });
            dataGriddetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "单价"
            });
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void creatOrder_Click(object sender, EventArgs e)
        {
            var editForm = new OrderEditForm(new Order());
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                orderService.AddOrder(editForm.EditedOrder);
                orderBinding.ResetBindings(false);
            }
        }

        private void changeOrder_Click(object sender, EventArgs e)
        {
            var o=orderService.GetOrder(int.Parse(textId.Text.ToString()));
            Order no = new Order(o.Id, o.Customer, o.CreateTime);
            no.details = o.details;
            var editForm = new OrderEditForm(no);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                orderService.UpdateOrder(editForm.EditedOrder);
                orderBinding.ResetBindings(false);
            }
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            if (orderBinding.Current is Order order)
            {
                orderService.RemoveOrder(order.Id);
                orderBinding.RemoveCurrent();
            }
        }

        private void queryOrder_Click(object sender, EventArgs e)
        {
            var results = new List<Order>();

            if (radioCustomer.Checked)
            {
                results = orderService.QueryByCustomerName(textCustomer.Text.ToString());
            }
            else if (radioProduct.Checked)
            {
                results = orderService.QueryByProductName(textProduct.Text.ToString());
            }
            else if (radioMoney.Checked)
            {
                results = orderService.QueryByTotalPrice(float.Parse(textMoney.Text.ToString()));
            }
            else
            {
                MessageBox.Show("请输入有效查询条件");
                return;
            }

            LoadData(results);
            InitColumns();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            LoadData(null);
            InitColumns();
        }
    }
}
