using OrderManger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class OrderEditForm : Form
    {
        public Order EditedOrder { get; private set; }
        public OrderEditForm(Order o)
        {
            EditedOrder=o;
            InitializeComponent();
            txtId.DataBindings.Add("Text", EditedOrder, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtcustomer.DataBindings.Add("Text", EditedOrder, "CustomerName", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void changeOrder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void addOrderDetails_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtPdnum.Text.ToString());
            string Productname=txtPdname.Text.ToString();
            int ProductId = int.Parse(txtPdId.Text.ToString());
            float Price=float.Parse(txtPdPrice.Text.ToString());
            OrderDetail detail = 
            new OrderDetail(new Product(ProductId, Productname, Price), quantity);
            EditedOrder.AddDetails(detail);
        }
    }
}
