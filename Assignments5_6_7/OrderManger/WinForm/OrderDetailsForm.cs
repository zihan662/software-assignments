using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderLib;

namespace WinForm
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDetail Detail { get; set; }
        public OrderDetailsForm()
        {
            InitializeComponent();
        }
        public OrderDetailsForm(OrderDetail detail) : this()
        {
            this.Detail = detail;
            this.bdsDetail.DataSource = detail;
            bdsProduct.Add(new Product(1, "apple", 100));
            bdsProduct.Add(new Product(1, "egg", 200));
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Detail.Quantity=int.Parse(num.Text.ToString());
            Detail.Product=comboBox1.SelectedItem as Product;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
