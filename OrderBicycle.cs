using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            if (IsEverythingFilled())
            {
                string Kind = "";
                int NumberGears = 1;
                bool IsEngine = false;
                bool IsDiscBreak = this.ChkBoxIsDiscBreak.Checked;
                var MakeAndModel = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string[] MakeModel = MakeAndModel.Split(",");
                string Make = MakeModel[0];
                string Model = MakeModel[1];
                int Year = int.Parse(this.ChkBoxYear.SelectedItem.ToString());
                string Color = this.ChkBoxColor.SelectedItem.ToString();
                double Price = 0;
                switch (MakeAndModel)
                {
                    case "Trek, Marlin":
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
                    case "Cannondale, SuperSix":
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
                    case "Mongoose, Salvo":
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
                    case "Mongoose, BMX":
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
                    case "Specialized, Levo":
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
                string Description = "Good Bicycle Good Price Only Today Good Discount";

                this.Bicycle = new Bicycle(Kind,IsDiscBreak,NumberGears,IsEngine, Make, Model, Year, Color, Price, Description);

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
            if (ChkBoxMakeAndModel.SelectedItem != null & ChkBoxYear.SelectedItem != null)
            {
                string bicycle = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                int year = int.Parse(this.ChkBoxYear.SelectedItem.ToString());


                //Add the price by the Make, Model and Year of the Jeep
                switch (bicycle)
                {
                    case "Trek, Marlin":
                        switch (year)
                        {
                            case 2015:
                                price += 99000;
                                break;
                            case 2016:
                                price += 102000;
                                break;
                            case 2017:
                                price += 105000;
                                break;
                            case 2018:
                                price += 120000;
                                break;
                            case 2019:
                                price += 160000;
                                break;
                            case 2020:
                                price += 175000;
                                break;
                            case 2021:
                                price += 185000;
                                break;
                            case 2022:
                                price += 250000;
                                break;
                        }
                        break;
                    case "Cannondale, SuperSix":
                        switch (year)
                        {
                            case 2015:
                                price = 99000;
                                break;
                            case 2016:
                                price = 102000;
                                break;
                            case 2017:
                                price = 105000;
                                break;
                            case 2018:
                                price = 120000;
                                break;
                            case 2019:
                                price = 160000;
                                break;
                            case 2020:
                                price = 175000;
                                break;
                            case 2021:
                                price = 185000;
                                break;
                            case 2022:
                                price = 250000;
                                break;
                        }
                        break;
                    case "Mongoose, Salvo":
                        switch (year)
                        {
                            case 2015:
                                price = 99000;
                                break;
                            case 2016:
                                price = 102000;
                                break;
                            case 2017:
                                price = 105000;
                                break;
                            case 2018:
                                price = 120000;
                                break;
                            case 2019:
                                price = 160000;
                                break;
                            case 2020:
                                price = 175000;
                                break;
                            case 2021:
                                price = 185000;
                                break;
                            case 2022:
                                price = 250000;
                                break;
                        }
                        break;
                    case "Mongoose, BMX":
                        switch (year)
                        {
                            case 2015:
                                price = 99000;
                                break;
                            case 2016:
                                price = 102000;
                                break;
                            case 2017:
                                price = 105000;
                                break;
                            case 2018:
                                price = 120000;
                                break;
                            case 2019:
                                price = 160000;
                                break;
                            case 2020:
                                price = 175000;
                                break;
                            case 2021:
                                price = 185000;
                                break;
                            case 2022:
                                price = 250000;
                                break;
                        }
                        break;
                    case "Specialized, Levo":
                        switch (year)
                        {
                            case 2015:
                                price = 99000;
                                break;
                            case 2016:
                                price = 102000;
                                break;
                            case 2017:
                                price = 105000;
                                break;
                            case 2018:
                                price = 120000;
                                break;
                            case 2019:
                                price = 160000;
                                break;
                            case 2020:
                                price = 175000;
                                break;
                            case 2021:
                                price = 185000;
                                break;
                            case 2022:
                                price = 250000;
                                break;
                        }
                        break;
                    default:
                        break;
                }
                CalculatePrice();
            }
            if (this.ChkBoxIsDiscBreak.Checked)
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
            CalculatePrice();
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
            CalculatePrice();
        }

        private void ChkBoxIsDiscBreak_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
    } }
