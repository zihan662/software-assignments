using OrderLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinForm
{
    public partial class OrderEditForm : Form
    {
        public Order EditedOrder { get; private set; }
        public OrderEditForm(Order o)
        {
            InitializeComponent();
            EditedOrder = o;
            bdsOrders.DataSource = o;
            bdsCustomers.Add(new Customer(1, "li"));
            bdsCustomers.Add(new Customer(2, "zhang"));
            txtId.DataBindings.Add("Text", EditedOrder, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            textCustomer.DataBindings.Add("Text", EditedOrder, "CustomerName", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void addOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetailsForm formDetailEdit = new OrderDetailsForm(new OrderDetail());
            try
            {
                if (formDetailEdit.ShowDialog() == DialogResult.OK)
                {
                    int index = 0;
                    if (EditedOrder.Details.Count != 0)
                    {
                        index = EditedOrder.Details.Max(i => i.Index) + 1;
                    }
                    formDetailEdit.Detail.Index = index;
                    EditedOrder.AddDetails(formDetailEdit.Detail);
                    bdsDetails.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void deleteOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            EditedOrder.RemoveDetail(detail);
            bdsDetails.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditedOrder.Customer=textCustomer.SelectedItem as Customer;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
