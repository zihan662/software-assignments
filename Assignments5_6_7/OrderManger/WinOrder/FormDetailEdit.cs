﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderLib;

namespace OrderForm {
  public partial class FormDetailEdit : Form {
    public OrderDetail Detail { get; set; }

    public FormDetailEdit() {
      InitializeComponent();
    }

    public FormDetailEdit(OrderDetail detail):this() {
      this.Detail = detail;
      this.bdsDetail.DataSource = detail;
      bdsGoods.Add(new Product(1, "apple", 100));
      bdsGoods.Add(new Product(1, "egg", 200));
    }

    private void btnOK_Click(object sender, EventArgs e) {

    }
  }
}
