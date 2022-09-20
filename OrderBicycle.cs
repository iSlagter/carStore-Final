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
    internal partial class OrderBicycle : Form
    {
        public Vehicle Bicycle = null;

        public OrderBicycle()
        {
            InitializeComponent();
        }

        private void BtnSubmitBicycle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkBoxMakeAndModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
