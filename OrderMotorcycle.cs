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
    internal partial class OrderMotorcycle : Form
    {
        public Vehicle Motorcycle = null;

        public OrderMotorcycle()
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

        private void BtnSubmitMotorcycle_Click(object sender, EventArgs e)
        {
            if (IsEverythingFilled())
            {
                bool IsMaunalGear = false;
                bool IsEngine = false;
                var MakeAndModel = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string[] MakeModel = MakeAndModel.Split(",");
                string Make = MakeModel[0];
                string Model = MakeModel[1];
                int Year = int.Parse(this.ChkBoxYear.SelectedItem.ToString());
                string Color = this.ChkBoxColor.SelectedItem.ToString();
                double Price = 0;
                switch (MakeAndModel)
                {
                    case "Ducati, Monster":
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
                    case "Honda, CB":
                        switch (Year)
                        {
                            case 2015:
                                Price = 35000;
                                break;
                            case 2016:
                                Price = 38000;
                                break;
                            case 2017:
                                Price = 40000;
                                break;
                            case 2018:
                                Price = 45000;
                                break;
                            case 2019:
                                Price = 50000;
                                break;
                            case 2020:
                                Price = 60000;
                                break;
                            case 2021:
                                Price = 90000;
                                break;
                            case 2022:
                                Price = 120000;
                                break;
                        }
                        break;
                    case "KTM, Duke":
                        switch (Year)
                        {
                            case 2015:
                                Price = 49000;
                                break;
                            case 2016:
                                Price = 50000;
                                break;
                            case 2017:
                                Price = 69000;
                                break;
                            case 2018:
                                Price = 76000;
                                break;
                            case 2019:
                                Price = 80000;
                                break;
                            case 2020:
                                Price = 90000;
                                break;
                            case 2021:
                                Price = 123000;
                                break;
                            case 2022:
                                Price = 130000;
                                break;
                        }
                        break;
                    case "BMW, F650GS":
                        switch (Year)
                        {
                            case 2015:
                                Price = 64000;
                                break;
                            case 2016:
                                Price = 87000;
                                break;
                            case 2017:
                                Price = 98000;
                                break;
                            case 2018:
                                Price = 103000;
                                break;
                            case 2019:
                                Price = 120000;
                                break;
                            case 2020:
                                Price = 127000;
                                break;
                            case 2021:
                                Price = 130000;
                                break;
                            case 2022:
                                Price = 150000;
                                break;
                        }
                        break;
                    case "Sanyang, Joymax":
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
                    case "Yamaha, Tmax":
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
                string Description = "Good Motorcycle Good Price Only Today Good Discount";

                this.Motorcycle = new Motorcycle(IsMaunalGear, IsEngine, Make, Model, Year, Color, Price, Description);

                this.DialogResult = DialogResult.OK;

                //Close the form
                this.Close();
            }
            //Send a warn text that for to click on submit you need to fill all the fields
            this.LblWarning.Text = "Fill All Fields!";
        }

        //Fucntion to calculate the price of all the things that add to the product
        private void CalculatePrice()
        {
            //this.Warning.Text = "";
            int price = 0;
            if (ChkBoxMakeAndModel.SelectedItem != null)
            {
                string motorcycle = ChkBoxMakeAndModel.SelectedItem.ToString();
                string year = ChkBoxYear.SelectedItem.ToString();


                //Add the price by the Make, Model and Year of the Jeep
                switch (motorcycle)
                {
                    case "Ducati, Monster":
                        switch (year)
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
                    case "Honda, CB":
                        switch (year)
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
                    case "KTM, Duke":
                        switch (year)
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
                    case "BMW, F650GS":
                        switch (year)
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
                    case "Sanyang, Joymax":
                        switch (year)
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
                    case "Yamaha, Tmax":
                        switch (year)
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
                    default:
                        break;
                }
            }
            if (this.ChkBoxIsMaunalGear.Checked)
                price += 1000;
            this.LblTotalPrice.Text = price.ToString();

        }

        private void ChkBoxMakeAndModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxMakeAndModel.SelectedIndex;
            int count = ChkBoxMakeAndModel.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxMakeAndModel.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        private void ChkBoxIsMaunalGear_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
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

        protected void OnContentChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void OnContentChanged(object sender, ItemCheckEventArgs e)
        {
            CalculatePrice();
        }
    }
}
