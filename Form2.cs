﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carStore_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOrderJeep_Click(object sender, EventArgs e)
        {
            OrderJeep orderJeep = new OrderJeep();
            orderJeep.ShowDialog();
        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrderPrivateCar_Click(object sender, EventArgs e)
        {
            OrderPrivateCar orderPrivateCar = new OrderPrivateCar();
            orderPrivateCar.ShowDialog();
        }

        private void BtnOrderMotorcycle_Click(object sender, EventArgs e)
        {
            OrderMotorcycle orderMotorcycle = new OrderMotorcycle();
            orderMotorcycle.ShowDialog();
        }

        private void BtnOrderBicycle_Click(object sender, EventArgs e)
        {
            OrderBicycle orderBicycle = new OrderBicycle();

            orderBicycle.ShowDialog();
        }

        private void BtnLoadOrder_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
