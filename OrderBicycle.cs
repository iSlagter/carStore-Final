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

        //Check true if all the input is fill

        private bool IsEverythingFilled()
        {
            int IsFilled = 0;
            IsFilled += this.ChkBoxMakeAndModel.SelectedItem == null ? 1 : 0;
            IsFilled += this.ChkBoxYear.SelectedItem == null ? 1 : 0;
            IsFilled += this.ChkBoxColor.SelectedItem == null ? 1 : 0;


            return IsFilled == 0;

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
