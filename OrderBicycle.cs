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
                                Price += 1099;
                                break;
                            case 2016:
                                Price += 1200;
                                break;
                            case 2017:
                                Price += 2999;
                                break;
                            case 2018:
                                Price += 3600;
                                break;
                            case 2019:
                                Price += 4200;
                                break;
                            case 2020:
                                Price += 5000;
                                break;
                            case 2021:
                                Price += 5400;
                                break;
                            case 2022:
                                Price += 6000;
                                break;
                        }
                        break;
                    case "Cannondale, SuperSix":
                        switch (Year)
                        {
                            case 2015:
                                Price = 1000;
                                break;
                            case 2016:
                                Price = 1200;
                                break;
                            case 2017:
                                Price = 2000;
                                break;
                            case 2018:
                                Price = 2400;
                                break;
                            case 2019:
                                Price = 2999;
                                break;
                            case 2020:
                                Price = 3300;
                                break;
                            case 2021:
                                Price = 3600;
                                break;
                            case 2022:
                                Price = 4000;
                                break;
                        }
                        break;
                    case "Mongoose, Salvo":
                        switch (Year)
                        {
                            case 2015:
                                Price = 1000;
                                break;
                            case 2016:
                                Price = 1300;
                                break;
                            case 2017:
                                Price = 1500;
                                break;
                            case 2018:
                                Price = 2000;
                                break;
                            case 2019:
                                Price = 2200;
                                break;
                            case 2020:
                                Price = 2500;
                                break;
                            case 2021:
                                Price = 2800;
                                break;
                            case 2022:
                                Price = 2900;
                                break;
                        }
                        break;
                    case "Mongoose, BMX":
                        switch (Year)
                        {
                            case 2015:
                                Price = 600;
                                break;
                            case 2016:
                                Price = 650;
                                break;
                            case 2017:
                                Price = 690;
                                break;
                            case 2018:
                                Price = 750;
                                break;
                            case 2019:
                                Price = 790;
                                break;
                            case 2020:
                                Price = 800;
                                break;
                            case 2021:
                                Price = 850;
                                break;
                            case 2022:
                                Price = 1000;
                                break;
                        }
                        break;
                    case "Specialized, Levo":
                        switch (Year)
                        {
                            case 2015:
                                Price = 3000;
                                break;
                            case 2016:
                                Price = 3500;
                                break;
                            case 2017:
                                Price = 3900;
                                break;
                            case 2018:
                                Price = 4500;
                                break;
                            case 2019:
                                Price = 5000;
                                break;
                            case 2020:
                                Price = 6000;
                                break;
                            case 2021:
                                Price = 7000;
                                break;
                            case 2022:
                                Price = 8000;
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
            this.LblWarning.Text = "";
            int price = 0;
            if (ChkBoxMakeAndModel.SelectedItem.ToString() != null)
            {
                string bicycle = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string year = ChkBoxYear.SelectedItem.ToString();


                //Add the price by the Make, Model and Year of the Jeep
                switch (bicycle)
                {
                    case "Trek, Marlin":
                        switch (year)
                        {
                            case "2015":
                                price += 1099;
                                break;
                            case "2016":
                                price += 1200;
                                break;
                            case "2017":
                                price += 2999;
                                break;
                            case "2018":
                                price += 3600;
                                break;
                            case "2019":
                                price += 4200;
                                break;
                            case "2020":
                                price += 5000;
                                break;
                            case "2021":
                                price += 5400;
                                break;
                            case "2022":
                                price += 6000;
                                break;
                        }
                        break;
                    case "Cannondale, SuperSix":
                        switch (year)
                        {
                            case "2015":
                                price = 1000;
                                break;
                            case "2016":
                                price = 1200;
                                break;
                            case "2017":
                                price = 2000;
                                break;
                            case "2018":
                                price = 2400;
                                break;
                            case "2019":
                                price = 2999;
                                break;
                            case "2020":
                                price = 3300;
                                break;
                            case "2021":
                                price = 3600;
                                break;
                            case "2022":
                                price = 4000;
                                break;
                        }
                        break;
                    case "Mongoose, Salvo":
                        switch (year)
                        {
                            case "2015":
                                price = 1000;
                                break;
                            case "2016":
                                price = 1300;
                                break;
                            case "2017":
                                price = 1500;
                                break;
                            case "2018":
                                price = 2000;
                                break;
                            case "2019":
                                price = 2200;
                                break;
                            case "2020":
                                price = 2500;
                                break;
                            case "2021":
                                price = 2800;
                                break;
                            case "2022":
                                price = 2900;
                                break;
                        }
                        break;
                    case "Mongoose, BMX":
                        switch (year)
                        {
                            case "2015":
                                price = 600;
                                break;
                            case "2016":
                                price = 650;
                                break;
                            case "2017":
                                price = 690;
                                break;
                            case "2018":
                                price = 750;
                                break;
                            case "2019":
                                price = 790;
                                break;
                            case "2020":
                                price = 800;
                                break;
                            case "2021":
                                price = 850;
                                break;
                            case "2022":
                                price = 1000;
                                break;
                        }
                        break;
                    case "Specialized, Levo":
                        switch (year)
                        {
                            case "2015":
                                price = 3000;
                                break;
                            case "2016":
                                price = 3500;
                                break;
                            case "2017":
                                price = 3900;
                                break;
                            case "2018":
                                price = 4500;
                                break;
                            case "2019":
                                price = 5000;
                                break;
                            case "2020":
                                price = 6000;
                                break;
                            case "2021":
                                price = 7000;
                                break;
                            case "2022":
                                price = 8000;
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (this.ChkBoxIsDiscBreak.Checked)
                price += 900;

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

        private void ChkBoxIsDiscBreak_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
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
