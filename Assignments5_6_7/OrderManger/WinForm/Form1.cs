using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OrderLib;
namespace WinForm
{
    public partial class Form1 : Form
    {
        private readonly OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
            InitOrders();
            bdsOrders.DataSource = orderService.QueryAll();
            try
            {
                using (var conn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["OrderDatabase"].ConnectionString))
                {
                    conn.Open();
                    MessageBox.Show($"连接成功！服务器版本：{conn.ServerVersion}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库连接失败：{ex.Message}");
                Environment.Exit(1); // 立即退出防止空窗体
            }
        }
        private void InitOrders()
        {
            Order order = new Order(1, new Customer(1, "li"), DateTime.Now);
            order.AddDetails(new OrderDetail(1,new Product(1, "apple", 100), 10));
            order.AddDetails(new OrderDetail(2, new Product(2, "egg", 50), 61));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer(2, "zhang"),DateTime.Now);
            order2.AddDetails(new OrderDetail(1,new Product(2, "egg", 200), 10));
            orderService.AddOrder(order2);
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
                bdsOrders.ResetBindings(false);
            }
        }

        private void changeOrder_Click(object sender, EventArgs e)
        {
            Order o = bdsOrders.Current as Order;
            if (o == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            Order no = new Order(o.Id, o.Customer, o.CreateTime);
            no.details = o.details;
            var editForm = new OrderEditForm(no);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                orderService.UpdateOrder(editForm.EditedOrder);
                bdsOrders.ResetBindings(false);
            }
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            Order order = bdsOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            DialogResult result = MessageBox.Show($"确认要删除Id为{order.Id}的订单吗？", "删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orderService.RemoveOrder(order.Id);
                bdsOrders.DataSource = orderService.QueryAll();
                bdsOrders.ResetBindings(false);
            }
        }

        private void queryOrder_Click(object sender, EventArgs e)
        {

            if (radioCustomer.Checked)
            {
                bdsOrders.DataSource = orderService.QueryByCustomerName(textCustomer.Text.ToString());
            }
            else if (radioId.Checked)
            {
                bdsOrders.DataSource = orderService.GetOrder(Convert.ToInt32(textId.Text.ToString()));
            }
            else if (radioProduct.Checked)
            {
                bdsOrders.DataSource = orderService.QueryByProductName(textProduct.Text.ToString());
            }
            else if (radioMoney.Checked)
            {
                bdsOrders.DataSource = orderService.QueryByTotalPrice(float.Parse(textMoney.Text.ToString()));
            }
            else
            {
                MessageBox.Show("请输入有效查询条件");
                return;
            }
            bdsOrders.ResetBindings(false);
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            bdsOrders.DataSource = orderService.QueryAll();
            bdsOrders.ResetBindings(false);
        }
    }
}
