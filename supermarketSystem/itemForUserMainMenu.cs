﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarketSystem
{
    public partial class itemForUserMainMenu : Form
    {
        public itemForUserMainMenu()
        {
            InitializeComponent();
        }
        public product Product;

        private void btnadd_Click(object sender, EventArgs e)
        {
            Global.currProduct = this.Product;
            QuantityForm Qf = new QuantityForm();
            Qf.ShowDialog();
        }
    }
}
