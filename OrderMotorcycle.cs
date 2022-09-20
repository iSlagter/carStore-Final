using System;
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
    internal partial class OrderMotorcycle : Form
    {
        public Vehicle Motorcycle = null;

        public OrderMotorcycle()
        {
            InitializeComponent();
        }

        private void BtnSubmitMotorcycle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkBoxMakeAndModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
