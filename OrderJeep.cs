using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carStore_Final
{
    internal partial class OrderJeep : Form
    {
        public Vehicle JeepCar = null;
        public OrderJeep()
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
            IsFilled += this.Btn4x4.Checked == true ? 1 : 0;
            IsFilled += this.BtnMetallicColor.Checked == true ? 1 : 0;
            IsFilled += this.ChkBoxDoorNumber.SelectedItem == null ? 1 : 0;
            IsFilled += this.BtnIsMultimedia.Checked == true ? 1 : 0;

            return IsFilled == 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmitJeep_Click(object sender, EventArgs e)
        {
            //Check that EverythingFilled and return true
            if (IsEverythingFilled())
            {
                bool Is4X4 = this.Btn4x4.Checked;
                var DoorNum = this.ChkBoxDoorNumber.SelectedItem.ToString();
                string[] Number = DoorNum.Split(" ");
                int DoorNumber = int.Parse(Number[0]);
                bool IsAC = true;
                bool IsMultimedia = this.BtnIsMultimedia.Checked;
                bool IsMetallicColor = this.BtnMetallicColor.Checked;
                var MakeAndModel = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string[] MakeModel = MakeAndModel.Split(",");
                string Make = MakeModel[0];
                string Model = MakeModel[1];
                int Year = int.Parse(this.ChkBoxYear.SelectedItem.ToString());
                string Color = this.ChkBoxColor.SelectedItem.ToString();
                double Price = 0;
                string Description  = "Good Jeep Good Price Only Today Good Discount";

                this.JeepCar = new JeepCar(Is4X4, DoorNumber, IsAC, IsMultimedia, IsMetallicColor, Make, Model, Year, Color, Price, Description);

                this.DialogResult = DialogResult.OK;
                //Close the form
                this.Close();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxMakeAndModel.SelectedIndex;
            int count = ChkBoxMakeAndModel.Items.Count;
            for(int x = 0; x<count;x++)
            {
                if (index != x)
                {
                    ChkBoxMakeAndModel.SetItemCheckState(x, CheckState.Unchecked);
                }
            }

        }

        private void ChkBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxYear.SelectedIndex;
            int count = ChkBoxYear.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxYear.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        private void ChkBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxColor.SelectedIndex;
            int count = ChkBoxColor.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxColor.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        private void Btn4x4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnMetallicColor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkBoxDoorNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxDoorNumber.SelectedIndex;
            int count = ChkBoxDoorNumber.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxDoorNumber.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }
    }
}
