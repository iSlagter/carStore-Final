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
                    case "KTM, Duke":
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
                    case "BMW, F650GS":
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
        }

        //Fucntion to calculate the price of all the things that add to the product
        private void CalculatePrice()
        {
            //this.Warning.Text = "";
            int price = 0;
            if (ChkBoxMakeAndModel.SelectedItem != null)
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
            CalculatePrice();
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
    }
}
