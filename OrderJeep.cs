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
            IsFilled += this.ChkBoxDoorNumber.SelectedItem == null ? 1 : 0;

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
                bool Is4X4 = this.ChkBoxIs4x4.Checked;
                var DoorNum = this.ChkBoxDoorNumber.SelectedItem.ToString();
                string[] Number = DoorNum.Split(" ");
                int DoorNumber = int.Parse(Number[0]);
                bool IsAC = true;
                bool IsMultimedia = this.ChkBoxIsMultimedia.Checked;
                bool IsMetallicColor = this.ChkBoxIsMetallicColor.Checked;
                var MakeAndModel = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string[] MakeModel = MakeAndModel.Split(",");
                string Make = MakeModel[0];
                string Model = MakeModel[1];
                int Year = int.Parse(this.ChkBoxYear.SelectedItem.ToString());
                string Color = this.ChkBoxColor.SelectedItem.ToString();
                double Price = 0;
                switch (MakeAndModel)
                {
                    case "Toyota, Land Crusier":
                        switch (Year)
                        {
                            case 2015:
                                Price += 99000;
                                break;
                            case 2016:
                                Price += 102000;
                                break;
                            case 2017:
                                Price += 105000;
                                break;
                            case 2018:
                                Price += 120000;
                                break;
                            case 2019:
                                Price += 160000;
                                break;
                            case 2020:
                                Price += 175000;
                                break;
                            case 2021:
                                Price += 185000;
                                break;
                            case 2022:
                                Price += 250000;
                                break;
                        }
                        break;
                    case "Toyota, Rav4":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Mitsubishi, Pajero":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Mitsubishi, Outlander":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Jeep,Grand Cherokie":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Jeep, Wrengler":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Land Rover, Range Rover":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;

                    default:
                        break;
                }
                string Description  = "Good Jeep Good Price Only Today Good Discount";

                this.JeepCar = new JeepCar(Is4X4, DoorNumber, IsAC, IsMultimedia, IsMetallicColor, Make, Model, Year, Color, Price, Description);

                this.DialogResult = DialogResult.OK;
                //Close the form
                this.Close();
            }
        }

        //Fucntion to calculate the price of all the things that add to the product
        private void CalculatePrice()
        {
            //this.Warning.Text = "";
            int price = 0;
            if (ChkBoxMakeAndModel.SelectedItem != null)
            {
                string Jeep = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string year = this.ChkBoxYear.SelectedItem.ToString();


                //Add the price by the Make, Model and Year of the Jeep
                switch (Jeep)
                {
                    case "Toyota, Land Crusier":
                        switch(year)
                        {
                            case "2015":
                                price += 99000;
                                break;
                            case "2016":
                                price += 102000;
                                break;
                            case "2017":
                                price += 105000;
                                break;
                            case "2018":
                                price += 120000;
                                break;
                            case "2019":
                                price += 160000;
                                break;
                            case "2020":
                                price += 175000;
                                break;
                            case "2021":
                                price += 185000;
                                break;
                            case "2022":
                                price += 250000;
                                break;
                        }
                        break;
                    case "Toyota, Rav4":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "Mitsubishi, Pajero":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "Mitsubishi, Outlander":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "Jeep,Grand Cherokie":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "Jeep, Wrengler":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "Land Rover, Range Rover":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;

                    default:
                        break;
                }
            }
            if (this.ChkBoxIsMultimedia.Checked)
                price += 5000;
            if (this.ChkBoxIs4x4.Checked)
                price += 20000;
            if (this.ChkBoxIsMetallicColor.Checked)
                price += 5000;

            this.LblTotalPrice.Text = price.ToString();
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
            CalculatePrice();

        }

        private void BtnMetallicColor_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();

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

        private void LblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        protected void OnContentChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void OnContentChanged(object sender, ItemCheckEventArgs e)
        {
            CalculatePrice();
        }

        private void ChkBoxIs4x4_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void IsMetallicColor_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void IsMultimedia_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();

        }

        private void ChkBoxIsMetallicColor_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
    }
}
